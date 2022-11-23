using BerTlv;
using Microsoft.AspNetCore.SignalR.Client;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HostSimulatorRupay
{
    public partial class MainForm : Form
    {
        HubConnection connection;

        public MainForm()
        {
            InitializeComponent();
            comboConf.SelectedIndex = 0;
            comboARC.SelectedIndex = 0;
            comboIAD.SelectedIndex = 0;
            connection = new HubConnectionBuilder().WithUrl("http://localhost:8090/signalr").WithAutomaticReconnect(new SRetryPolcy()).Build();

            connection.On("dataElements", (string elements) =>
            {
            });

            connection.On("onlineRequest", (string outcome, string clearingRecords1) =>
            {
                byte[] clearingRecords = System.Convert.FromBase64String(clearingRecords1);
                if (clearingRecords != null && clearingRecords.Length != 0)
                {
                    ICollection<Tlv> tlvClearingRecords = Tlv.ParseTlv(clearingRecords);
                    textFinancialReq.Text = "Outcome: " + outcome + "\r\n" + string.Join("\r\n", tlvClearingRecords.Select(x => x.HexTag + " " + x.Length.ToString("X2") + " " + x.HexValue));
                }
                else
                {
                    textFinancialReq.Text = "Outcome: " + outcome;
                }
                string resStr = getARC() + getIAD() + getISS();
                byte[] response = stringToByteArray(resStr);
                if (checkFailNetwork.Checked)
                {
                    response = new byte[0];
                }
                connection.InvokeAsync("onlineResponse", response);
            });

            connection.On("transactionConfirmation", (string outcome, string clearingRecords1) =>
            {
                byte[] clearingRecords = System.Convert.FromBase64String(clearingRecords1);
                string msg = "Message: Unknown";
                if (clearingRecords != null && clearingRecords.Length != 0)
                {
                    if (clearingRecords[0] == 0)
                    {
                        msg = "Message: Financial Transaction Confirmation\r\n";
                    }
                    else if (clearingRecords[0] == 1)
                    {
                        msg = "Message: Reversal\r\n";
                    }
                    byte[] result = new byte[clearingRecords.Length - 1];
                    Array.Copy(clearingRecords, 1, result, 0, clearingRecords.Length - 1);
                    ICollection<Tlv> tlvClearingRecords = Tlv.ParseTlv(result);
                    textFinancialConf.Text = msg + "Outcome: " + outcome + "\r\n" + string.Join("\r\n", tlvClearingRecords.Select(x => x.HexTag + " " + x.Length.ToString("X2") + " " + x.HexValue));
                }
                else
                {
                    textFinancialConf.Text = msg + "Outcome: " + outcome;
                }

                btnTxnStart.Enabled = true;
                btnTxnCancel.Enabled = false;
            });

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
                await connection.InvokeAsync("addToHostGroup");
            };
        }


        byte[] PPS_MChip1 = new byte[]
        {
        {
            0x01,
            0x07, 0xA0, 0x00, 0x00, 0x00, 0x04, 0x10, 0x10, 0x00, 0x02, 0x02, 0x00,

            0xdf, 0x82, 0x01, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00,   //TAC - Default
            0xdf, 0x82, 0x02, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00,   //TAC - Denial
            0xdf, 0x82, 0x03, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00,   //TAC - Online

            0x9f, 0x1a, 0x02, 0x03, 0x56,   //Terminal country code
            0x5f, 0x2a, 0x02, 0x03, 0x56,   //Transaction currency code
            0x5f, 0x36, 0x01, 0x02,         //Transaction currency exponent: 0-No decimal, 1-10:1, 2-100:1, 3-1000:1
            0x9f, 0x1b, 0x04, 0x00, 0x00, 0x27, 0x10,                   //Terminal floor limit
            0xdf, 0x4d, 0x06, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00,       //terminal cvm limit


            0x9f, 0x37, 0x04, 0x11, 0x55, 0x49, 0x18,                   //Unpredicatable Number MC
            0x9f, 0x7F, 0x04, 0x11, 0x55, 0x50, 0x18,                   //Unpredicatable Number
            0x9F, 0x4E, 0x08, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x31, // Merchant Name and Location
            0x9f, 0x35, 0x01, 0x22,                                     // Terminal type

            //config
            0x9F, 0x16, 0x0F, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,0x30, 0x31, // Merchant Identifier
            0x9f, 0x15, 0x02, 0x00, 0x01,   //MERCH
            0x9f, 0x1c, 0x08, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, //TERM ID
            0xDF, 0x82, 0x07, 0x01, 0x00                                 // OFFLINE_CAPABILITIES

            // Mandatory Tags

            0xdf, 0x82, 0x03, 0x05, 0xA4, 0x68, 0xFC, 0x98, 0x00,
            0x9f, 0x1b, 0x04, 0x00, 0x00, 0x00, 0xC8,
            0x9f, 0x66, 0x04, 0x24, 0x00, 0x40, 0x00,
            0x9f, 0x03, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            // 0x9c, 0x01, 0x00,
            0x9f, 0x40, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xdf, 0x3a, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x9f, 0x15, 0x02, 0x15, 0x20,
            0x9f, 0x33, 0x03, 0x00, 0x48, 0x48,
            0xDF, 0x82, 0x05, 0x16, 0x10, 0x10, 0x01, 0x3E, 0x77, 0xD2, 0x91, 0x2D, 0x5D, 0x1B, 0xBF, 0x7F, 0x22, 0x24, 0x96, 0x61, 0x8D, 0x8E, 0x0B, 0x24, 0x4A, 0xF7,
            0xDF, 0x81, 0x23, 0x06, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
            0xDF, 0x81, 0x24, 0x06, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, //Reader Contactless Transaction Limit (No On- device CVM)
            0xdf, 0x81, 0x25, 0x06, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, //Reader Contactless Transaction Limit (On-device CVM)
            0xdf, 0x81, 0x26, 0x06, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, //Reader CVM Required Limit
            0xDF, 0x81, 0x17, 0x01, 0x00,
            0xDF, 0x81, 0x18, 0x01, 0x40,
            0xDF, 0x81, 0x19, 0x01, 0x08,
            0xDF, 0x81, 0x1F, 0x01, 0x08,
            0xDF, 0x81, 0x1B, 0x01, 0xB0,
            0x9f, 0x1D, 0x08, 0x4C, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00,

            0xDF, 0x81, 0x17, 0x01, 0x00,  //Card Data Input Capability
            0xDF, 0x81, 0x18, 0x01, 0x40,  //CVM Capability – CVM Required
            0xDF, 0x81, 0x19, 0x01, 0x08,  //CVM Capability – No CVM Required
            0xDF, 0x81, 0x1C, 0x02, 0x00, 0x00,  //Max Lifetime of Torn Transaction Log Record
            0xDF, 0x81, 0x1D, 0x01, 0x00,  //Max Number of Torn Transaction Log Records
            0xDF, 0x81, 0x1F, 0x01, 0x08,  //Security Capability

        };

        byte[] getCurConfig()
        {
            string conf = comboConf.Text;
            switch (conf)
            {
                case "PPS_MChip1":
                    return PPS_MChip1;

                default:
                    return PPS_MChip1;
            }
        }

        String getARC()
        {
            string val = comboARC.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val))
                {
                    MessageBox.Show("Invalid arc value");
                    return "";
                }
                byte[] arc = { 0x8a, 0x02 };
                arc[1] = (byte)(val.Length / 2);
                return byteArrayToString(arc) + val;
            }
            return "";
        }

        String getTransType()
        {
            string val = textTransType.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val, 1) || (!val.Equals("00")))
                {
                    MessageBox.Show("Invalid Transaction type");
                    return "";
                }
                byte[] tt = { 0x9C, 0x01 };
                return byteArrayToString(tt) + val;
            }
            return "";
        }

        String getTerminalType()
        {
            string val = terminalType.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val, 1) || (!val.Equals("22")))
                {
                    MessageBox.Show("Invalid terminal value");
                    return "";
                }
                byte[] tt = { 0x9F, 0x35, 0x01 };
                return byteArrayToString(tt) + val;
            }
            return "";
        }

        String getOfflineOnlineOptions()
        {
            string conf = offlineOnlineOptions.Text;
            byte[] options = {0xDF, 0x82, 0x07, 0x01};
            switch (conf)
            {
                case "Offline Only" :
                    return byteArrayToString(options) + "01";
                case "Online Only" :
                    return byteArrayToString(options) + "02";
                case "Offline & Online":
                    return byteArrayToString(options) + "03";
                default :
                    return byteArrayToString(options) + "01";
            }
        }


        String getSMI()
        {
            string val = comboSMI.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.ToLower().Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val, 2))
                {
                    MessageBox.Show("Invalid arc value");
                    return "";
                }
                byte[] tt = { 0xdf, 0x15, 0x02 };
                return byteArrayToString(tt) + val;
            }
            return "";
        }


        String getIAD()
        {
            string val = comboIAD.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.ToLower().Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val, 16))
                {
                    MessageBox.Show("Invalid IAD value");
                    return "";
                }
                byte[] iad = { 0x91, 0x10 };
                return byteArrayToString(iad) + val;
            }
            return "";
        }

        String getISS()
        {
            string val = textISS.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
            if ((!val.Equals("none")) && (val.Length != 0))
            {
                if (!iValidHex(val))
                {
                    MessageBox.Show("Invalid issuer script value");
                    return "";
                }
                return val;
            }
            return "";
        }

        void startTransaction()
        {
            if (!iValidHex(textAmount.Text, 6))
            {
                MessageBox.Show("Please enter valid value in amount field in paise (12 digits)");
                return;
            }
            btnTxnStart.Enabled = false;
            btnTxnCancel.Enabled = true;
            string data = byteArrayToString(getCurConfig());
            data += "9f0206" + textAmount.Text;
            byte[] un = new byte[4];
            Random rnd = new Random();
            rnd.NextBytes(un);
            data += "9f3704" + byteArrayToString(un);
            data += byteArrayToString(Date);
            data += byteArrayToString(Time);
            data += "9f0306000000000000";
            data += getTransType();
            //data += getSMI();
            data += "9f40056000c02001";
            data += "df3a050040000000";
            data += "9f15020743";
            data += "9f1c080000000000000000";
            data += "9f3303004860";
            data += "df16020000";
            data += getTerminalType();
            data += getOfflineOnlineOptions();
            connection.InvokeAsync("startTransaction", stringToByteArray(data));
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textFinancialConf.Text = "";
            textFinancialReq.Text = "";
            startTransaction();
        }

        public static string byteArrayToString(byte[] array)
        {
            return BitConverter.ToString(array).Replace("-", "");
        }
        public static byte[] stringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        //use System.Text.RegularExpressions before using this function
        public bool iValidHex(string strInput, int count)
        {
            //create Regular Expression Match pattern object
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");
            //boolean variable to hold the status
            bool isValid = false;
            if (string.IsNullOrEmpty(strInput))
            {
                isValid = false;
            }
            else
            {
                isValid = (count == 0 || strInput.Length == count * 2) && myRegex.IsMatch(strInput);
            }
            //return the results
            return isValid;
        }

        public bool iValidHex(string strInput)
        {
            //create Regular Expression Match pattern object
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");
            //boolean variable to hold the status
            bool isValid = false;
            if (string.IsNullOrEmpty(strInput))
            {
                isValid = false;
            }
            else
            {
                isValid = myRegex.IsMatch(strInput) && ((strInput.Length % 2) == 0);
            }
            //return the results
            return isValid;
        }

        byte[] Date = new byte[] { 0x9a, 0x03, 0x18, 0x07, 0x24 };
        byte[] Time = new byte[] { 0x9f, 0x21, 0x03, 0x02, 0x02, 0x02 };

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            textDate.Text = byteArrayToString(Date).Substring(4);
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            if (!iValidHex(textDate.Text, 3))
            {
                MessageBox.Show("Please enter valid value");
                return;
            }
            Date = stringToByteArray("9a03" + textDate.Text);
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            textTime.Text = byteArrayToString(Time).Substring(6);
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            if (!iValidHex(textTime.Text, 3))
            {
                MessageBox.Show("Please enter valid value");
                return;
            }
            Time = stringToByteArray("9f2103" + textTime.Text);
        }

        private void btnTxnCancel_Click(object sender, EventArgs e)
        {
            btnTxnStart.Enabled = true;
            btnTxnCancel.Enabled = false;
            connection.InvokeAsync("cancelTransaction");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = "20" + byteArrayToString(Date).Substring(4) + byteArrayToString(Time).Substring(6);
            DateTime dt = DateTime.ParseExact(str, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            dt = dt.AddSeconds(1);
            Date = stringToByteArray("9a03" + dt.ToString("yyMMdd"));
            Time = stringToByteArray("9f2103" + dt.ToString("HHmmss"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string data = "";
            //data += byteArrayToString(TTQ);
            connection.InvokeAsync("checksum", stringToByteArray(data));
        }

        private void comboConf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        static string Decrypt1(string TextToDecrypt)
        {
            if (TextToDecrypt.StartsWith("DF0108") || TextToDecrypt.StartsWith("df0108"))
            {
                TextToDecrypt = TextToDecrypt.Substring(6);
            }
            byte[] cipherText = stringToByteArray(TextToDecrypt);
            string plaintext = "Error";
            //
            var cipher = CipherUtilities.GetCipher("AES/ECB/NoPadding");
            byte[] Key = new byte[] { 0x12, 0x23, 0x45, 0x67, 0x12, 0x34, 0x45, 0x67, 0x12, 0x23, 0x45, 0x67, 0x12, 0x34, 0x45, 0x67 };
            cipher.Init(false, new KeyParameter(Key));
            byte[] planText = cipher.DoFinal(cipherText);
            plaintext = byteArrayToString(planText);
            while (plaintext.EndsWith("F") || plaintext.EndsWith("f"))
            {
                plaintext = plaintext.Substring(0, plaintext.Length - 1);
            }
            return plaintext;
        }

        public static string Decrypt2(string TextToDecrypt)
        {
            if (TextToDecrypt.StartsWith("DF0108") || TextToDecrypt.StartsWith("df0108"))
            {
                TextToDecrypt = TextToDecrypt.Substring(6);
            }
            byte[] MyDecryptArray = stringToByteArray(TextToDecrypt);

            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();

            byte[] MysecurityKeyArray = new byte[] { 0x12, 0x34, 0x45, 0x67, 0x12, 0x34, 0x45, 0x67, 0x12, 0x23, 0x45, 0x67, 0x12, 0x34, 0x45, 0x67 };

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = MysecurityKeyArray;

            MyTripleDESCryptoService.Mode = CipherMode.CBC;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateDecryptor();

            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyDecryptArray, 0,
               MyDecryptArray.Length);

            MyTripleDESCryptoService.Clear();

            string pin = byteArrayToString(MyresultArray);
            while (pin.EndsWith("F") || pin.EndsWith("f"))
            {
                pin = pin.Substring(0, pin.Length - 1);
            }

            return pin;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxDec.Text = Decrypt1(textBoxDec.Text);
            }
            catch (Exception)
            {
                textBoxDec.Text = "Error";
                //System.pr
            }
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await connection.StartAsync();
                await connection.InvokeAsync("addToHostGroup");
            }
            catch (Exception)
            {

            }
        }
    }
    public class SRetryPolcy : IRetryPolicy
    {
        public TimeSpan? NextRetryDelay(RetryContext retryContext)
        {
            return TimeSpan.FromSeconds(5);
        }
    }
}
