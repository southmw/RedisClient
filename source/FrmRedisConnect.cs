namespace RedisClient
{
    public partial class FrmRedisConnect : Form
    {
        private FrmMain frmMain;
        private string ConnectingString = string.Empty;

        public FrmRedisConnect(FrmMain owner)
        {
            frmMain = owner;
            InitializeComponent();
        }

        private void FrmRedisConnect_Load(object sender, EventArgs e)
        {
            ConnectingString = frmMain.GetConnectingString();
            SerDetailData(ConnectingString);
            if(this.rbtnDetailInfo.Checked) {
                this.plDetailInfo.Visible = true;
                this.plConnectingString.Visible = false;
            } else {
                this.plDetailInfo.Visible = false;
                this.plConnectingString.Visible = true;
            }
        }

        private void SerDetailData(string connectingString)
        {
            if(!string.IsNullOrWhiteSpace(connectingString)) {
                string[] tmpstring = connectingString.Split(',');

                foreach(string temp in tmpstring) {
                    if(temp.ToUpper().Contains("PASSWORD=")) {
                        txbPassword.Text = temp.Substring(9, temp.Length - 9);
                    } else if(temp.ToUpper().Contains("SSL=")) {
                        cbSSL.Checked = temp.Substring(4, temp.Length - 4).ToLower().Equals("true") ? true : false;
                    } else if(temp.ToUpper().Contains("ABORTCONNECT=")) {
                        cbAbortConnect.Checked = temp.Substring(13, temp.Length - 13).ToLower().Equals("true") ? true : false;
                    } else {
                        string[] host = temp.Split(':');
                        txbHostName.Text = host[0];
                        txbSslport.Text = host[1];
                    }
                }

                txbConnectingString.Text = connectingString;
            }
        }

        private void InfoData_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbtnDetailInfo.Checked) {
                this.plDetailInfo.Visible = true;
                this.plConnectingString.Visible = false;
            } else {
                this.plDetailInfo.Visible = false;
                this.plConnectingString.Visible = true;
            }
        }

        private string CreateConnectingString()
        {
            return $"{txbHostName.Text}:{txbSslport.Text},password={txbPassword.Text},ssl={BooltoString(cbSSL.Checked)},abortConnect={BooltoString(cbAbortConnect.Checked)}";
        }

        private string BooltoString(bool value)
        {
            return value ? "true" : "false";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ConnectingString = rbtnDetailInfo.Checked ? CreateConnectingString() : txbConnectingString.Text;
            frmMain.ConnectRedis(ConnectingString);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
