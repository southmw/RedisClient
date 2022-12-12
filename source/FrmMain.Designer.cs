namespace RedisClient
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbDebug = new System.Windows.Forms.TextBox();
            this.btnPingTest = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnSubscribeChannal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSendMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSendChannal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbWaitChannal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUbsubscribeChannal = new System.Windows.Forms.Button();
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetData = new System.Windows.Forms.Button();
            this.txbSetValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSetKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txbGetKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.gbPubSub = new System.Windows.Forms.GroupBox();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnCustomCommand = new System.Windows.Forms.Button();
            this.txbCustomCommand = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbPubSub.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txbDebug
            // 
            this.txbDebug.BackColor = System.Drawing.Color.White;
            this.txbDebug.Location = new System.Drawing.Point(12, 249);
            this.txbDebug.Multiline = true;
            this.txbDebug.Name = "txbDebug";
            this.txbDebug.ReadOnly = true;
            this.txbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbDebug.Size = new System.Drawing.Size(857, 341);
            this.txbDebug.TabIndex = 0;
            this.txbDebug.TabStop = false;
            // 
            // btnPingTest
            // 
            this.btnPingTest.Location = new System.Drawing.Point(6, 24);
            this.btnPingTest.Name = "btnPingTest";
            this.btnPingTest.Size = new System.Drawing.Size(80, 28);
            this.btnPingTest.TabIndex = 3;
            this.btnPingTest.Text = "Ping Test";
            this.btnPingTest.UseVisualStyleBackColor = true;
            this.btnPingTest.Click += new System.EventHandler(this.btnPingTest_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(3, 65);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(198, 28);
            this.btnSendMsg.TabIndex = 4;
            this.btnSendMsg.Text = "Send Msg";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnSubscribeChannal
            // 
            this.btnSubscribeChannal.Location = new System.Drawing.Point(7, 34);
            this.btnSubscribeChannal.Name = "btnSubscribeChannal";
            this.btnSubscribeChannal.Size = new System.Drawing.Size(194, 28);
            this.btnSubscribeChannal.TabIndex = 4;
            this.btnSubscribeChannal.Text = "Subscribe Channal";
            this.btnSubscribeChannal.UseVisualStyleBackColor = true;
            this.btnSubscribeChannal.Click += new System.EventHandler(this.btnSubscribeChannal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSendMessage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSendMsg);
            this.panel1.Controls.Add(this.txbSendChannal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(216, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 98);
            this.panel1.TabIndex = 5;
            // 
            // txbSendMessage
            // 
            this.txbSendMessage.Location = new System.Drawing.Point(71, 34);
            this.txbSendMessage.Name = "txbSendMessage";
            this.txbSendMessage.Size = new System.Drawing.Size(130, 25);
            this.txbSendMessage.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Message";
            // 
            // txbSendChannal
            // 
            this.txbSendChannal.Location = new System.Drawing.Point(71, 3);
            this.txbSendChannal.Name = "txbSendChannal";
            this.txbSendChannal.Size = new System.Drawing.Size(130, 25);
            this.txbSendChannal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Channal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbWaitChannal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUbsubscribeChannal);
            this.panel2.Controls.Add(this.btnSubscribeChannal);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 98);
            this.panel2.TabIndex = 5;
            // 
            // txbWaitChannal
            // 
            this.txbWaitChannal.Location = new System.Drawing.Point(71, 3);
            this.txbWaitChannal.Name = "txbWaitChannal";
            this.txbWaitChannal.Size = new System.Drawing.Size(130, 25);
            this.txbWaitChannal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Channal";
            // 
            // btnUbsubscribeChannal
            // 
            this.btnUbsubscribeChannal.Location = new System.Drawing.Point(7, 65);
            this.btnUbsubscribeChannal.Name = "btnUbsubscribeChannal";
            this.btnUbsubscribeChannal.Size = new System.Drawing.Size(194, 28);
            this.btnUbsubscribeChannal.TabIndex = 4;
            this.btnUbsubscribeChannal.Text = "UnSubscribe Channal";
            this.btnUbsubscribeChannal.UseVisualStyleBackColor = true;
            this.btnUbsubscribeChannal.Click += new System.EventHandler(this.btnUbsubscribeChannal_Click);
            // 
            // btnGetInfos
            // 
            this.btnGetInfos.Location = new System.Drawing.Point(92, 24);
            this.btnGetInfos.Name = "btnGetInfos";
            this.btnGetInfos.Size = new System.Drawing.Size(80, 28);
            this.btnGetInfos.TabIndex = 6;
            this.btnGetInfos.Text = "Get Info";
            this.btnGetInfos.UseVisualStyleBackColor = true;
            this.btnGetInfos.Click += new System.EventHandler(this.btnGetInfos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetData);
            this.panel3.Controls.Add(this.txbSetValue);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbSetKey);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(6, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 7;
            // 
            // btnSetData
            // 
            this.btnSetData.Location = new System.Drawing.Point(3, 65);
            this.btnSetData.Name = "btnSetData";
            this.btnSetData.Size = new System.Drawing.Size(194, 28);
            this.btnSetData.TabIndex = 2;
            this.btnSetData.Text = "Set Data";
            this.btnSetData.UseVisualStyleBackColor = true;
            this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
            // 
            // txbSetValue
            // 
            this.txbSetValue.Location = new System.Drawing.Point(52, 34);
            this.txbSetValue.Name = "txbSetValue";
            this.txbSetValue.Size = new System.Drawing.Size(145, 25);
            this.txbSetValue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value";
            // 
            // txbSetKey
            // 
            this.txbSetKey.Location = new System.Drawing.Point(52, 3);
            this.txbSetKey.Name = "txbSetKey";
            this.txbSetKey.Size = new System.Drawing.Size(145, 25);
            this.txbSetKey.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Key";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGetData);
            this.panel4.Controls.Add(this.txbGetKey);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(212, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 68);
            this.panel4.TabIndex = 7;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(3, 34);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(194, 28);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txbGetKey
            // 
            this.txbGetKey.Location = new System.Drawing.Point(52, 3);
            this.txbGetKey.Name = "txbGetKey";
            this.txbGetKey.Size = new System.Drawing.Size(145, 25);
            this.txbGetKey.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Key";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.txbCustomCommand);
            this.gbCommand.Controls.Add(this.btnCustomCommand);
            this.gbCommand.Controls.Add(this.btnPingTest);
            this.gbCommand.Controls.Add(this.btnGetInfos);
            this.gbCommand.Location = new System.Drawing.Point(12, 46);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(853, 62);
            this.gbCommand.TabIndex = 8;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
            // 
            // gbPubSub
            // 
            this.gbPubSub.Controls.Add(this.panel2);
            this.gbPubSub.Controls.Add(this.panel1);
            this.gbPubSub.Location = new System.Drawing.Point(12, 111);
            this.gbPubSub.Name = "gbPubSub";
            this.gbPubSub.Size = new System.Drawing.Size(427, 132);
            this.gbPubSub.TabIndex = 9;
            this.gbPubSub.TabStop = false;
            this.gbPubSub.Text = "Pub/Sub";
            // 
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.panel3);
            this.gbDatabase.Controls.Add(this.panel4);
            this.gbDatabase.Location = new System.Drawing.Point(445, 111);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Size = new System.Drawing.Size(420, 132);
            this.gbDatabase.TabIndex = 9;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = "Database";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(104, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(86, 28);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnCustomCommand
            // 
            this.btnCustomCommand.Location = new System.Drawing.Point(178, 24);
            this.btnCustomCommand.Name = "btnCustomCommand";
            this.btnCustomCommand.Size = new System.Drawing.Size(143, 28);
            this.btnCustomCommand.TabIndex = 7;
            this.btnCustomCommand.Text = "Custom Command";
            this.btnCustomCommand.UseVisualStyleBackColor = true;
            this.btnCustomCommand.Click += new System.EventHandler(this.btnCustomCommand_Click);
            // 
            // txbCustomCommand
            // 
            this.txbCustomCommand.Location = new System.Drawing.Point(327, 26);
            this.txbCustomCommand.Name = "txbCustomCommand";
            this.txbCustomCommand.Size = new System.Drawing.Size(364, 25);
            this.txbCustomCommand.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 602);
            this.Controls.Add(this.gbDatabase);
            this.Controls.Add(this.gbPubSub);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.txbDebug);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Redis Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.gbPubSub.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConnect;
        private TextBox txbDebug;
        private Button btnPingTest;
        private Button btnSendMsg;
        private Button btnSubscribeChannal;
        private Panel panel1;
        private TextBox txbSendMessage;
        private Label label3;
        private TextBox txbSendChannal;
        private Label label2;
        private Panel panel2;
        private TextBox txbWaitChannal;
        private Label label5;
        private Button btnUbsubscribeChannal;
        private Button btnGetInfos;
        private Panel panel3;
        private TextBox txbSetKey;
        private Label label4;
        private Button btnSetData;
        private TextBox txbSetValue;
        private Label label6;
        private Panel panel4;
        private Button btnGetData;
        private TextBox txbGetKey;
        private Label label8;
        private GroupBox gbCommand;
        private GroupBox gbPubSub;
        private GroupBox gbDatabase;
        private Button btnDisconnect;
        private TextBox txbCustomCommand;
        private Button btnCustomCommand;
    }
}