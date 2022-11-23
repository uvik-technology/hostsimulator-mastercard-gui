using System;

namespace HostSimulatorRupay
{
    partial class MainForm
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFinancialConf = new System.Windows.Forms.TextBox();
            this.btnTxnCancel = new System.Windows.Forms.Button();
            this.btnTxnStart = new System.Windows.Forms.Button();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.textFinancialReq = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.terminalType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.offlineOnlineOptions = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSMI = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTransType = new System.Windows.Forms.TextBox();
            this.checkFailNetwork = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textISS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboIAD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboARC = new System.Windows.Forms.ComboBox();
            this.comboConf = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.btnGetDate = new System.Windows.Forms.Button();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFinancialConf);
            this.groupBox1.Location = new System.Drawing.Point(397, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Financial Transaction Confirmation / Reversal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // textFinancialConf
            // 
            this.textFinancialConf.Location = new System.Drawing.Point(8, 23);
            this.textFinancialConf.Margin = new System.Windows.Forms.Padding(4);
            this.textFinancialConf.Multiline = true;
            this.textFinancialConf.Name = "textFinancialConf";
            this.textFinancialConf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFinancialConf.Size = new System.Drawing.Size(356, 522);
            this.textFinancialConf.TabIndex = 0;
            // 
            // btnTxnCancel
            // 
            this.btnTxnCancel.Enabled = false;
            this.btnTxnCancel.Location = new System.Drawing.Point(316, 401);
            this.btnTxnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnTxnCancel.Name = "btnTxnCancel";
            this.btnTxnCancel.Size = new System.Drawing.Size(112, 28);
            this.btnTxnCancel.TabIndex = 5;
            this.btnTxnCancel.Text = "CANCEL";
            this.btnTxnCancel.UseVisualStyleBackColor = true;
            this.btnTxnCancel.Click += new System.EventHandler(this.btnTxnCancel_Click);
            // 
            // btnTxnStart
            // 
            this.btnTxnStart.Location = new System.Drawing.Point(316, 366);
            this.btnTxnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnTxnStart.Name = "btnTxnStart";
            this.btnTxnStart.Size = new System.Drawing.Size(112, 28);
            this.btnTxnStart.TabIndex = 4;
            this.btnTxnStart.Text = "START";
            this.btnTxnStart.UseVisualStyleBackColor = true;
            this.btnTxnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(75, 334);
            this.textAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(352, 22);
            this.textAmount.TabIndex = 3;
            this.textAmount.Text = "000000000100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDecrypt);
            this.groupBox2.Controls.Add(this.textBoxDec);
            this.groupBox2.Controls.Add(this.textFinancialReq);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(373, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Financial Transaction Request";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(237, 518);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(128, 28);
            this.buttonDecrypt.TabIndex = 51;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxDec
            // 
            this.textBoxDec.Location = new System.Drawing.Point(8, 470);
            this.textBoxDec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDec.Multiline = true;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.Size = new System.Drawing.Size(356, 40);
            this.textBoxDec.TabIndex = 51;
            // 
            // textFinancialReq
            // 
            this.textFinancialReq.Location = new System.Drawing.Point(8, 23);
            this.textFinancialReq.Margin = new System.Windows.Forms.Padding(4);
            this.textFinancialReq.Multiline = true;
            this.textFinancialReq.Name = "textFinancialReq";
            this.textFinancialReq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFinancialReq.Size = new System.Drawing.Size(356, 438);
            this.textFinancialReq.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.terminalType);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.offlineOnlineOptions);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboSMI);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textTransType);
            this.groupBox3.Controls.Add(this.checkFailNetwork);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textISS);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboIAD);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboARC);
            this.groupBox3.Controls.Add(this.comboConf);
            this.groupBox3.Controls.Add(this.btnTxnCancel);
            this.groupBox3.Controls.Add(this.btnTxnStart);
            this.groupBox3.Controls.Add(this.textAmount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSetDate);
            this.groupBox3.Controls.Add(this.btnSetTime);
            this.groupBox3.Controls.Add(this.btnGetDate);
            this.groupBox3.Controls.Add(this.btnGetTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textTime);
            this.groupBox3.Controls.Add(this.textDate);
            this.groupBox3.Location = new System.Drawing.Point(779, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(436, 554);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal";
            // 
            // terminalType
            // 
            this.terminalType.Location = new System.Drawing.Point(137, 404);
            this.terminalType.Margin = new System.Windows.Forms.Padding(4);
            this.terminalType.MaxLength = 2;
            this.terminalType.Name = "terminalType";
            this.terminalType.Size = new System.Drawing.Size(48, 22);
            this.terminalType.TabIndex = 71;
            this.terminalType.Text = "91";
            this.terminalType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Terminal Type";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 489);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 69;
            this.label13.Text = "Offline/Online";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // offlineOnlineOptions
            // 
            this.offlineOnlineOptions.FormattingEnabled = true;
            this.offlineOnlineOptions.Items.AddRange(new object[] {
            "Offline Only",
            "Online Only",
            "Offline & Online"});
            this.offlineOnlineOptions.Location = new System.Drawing.Point(109, 486);
            this.offlineOnlineOptions.Name = "offlineOnlineOptions";
            this.offlineOnlineOptions.Size = new System.Drawing.Size(121, 24);
            this.offlineOnlineOptions.TabIndex = 67;
            this.offlineOnlineOptions.Text = "Online Only";
            this.offlineOnlineOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Service Management Info";
            // 
            // comboSMI
            // 
            this.comboSMI.FormattingEnabled = true;
            this.comboSMI.Items.AddRange(new object[] {
            "00 00",
            "11 00"});
            this.comboSMI.Location = new System.Drawing.Point(188, 437);
            this.comboSMI.Margin = new System.Windows.Forms.Padding(4);
            this.comboSMI.Name = "comboSMI";
            this.comboSMI.Size = new System.Drawing.Size(239, 24);
            this.comboSMI.TabIndex = 65;
            this.comboSMI.Text = "00 00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Transaction Type";
            // 
            // textTransType
            // 
            this.textTransType.Location = new System.Drawing.Point(137, 368);
            this.textTransType.Margin = new System.Windows.Forms.Padding(4);
            this.textTransType.MaxLength = 2;
            this.textTransType.Name = "textTransType";
            this.textTransType.Size = new System.Drawing.Size(48, 22);
            this.textTransType.TabIndex = 63;
            this.textTransType.Text = "00";
            this.textTransType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkFailNetwork
            // 
            this.checkFailNetwork.AutoSize = true;
            this.checkFailNetwork.Location = new System.Drawing.Point(244, 220);
            this.checkFailNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.checkFailNetwork.Name = "checkFailNetwork";
            this.checkFailNetwork.Size = new System.Drawing.Size(169, 20);
            this.checkFailNetwork.TabIndex = 62;
            this.checkFailNetwork.Text = "Simulate network failure";
            this.checkFailNetwork.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Issuer Script";
            // 
            // textISS
            // 
            this.textISS.Location = new System.Drawing.Point(13, 268);
            this.textISS.Margin = new System.Windows.Forms.Padding(4);
            this.textISS.Multiline = true;
            this.textISS.Name = "textISS";
            this.textISS.Size = new System.Drawing.Size(413, 57);
            this.textISS.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "IAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "ARC";
            // 
            // comboIAD
            // 
            this.comboIAD.FormattingEnabled = true;
            this.comboIAD.Items.AddRange(new object[] {
            "01 02 03 04 05 06 07 08 00 00 00 00 00 00 00 00",
            "01 02 03 04 80 83 40 00 00 00 00 00 00 01 00 00",
            "01 02 03 04 80 83 40 00 00 10 00 00 00 15 00 00",
            "01 02 03 04 80 83 40 00 FF FE 00 00 00 01 00 00",
            "NONE"});
            this.comboIAD.Location = new System.Drawing.Point(55, 187);
            this.comboIAD.Margin = new System.Windows.Forms.Padding(4);
            this.comboIAD.Name = "comboIAD";
            this.comboIAD.Size = new System.Drawing.Size(372, 24);
            this.comboIAD.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Configuration";
            // 
            // comboARC
            // 
            this.comboARC.FormattingEnabled = true;
            this.comboARC.Items.AddRange(new object[] {
            "30 30",
            "35 31",
            "50",
            "NONE"});
            this.comboARC.Location = new System.Drawing.Point(55, 154);
            this.comboARC.Margin = new System.Windows.Forms.Padding(4);
            this.comboARC.Name = "comboARC";
            this.comboARC.Size = new System.Drawing.Size(372, 24);
            this.comboARC.TabIndex = 55;
            // 
            // comboConf
            // 
            this.comboConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConf.FormattingEnabled = true;
            this.comboConf.Items.AddRange(new object[] {
            "PPS_MChip1"
            });
            
            this.comboConf.Location = new System.Drawing.Point(109, 121);
            this.comboConf.Margin = new System.Windows.Forms.Padding(4);
            this.comboConf.Name = "comboConf";
            this.comboConf.Size = new System.Drawing.Size(317, 24);
            this.comboConf.TabIndex = 50;
            this.comboConf.SelectedIndexChanged += new System.EventHandler(this.comboConf_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Version: 16.8";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(305, 53);
            this.btnSetDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(60, 28);
            this.btnSetDate.TabIndex = 15;
            this.btnSetDate.Text = "SET";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(305, 85);
            this.btnSetTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(60, 28);
            this.btnSetTime.TabIndex = 14;
            this.btnSetTime.Text = "SET";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // btnGetDate
            // 
            this.btnGetDate.Location = new System.Drawing.Point(237, 53);
            this.btnGetDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDate.Name = "btnGetDate";
            this.btnGetDate.Size = new System.Drawing.Size(60, 28);
            this.btnGetDate.TabIndex = 13;
            this.btnGetDate.Text = "GET";
            this.btnGetDate.UseVisualStyleBackColor = true;
            this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(237, 85);
            this.btnGetTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(60, 28);
            this.btnGetTime.TabIndex = 12;
            this.btnGetTime.Text = "GET";
            this.btnGetTime.UseVisualStyleBackColor = true;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(57, 87);
            this.textTime.Margin = new System.Windows.Forms.Padding(4);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(171, 22);
            this.textTime.TabIndex = 6;
            this.textTime.Text = "020202";
            this.textTime.TextChanged += new System.EventHandler(this.textTime_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(57, 55);
            this.textDate.Margin = new System.Windows.Forms.Padding(4);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(171, 22);
            this.textDate.TabIndex = 5;
            this.textDate.Text = "180725";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Host Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textTime_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTxnCancel;
        private System.Windows.Forms.Button btnTxnStart;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFinancialConf;
        private System.Windows.Forms.TextBox textFinancialReq;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Button btnGetDate;
        private System.Windows.Forms.Button btnGetTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboConf;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.ComboBox comboARC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboIAD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textISS;
        private System.Windows.Forms.CheckBox checkFailNetwork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTransType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSMI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox offlineOnlineOptions;
        private System.Windows.Forms.TextBox terminalType;
        private System.Windows.Forms.Label label12;
    }
}
