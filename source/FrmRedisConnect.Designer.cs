namespace RedisClient
{
    partial class FrmRedisConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHostName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnDetailInfo = new System.Windows.Forms.RadioButton();
            this.rbtnConnectingString = new System.Windows.Forms.RadioButton();
            this.plDetailInfo = new System.Windows.Forms.Panel();
            this.cbAbortConnect = new System.Windows.Forms.CheckBox();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.txbSslport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plConnectingString = new System.Windows.Forms.Panel();
            this.txbConnectingString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plDetailInfo.SuspendLayout();
            this.plConnectingString.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txbHostName
            // 
            this.txbHostName.Location = new System.Drawing.Point(87, 3);
            this.txbHostName.Name = "txbHostName";
            this.txbHostName.Size = new System.Drawing.Size(310, 25);
            this.txbHostName.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(87, 34);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(287, 25);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 72);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConnect.Location = new System.Drawing.Point(102, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 35);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnDetailInfo);
            this.panel3.Controls.Add(this.rbtnConnectingString);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 29);
            this.panel3.TabIndex = 1;
            // 
            // rbtnDetailInfo
            // 
            this.rbtnDetailInfo.AutoSize = true;
            this.rbtnDetailInfo.Checked = true;
            this.rbtnDetailInfo.Location = new System.Drawing.Point(3, 3);
            this.rbtnDetailInfo.Name = "rbtnDetailInfo";
            this.rbtnDetailInfo.Size = new System.Drawing.Size(63, 21);
            this.rbtnDetailInfo.TabIndex = 0;
            this.rbtnDetailInfo.TabStop = true;
            this.rbtnDetailInfo.Text = "Detail";
            this.rbtnDetailInfo.UseVisualStyleBackColor = true;
            this.rbtnDetailInfo.CheckedChanged += new System.EventHandler(this.InfoData_CheckedChanged);
            // 
            // rbtnConnectingString
            // 
            this.rbtnConnectingString.AutoSize = true;
            this.rbtnConnectingString.Location = new System.Drawing.Point(72, 3);
            this.rbtnConnectingString.Name = "rbtnConnectingString";
            this.rbtnConnectingString.Size = new System.Drawing.Size(133, 21);
            this.rbtnConnectingString.TabIndex = 0;
            this.rbtnConnectingString.Text = "ConnectingString";
            this.rbtnConnectingString.UseVisualStyleBackColor = true;
            this.rbtnConnectingString.CheckedChanged += new System.EventHandler(this.InfoData_CheckedChanged);
            // 
            // plDetailInfo
            // 
            this.plDetailInfo.Controls.Add(this.cbAbortConnect);
            this.plDetailInfo.Controls.Add(this.cbSSL);
            this.plDetailInfo.Controls.Add(this.txbSslport);
            this.plDetailInfo.Controls.Add(this.txbPassword);
            this.plDetailInfo.Controls.Add(this.label1);
            this.plDetailInfo.Controls.Add(this.label4);
            this.plDetailInfo.Controls.Add(this.txbHostName);
            this.plDetailInfo.Controls.Add(this.label2);
            this.plDetailInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDetailInfo.Location = new System.Drawing.Point(0, 0);
            this.plDetailInfo.Name = "plDetailInfo";
            this.plDetailInfo.Size = new System.Drawing.Size(400, 106);
            this.plDetailInfo.TabIndex = 4;
            // 
            // cbAbortConnect
            // 
            this.cbAbortConnect.AutoSize = true;
            this.cbAbortConnect.Location = new System.Drawing.Point(231, 67);
            this.cbAbortConnect.Name = "cbAbortConnect";
            this.cbAbortConnect.Size = new System.Drawing.Size(112, 21);
            this.cbAbortConnect.TabIndex = 3;
            this.cbAbortConnect.Text = "AbortConnect";
            this.cbAbortConnect.UseVisualStyleBackColor = true;
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(177, 67);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(48, 21);
            this.cbSSL.TabIndex = 3;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // txbSslport
            // 
            this.txbSslport.Location = new System.Drawing.Point(87, 65);
            this.txbSslport.Name = "txbSslport";
            this.txbSslport.Size = new System.Drawing.Size(84, 25);
            this.txbSslport.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SSL Port";
            // 
            // plConnectingString
            // 
            this.plConnectingString.Controls.Add(this.txbConnectingString);
            this.plConnectingString.Controls.Add(this.label3);
            this.plConnectingString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plConnectingString.Location = new System.Drawing.Point(0, 0);
            this.plConnectingString.Name = "plConnectingString";
            this.plConnectingString.Size = new System.Drawing.Size(400, 178);
            this.plConnectingString.TabIndex = 4;
            this.plConnectingString.Visible = false;
            // 
            // txbConnectingString
            // 
            this.txbConnectingString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbConnectingString.Location = new System.Drawing.Point(0, 23);
            this.txbConnectingString.Multiline = true;
            this.txbConnectingString.Name = "txbConnectingString";
            this.txbConnectingString.Size = new System.Drawing.Size(400, 155);
            this.txbConnectingString.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connecting String";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRedisConnect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 178);
            this.ControlBox = false;
            this.Controls.Add(this.plDetailInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plConnectingString);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRedisConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect Redis";
            this.Load += new System.EventHandler(this.FrmRedisConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plDetailInfo.ResumeLayout(false);
            this.plDetailInfo.PerformLayout();
            this.plConnectingString.ResumeLayout(false);
            this.plConnectingString.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbHostName;
        private TextBox txbPassword;
        private Panel panel1;
        private Panel panel3;
        private RadioButton rbtnDetailInfo;
        private RadioButton rbtnConnectingString;
        private Panel plDetailInfo;
        private Panel plConnectingString;
        private TextBox txbSslport;
        private Label label4;
        private Button btnCancel;
        private Button btnConnect;
        private TextBox txbConnectingString;
        private Label label3;
        private CheckBox cbAbortConnect;
        private CheckBox cbSSL;
    }
}