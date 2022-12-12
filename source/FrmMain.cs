using StackExchange.Redis;


namespace RedisClient
{
    public partial class FrmMain : Form
    {
        private delegate void TextboxCallback(string format, params object[] args);
        private RedisConnection _redisConnection;
        private string connectingstr = @"hostname.redis.cache.windows.net:6380,password=Ndjuilsdkflsk554sdfkjwelkfdslfk=,ssl=true,abortConnect=false";
        
        public FrmMain() => InitializeComponent();

        public async void ConnectRedis(string connectingstring)
        {
            _redisConnection = await RedisConnection.InitializeAsync(connectingstring);
            connectingstr = connectingstring;
            EnablePanel(_redisConnection.IsConnected);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using(FrmRedisConnect frmRedisConnect = new FrmRedisConnect(this)) {

                if(frmRedisConnect.ShowDialog(this) == DialogResult.OK) {


                    TraceOut("Redis Connected");
                }
            }
        }

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            await _redisConnection.CloseConnectAsync();

            EnablePanel(_redisConnection.IsConnected);

            _redisConnection.Dispose();
            TraceOut("Redis Disconnected");
        }

        private void EnablePanel(bool value)
        {
            btnConnect.Enabled = !value;
            btnDisconnect.Enabled = value;

            gbCommand.Enabled = value;
            gbPubSub.Enabled = value;
            gbDatabase.Enabled = value;
        }

        public string GetConnectingString()
        {
            // 샘플 Connecting String
            return connectingstr;
        }
              
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _redisConnection?.Dispose();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TraceOut("Program Start");
            // txbConnectStr.Text = @"southmw.redis.cache.windows.net:6380,password=NgUAcN5q90roSFNCo7G96OzK1idNR0C0TAzCaPqbp4E=,ssl=True,abortConnect=False";
            txbSendChannal.Text = "CH01";
            txbWaitChannal.Text = "CH01";
            txbSendMessage.Text = "Test Message";

            txbGetKey.Text = "Key001";
            txbSetKey.Text = "Key001";
            txbSetValue.Text = "Test Value01";

            EnablePanel(false);
        }

        private void TraceOut(string format, params object[] args)
        {
            if(InvokeRequired) {
                TextboxCallback d = new TextboxCallback(TraceOut);
                object[] aArgs = { format, args };
                Invoke(d, aArgs);
            } else {
                string msg = string.Format(format, args);

                if((txbDebug.TextLength + 1) >= txbDebug.MaxLength) {
                    txbDebug.Clear();
                }

                txbDebug.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")}] > {msg}");
                txbDebug.AppendText(Environment.NewLine);
            }
        }

        private async void btnPingTest_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut("Cache command: PING");
                RedisResult pingResult = await _redisConnection.BasicRetryAsync(async (db) => await db.ExecuteAsync("PING"));
                TraceOut($"Cache response: {pingResult}");
            }
        }

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut($"Publish channel: {txbSendChannal.Text}");

                long value = await _redisConnection.PubSubRetryAsync(async (sub) =>
                await sub.PublishAsync(txbSendChannal.Text, txbSendMessage.Text));
            }
        }

        private async void btnSubscribeChannal_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut($"Subscribe channel: {txbWaitChannal.Text}");

                object value = await _redisConnection.PubSubRetryAsync((sub) =>
                Task.FromResult(sub.SubscribeAsync(txbWaitChannal.Text, (channel, message) =>
                TraceOut($"{channel}: {message}"))));
            }
        }

        private async void btnUbsubscribeChannal_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut($"Unsubscribe channel: {txbWaitChannal.Text}");

                object value = await _redisConnection.PubSubRetryAsync((sub) => Task.FromResult(sub.UnsubscribeAsync(txbWaitChannal.Text)));
            }
        }

        private async void btnGetInfos_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut("Cache command: INFO");
                RedisResult pingResult = await _redisConnection.BasicRetryAsync(async (db) => await db.ExecuteAsync("INFO"));
                TraceOut($"Cache response: {pingResult}");
            }
        }

        private async void btnSetData_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut($"Cache command: SET {txbSetKey.Text} \"{txbSetValue.Text}\" via StringSetAsync()");
                bool stringSetResult = await _redisConnection.BasicRetryAsync(async (db) => await db.StringSetAsync(txbSetKey.Text, txbSetValue.Text));
                TraceOut($"Cache response: {stringSetResult}");
            }
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected) {
                TraceOut($"Cache command: GET {txbGetKey.Text} via StringGetAsync()");
                RedisValue stringGetResult = await _redisConnection.BasicRetryAsync(async (db) => await db.StringGetAsync(txbGetKey.Text));
                TraceOut($"Cache response: {stringGetResult}");
            }
        }

        private async void btnCustomCommand_Click(object sender, EventArgs e)
        {
            if(_redisConnection.IsConnected && !string.IsNullOrEmpty(txbCustomCommand.Text)) {
                TraceOut($"Cache Custom Command: {txbCustomCommand.Text}");
                try {
                    RedisResult CustomCmdResult;
                    string[] tempstr = txbCustomCommand.Text.Split(' ');
                    string cmd = tempstr[0];

                    if(tempstr.Length > 1) {
                        string[] args = new string[tempstr.Length - 1];
                        Array.Copy(tempstr, 1, args, 0, tempstr.Length - 1);

                        CustomCmdResult = await _redisConnection.BasicRetryAsync(async (db) => await db.ExecuteAsync(cmd, args));
                    } else {
                        CustomCmdResult = await _redisConnection.BasicRetryAsync(async (db) => await db.ExecuteAsync(cmd));
                    }

                    TraceOut($"Cache response: {CustomCmdResult}");

                } catch(Exception ex) {
                    TraceOut($"Error : {ex.Message}");
                }
            } else {
                TraceOut($"명령어를 입력하지 않았습니다.");
            }
        }
    }
}