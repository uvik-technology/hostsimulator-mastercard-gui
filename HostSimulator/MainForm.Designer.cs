using System;

namespace HostSimulatorMasterCard
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
            this.ClearTableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnTxnCancel = new System.Windows.Forms.Button();
            this.btnTxnStart = new System.Windows.Forms.Button();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFinancialReq = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.textCurrencyCode = new System.Windows.Forms.TextBox();
            this.textCurrencyExpo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textCategoryCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textAccTye = new System.Windows.Forms.TextBox();
            this.textMerchCustData = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textOtherAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTransType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textISS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboIAD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboARC = new System.Windows.Forms.ComboBox();
            this.comboConf = new System.Windows.Forms.ComboBox();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.btnGetDate = new System.Windows.Forms.Button();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uiRequestTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.discretionaryDatatextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFinancialConf);
            this.groupBox1.Location = new System.Drawing.Point(464, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outcome Parameter Set";
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
            this.textFinancialConf.Size = new System.Drawing.Size(532, 294);
            this.textFinancialConf.TabIndex = 0;
            this.textFinancialConf.TextChanged += new System.EventHandler(this.textFinancialConf_TextChanged);
            // 
            // ClearTableCheckBox
            // 
            this.ClearTableCheckBox.AutoSize = true;
            this.ClearTableCheckBox.Location = new System.Drawing.Point(11, 624);
            this.ClearTableCheckBox.Name = "ClearTableCheckBox";
            this.ClearTableCheckBox.Size = new System.Drawing.Size(133, 20);
            this.ClearTableCheckBox.TabIndex = 2;
            this.ClearTableCheckBox.Text = "Clear Log Tables";
            this.ClearTableCheckBox.UseVisualStyleBackColor = true;
            this.ClearTableCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnTxnCancel
            // 
            this.btnTxnCancel.Enabled = false;
            this.btnTxnCancel.Location = new System.Drawing.Point(312, 624);
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
            this.btnTxnStart.Location = new System.Drawing.Point(185, 624);
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
            this.textAmount.Location = new System.Drawing.Point(129, 214);
            this.textAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(297, 22);
            this.textAmount.TabIndex = 3;
            this.textAmount.Text = "000000000100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFinancialReq);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Financial Transaction Request";
            // 
            // textFinancialReq
            // 
            this.textFinancialReq.Location = new System.Drawing.Point(8, 23);
            this.textFinancialReq.Margin = new System.Windows.Forms.Padding(4);
            this.textFinancialReq.Multiline = true;
            this.textFinancialReq.Name = "textFinancialReq";
            this.textFinancialReq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFinancialReq.Size = new System.Drawing.Size(424, 294);
            this.textFinancialReq.TabIndex = 1;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(15, 717);
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
            this.textBoxDec.Location = new System.Drawing.Point(15, 669);
            this.textBoxDec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDec.Multiline = true;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.Size = new System.Drawing.Size(409, 40);
            this.textBoxDec.TabIndex = 51;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopButton);
            this.groupBox3.Controls.Add(this.textCurrencyCode);
            this.groupBox3.Controls.Add(this.textCurrencyExpo);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textCategoryCode);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textAccTye);
            this.groupBox3.Controls.Add(this.textMerchCustData);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.buttonDecrypt);
            this.groupBox3.Controls.Add(this.textBoxDec);
            this.groupBox3.Controls.Add(this.ClearTableCheckBox);
            this.groupBox3.Controls.Add(this.textOtherAmount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textTransType);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
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
            this.groupBox3.Controls.Add(this.btnSetDate);
            this.groupBox3.Controls.Add(this.btnSetTime);
            this.groupBox3.Controls.Add(this.btnGetDate);
            this.groupBox3.Controls.Add(this.btnGetTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textTime);
            this.groupBox3.Controls.Add(this.textDate);
            this.groupBox3.Location = new System.Drawing.Point(1020, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(436, 753);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(296, 717);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(128, 28);
            this.stopButton.TabIndex = 87;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textCurrencyCode
            // 
            this.textCurrencyCode.Location = new System.Drawing.Point(129, 310);
            this.textCurrencyCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCurrencyCode.Name = "textCurrencyCode";
            this.textCurrencyCode.Size = new System.Drawing.Size(71, 22);
            this.textCurrencyCode.TabIndex = 86;
            this.textCurrencyCode.Text = "0978";
            this.textCurrencyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCurrencyExpo
            // 
            this.textCurrencyExpo.Location = new System.Drawing.Point(348, 313);
            this.textCurrencyExpo.Margin = new System.Windows.Forms.Padding(4);
            this.textCurrencyExpo.Name = "textCurrencyExpo";
            this.textCurrencyExpo.Size = new System.Drawing.Size(47, 22);
            this.textCurrencyExpo.TabIndex = 85;
            this.textCurrencyExpo.Text = "02";
            this.textCurrencyExpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCurrencyExpo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 316);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 16);
            this.label20.TabIndex = 84;
            this.label20.Text = "Currency Code";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(208, 313);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 16);
            this.label19.TabIndex = 83;
            this.label19.Text = "Currency Exponent";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // textCategoryCode
            // 
            this.textCategoryCode.Location = new System.Drawing.Point(348, 279);
            this.textCategoryCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCategoryCode.Name = "textCategoryCode";
            this.textCategoryCode.Size = new System.Drawing.Size(47, 22);
            this.textCategoryCode.TabIndex = 82;
            this.textCategoryCode.Text = "00";
            this.textCategoryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(206, 282);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 16);
            this.label18.TabIndex = 81;
            this.label18.Text = "Txn category Code";
            // 
            // textAccTye
            // 
            this.textAccTye.Location = new System.Drawing.Point(129, 279);
            this.textAccTye.Margin = new System.Windows.Forms.Padding(4);
            this.textAccTye.Name = "textAccTye";
            this.textAccTye.Size = new System.Drawing.Size(69, 22);
            this.textAccTye.TabIndex = 80;
            this.textAccTye.Text = "00";
            this.textAccTye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMerchCustData
            // 
            this.textMerchCustData.Location = new System.Drawing.Point(13, 378);
            this.textMerchCustData.Margin = new System.Windows.Forms.Padding(4);
            this.textMerchCustData.Name = "textMerchCustData";
            this.textMerchCustData.Size = new System.Drawing.Size(411, 22);
            this.textMerchCustData.TabIndex = 79;
            this.textMerchCustData.Text = "absent";
            this.textMerchCustData.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 279);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 78;
            this.label17.Text = "Account Type";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 358);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "Merchant Custom Data";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textOtherAmount
            // 
            this.textOtherAmount.Location = new System.Drawing.Point(129, 244);
            this.textOtherAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textOtherAmount.Name = "textOtherAmount";
            this.textOtherAmount.Size = new System.Drawing.Size(297, 22);
            this.textOtherAmount.TabIndex = 75;
            this.textOtherAmount.Text = "000000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Amount Other";
            // 
            // textTransType
            // 
            this.textTransType.FormattingEnabled = true;
            this.textTransType.Items.AddRange(new object[] {
            "Payment - 00",
            "Cash - 01",
            "Cashback - 09",
            "Refund - 20",
            "Type 17 - 17",
            "Type 88 - 88",
            "Type 93 - 93",
            "None",
            "Absent"});
            this.textTransType.Location = new System.Drawing.Point(131, 132);
            this.textTransType.Margin = new System.Windows.Forms.Padding(4);
            this.textTransType.Name = "textTransType";
            this.textTransType.Size = new System.Drawing.Size(167, 24);
            this.textTransType.TabIndex = 73;
            this.textTransType.Text = "Payment - 00";
            this.textTransType.SelectedIndexChanged += new System.EventHandler(this.textTransType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 72;
            this.label14.Text = "Transaction Type";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Issuer Script";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textISS
            // 
            this.textISS.Location = new System.Drawing.Point(17, 539);
            this.textISS.Margin = new System.Windows.Forms.Padding(4);
            this.textISS.Multiline = true;
            this.textISS.Name = "textISS";
            this.textISS.Size = new System.Drawing.Size(411, 57);
            this.textISS.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 478);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "IAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "ARC";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            this.comboIAD.Location = new System.Drawing.Point(61, 470);
            this.comboIAD.Margin = new System.Windows.Forms.Padding(4);
            this.comboIAD.Name = "comboIAD";
            this.comboIAD.Size = new System.Drawing.Size(367, 24);
            this.comboIAD.TabIndex = 57;
            this.comboIAD.SelectedIndexChanged += new System.EventHandler(this.comboIAD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
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
            this.comboARC.Location = new System.Drawing.Point(61, 433);
            this.comboARC.Margin = new System.Windows.Forms.Padding(4);
            this.comboARC.Name = "comboARC";
            this.comboARC.Size = new System.Drawing.Size(367, 24);
            this.comboARC.TabIndex = 55;
            // 
            // comboConf
            // 
            this.comboConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConf.FormattingEnabled = true;
            this.comboConf.Items.AddRange(new object[] {
            "PPS_MChip1",
            "PPS_MChip1_READ_ALL",
            "PPS_MChip2",
            "PPS_MChip3",
            "PPS_MChip4",
            "PPS_MChip5",
            "PPS_MChip6",
            "PPS_MChip7",
            "PPS_MChip8",
            "PPS_MChip9",
            "PPS_MChip10",
            "PPS_MChip11",
            "PPS_CVM_1",
            "PPS_CVM_2",
            "PPS_LIMIT_1",
            "PPS_LIMIT_1b",
            "PPS_LIMIT_2",
            "PPS_LIMIT_3",
            "PPS_RRP",
            "PPS_MC_ATM",
            "PPS_MC_notATM",
            "PPS_MC_prop",
            "PPS_MCerrKernelConf MAG",
            "PPS_MCnoDefault_1",
            "PPS_MCnoDefault_2",
            "PPS_MCnoDefault_3",
            "PPS_MCnoDefault_4",
            "PPS_MCnoDefault_5",
            "PPS_MCnoMSI",
            "PPS_MConlineonly",
            "PPS_perf_MC",
            "PPS_RRP2",
            "PPS_RRP3",
            "PPS_RRP4",
            "PPS_RRP5",
            "PPS_RRP6",
            "PPS_RRP7",
            "PPS_Select1"});
            this.comboConf.Location = new System.Drawing.Point(131, 164);
            this.comboConf.Margin = new System.Windows.Forms.Padding(4);
            this.comboConf.Name = "comboConf";
            this.comboConf.Size = new System.Drawing.Size(297, 24);
            this.comboConf.TabIndex = 50;
            this.comboConf.SelectedIndexChanged += new System.EventHandler(this.comboConf_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1365, 792);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Version: 16.8";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.uiRequestTextBox);
            this.groupBox4.Location = new System.Drawing.Point(464, 356);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(548, 412);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UI Request Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 1;
            // 
            // uiRequestTextBox
            // 
            this.uiRequestTextBox.Location = new System.Drawing.Point(8, 23);
            this.uiRequestTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uiRequestTextBox.Multiline = true;
            this.uiRequestTextBox.Name = "uiRequestTextBox";
            this.uiRequestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uiRequestTextBox.Size = new System.Drawing.Size(532, 381);
            this.uiRequestTextBox.TabIndex = 0;
            this.uiRequestTextBox.TextChanged += new System.EventHandler(this.uiRequestTextBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.discretionaryDatatextBox1);
            this.groupBox5.Location = new System.Drawing.Point(6, 356);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(450, 412);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Discretionary Data";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 1;
            // 
            // discretionaryDatatextBox1
            // 
            this.discretionaryDatatextBox1.Location = new System.Drawing.Point(8, 23);
            this.discretionaryDatatextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.discretionaryDatatextBox1.Multiline = true;
            this.discretionaryDatatextBox1.Name = "discretionaryDatatextBox1";
            this.discretionaryDatatextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.discretionaryDatatextBox1.Size = new System.Drawing.Size(434, 381);
            this.discretionaryDatatextBox1.TabIndex = 0;
            this.discretionaryDatatextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 831);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox textTransType;
        private System.Windows.Forms.TextBox textOtherAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ClearTableCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox uiRequestTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox discretionaryDatatextBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textAccTye;
        private System.Windows.Forms.TextBox textMerchCustData;
        private System.Windows.Forms.TextBox textCategoryCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textCurrencyCode;
        private System.Windows.Forms.TextBox textCurrencyExpo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button stopButton;
    }
}
