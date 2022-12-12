using StackExchange.Redis;
using System.Net;
using System.Net.Sockets;

namespace RedisClient
{
    internal class RedisConnection : IDisposable
    {
        private long _lastReconnectTicks = DateTimeOffset.MinValue.UtcTicks;
        private DateTimeOffset _firstErrorTime = DateTimeOffset.MinValue;
        private DateTimeOffset _previousErrorTime = DateTimeOffset.MinValue;

        private readonly TimeSpan ReconnectMinInterval = TimeSpan.FromSeconds(60);

        private readonly TimeSpan ReconnectErrorThreshold = TimeSpan.FromSeconds(30);
        private readonly TimeSpan RestartConnectionTimeout = TimeSpan.FromSeconds(15);
        private const int RetryMaxAttempts = 5;

        private SemaphoreSlim _reconnectSemaphore = new SemaphoreSlim(initialCount: 1, maxCount: 1);

        private readonly string ConnectionString = string.Empty;
        private ConnectionMultiplexer rdsConnection;

        private IDatabase _database;
        private ISubscriber _subscriber;

        public bool IsConnected => rdsConnection.IsConnected;
        public EndPoint[] EndPoints => rdsConnection.GetEndPoints();
        public string ClientName => rdsConnection.ClientName;
        public string Configuration => rdsConnection.Configuration;

        private RedisConnection(string connectionStr)
        {
            if(connectionStr is not null)
                ConnectionString = connectionStr;
        }

        public static async Task<RedisConnection> InitializeAsync(string connectionStr)
        {
            RedisConnection redisConnection = new RedisConnection(connectionStr);
            await redisConnection.ForceReconnectAsync(initializing: true);
            return redisConnection;
        }

        public async Task CloseConnectAsync()
        {
            if(rdsConnection != null) {
                try {
                    await rdsConnection.CloseAsync();
                } catch {
                    // Ignore any errors from the old connection
                }
            }
        }

        private async Task ForceReconnectAsync(bool initializing = false)
        {
            long previousTicks = Interlocked.Read(ref _lastReconnectTicks);
            var previousReconnectTime = new DateTimeOffset(previousTicks, TimeSpan.Zero);
            TimeSpan elapsedSinceLastReconnect = DateTimeOffset.UtcNow - previousReconnectTime;

            // We want to limit how often we perform this top-level reconnect, so we check how long it's been since our last attempt.
            if(elapsedSinceLastReconnect < ReconnectMinInterval) return;

            try {
                await _reconnectSemaphore.WaitAsync(RestartConnectionTimeout);
            } catch {
                // If we fail to enter the semaphore, then it is possible that another thread has already done so.
                // ForceReconnectAsync() can be retried while connectivity problems persist.
                return;
            }

            try {
                var utcNow = DateTimeOffset.UtcNow;
                elapsedSinceLastReconnect = utcNow - previousReconnectTime;

                if(_firstErrorTime == DateTimeOffset.MinValue && !initializing) {
                    // We haven't seen an error since last reconnect, so set initial values.
                    _firstErrorTime = utcNow;
                    _previousErrorTime = utcNow;
                    return;
                }

                if(elapsedSinceLastReconnect < ReconnectMinInterval) {
                    return; // Some other thread made it through the check and the lock, so nothing to do.
                }

                TimeSpan elapsedSinceFirstError = utcNow - _firstErrorTime;
                TimeSpan elapsedSinceMostRecentError = utcNow - _previousErrorTime;

                bool shouldReconnect =
                    elapsedSinceFirstError >= ReconnectErrorThreshold // Make sure we gave the multiplexer enough time to reconnect on its own if it could.
                    && elapsedSinceMostRecentError <= ReconnectErrorThreshold; // Make sure we aren't working on stale data (e.g. if there was a gap in errors, don't reconnect yet).

                // Update the previousErrorTime timestamp to be now (e.g. this reconnect request).
                _previousErrorTime = utcNow;

                if(!shouldReconnect && !initializing) {
                    return;
                }

                _firstErrorTime = DateTimeOffset.MinValue;
                _previousErrorTime = DateTimeOffset.MinValue;

                if(rdsConnection != null) {
                    try {
                        await rdsConnection.CloseAsync();
                    } catch {
                        // Ignore any errors from the old connection
                    }
                }

                Interlocked.Exchange(ref rdsConnection, null);
                ConnectionMultiplexer newConnection = await ConnectionMultiplexer.ConnectAsync(ConnectionString);
                Interlocked.Exchange(ref rdsConnection, newConnection);

                Interlocked.Exchange(ref _lastReconnectTicks, utcNow.UtcTicks);
                IDatabase newDatabase = rdsConnection.GetDatabase();
                ISubscriber newSubscriber = rdsConnection.GetSubscriber();
                Interlocked.Exchange(ref _database, newDatabase);
                Interlocked.Exchange(ref _subscriber, newSubscriber);
            } finally {
                _reconnectSemaphore.Release();
            }
        }

        public async Task<T> BasicRetryAsync<T>(Func<IDatabase, Task<T>> func)
        {
            int reconnectRetry = 0;

            while(true) {
                try {
                    return await func(_database);
                } catch(Exception ex) when(ex is RedisConnectionException || ex is SocketException || ex is ObjectDisposedException) {
                    reconnectRetry++;

                    if(reconnectRetry > RetryMaxAttempts) {
                        throw;
                    }

                    try {
                        await ForceReconnectAsync();
                    } catch(ObjectDisposedException) { }

                    return await func(_database);
                }
            }
        }

        public async Task<T> PubSubRetryAsync<T>(Func<ISubscriber, Task<T>> func)
        {
            int reconnectRetry = 0;

            while(true) {
                try {
                    return await func(_subscriber); ;
                } catch(Exception ex) when(ex is RedisConnectionException || ex is SocketException || ex is ObjectDisposedException) {
                    reconnectRetry++;

                    if(reconnectRetry > RetryMaxAttempts) {
                        throw;
                    }

                    try {
                        await ForceReconnectAsync();
                    } catch(ObjectDisposedException) { }


                    return await func(_subscriber);
                }
            }
        }

        public async Task PubSubRetryAsync<T>(Func<ISubscriber, Task> func)
        {
            int reconnectRetry = 0;

            while(true) {
                try {
                    await func(_subscriber);
                    return;
                } catch(Exception ex) when(ex is RedisConnectionException || ex is SocketException || ex is ObjectDisposedException) {
                    reconnectRetry++;

                    if(reconnectRetry > RetryMaxAttempts) {
                        throw;
                    }

                    try {
                        await ForceReconnectAsync();
                    } catch(ObjectDisposedException) { }

                    await func(_subscriber);
                    return;
                }
            }
        }

        #region IDisposable Implementation
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if(!disposedValue) {
                if(disposing) {
                    // TODO: 관리형 상태(관리형 개체)를 삭제합니다.
                    try {
                        if(rdsConnection is not null) {
                            rdsConnection.Dispose();
                        }
                    } catch(Exception) {
                        throw;
                    }
                }

                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.
                disposedValue = true;
            }
        }

        // // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
        // ~RedisConnection()
        // {
        //     // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
