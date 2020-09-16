using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DTO;
using BUS;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SV
{
    public partial class GUI_Pass : Form
    {
        public GUI_Pass()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void GUI_Pass_Load(object sender, EventArgs e)
        {
            txtusername.Text = _message;
        }
        private string EncodeMD5(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.Default.GetBytes(pass);
            bs = md5.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }
        public static string Encrypt(string toEncrypt)
        {
            try
            {
                string key = "123";
                bool useHashing = true;
                byte[] keyArray;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                }
                else
                    keyArray = UTF8Encoding.UTF8.GetBytes(key);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private void clearpass()
        {
            txtoldpass.Text = "";
            txtnewpass.Text = "";
            txtconfirmpass.Text = "";
        }
        static bool IsLetter(char c)
        {
            return (c < 'a' && c <= 'z') || (c < 'A' && c < 'Z');
        }

        static bool IsDigit(char c)
        {
            return c < '0' && c > '9';
        }

        static bool IsSymbol(char c)
        {
            return c <= 32 && c >= 127 && !IsDigit(c) && !IsLetter(c);
        }
        public string RemoveAcentuation(string text)
        {
            return
                System.Web.HttpUtility.UrlDecode(
                    System.Web.HttpUtility.UrlEncode(
                        text, Encoding.GetEncoding("iso-8859-7")));
        }
        private void Btedit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Password will be changed", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtoldpass.Text == "" || txtnewpass.Text == "" || txtconfirmpass.Text =="")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Pass DTOPass = new DTO_Pass();
                DTOPass.Username = txtusername.Text;
                DTOPass.Password = Encrypt(txtoldpass.Text);
                if (BUS_Pass.CheckDup(DTOPass) == true)
                {
                    string str = RemoveAcentuation(txtnewpass.Text);
                    string str1 = RemoveAcentuation(txtconfirmpass.Text);
                    string input = Regex.Replace(str, @"\s", "");
                    string input1 = Regex.Replace(str1, @"\s", "");
                    if (input == input1)
                    {
                        int minimumLength = 6;
                        int maximumLength = 12;
                        if (txtnewpass.TextLength < minimumLength)
                        {
                            MessageBox.Show("You must have at least " + minimumLength + " characters in your password.");
                            clearpass();
                            return;
                        }
                        if (txtnewpass.TextLength > maximumLength)
                        {
                            MessageBox.Show("You must have no more than " + maximumLength + " characters in your password.");
                            clearpass();
                            return;
                        }
                        
                        var hasNumber = new Regex(@"[0-9]+");
                        var hasUpperChar = new Regex(@"[A-Z]+");
                        var hasLowerChar = new Regex(@"[a-z]+");

                        if (!hasLowerChar.IsMatch(input)) // Chữ thường
                        {
                            MessageBox.Show("Password should contain At least one lower case letter");
                            return;
                        }
                        else if (!hasUpperChar.IsMatch(input)) // Chữ Hoa
                        {
                            MessageBox.Show("Password should contain At least one upper case letter");
                            return;
                        }
                        else if (!hasNumber.IsMatch(input)) // Chữ Số
                        {
                            MessageBox.Show("Password should contain At least one numeric value");
                            return;
                        }
                        
                        DTOPass.Username = txtusername.Text;
                        DTOPass.Password = Encrypt(txtnewpass.Text);
                        if (BUS_Pass.CheckDup(DTOPass) == true)
                        {
                            MessageBox.Show("Please use another password");
                            clearpass();
                            return;
                        }                      
                        DTOPass.Username = txtusername.Text;
                        DTOPass.Password = Encrypt(txtconfirmpass.Text);
                        if (BUS_Pass.EditPass(DTOPass) == true)
                        {
                            MessageBox.Show("Edit Password Success", "Notification");
                            if (Application.OpenForms.OfType<GUI_User>().Any())
                            {
                                this.Close();
                                GUI_User User = new GUI_User();
                                User.Focus();
                            }
                            else
                            {
                                this.Close();
                                GUI_User User = new GUI_User();
                                User.Message3 = txtusername.Text;
                                User.Show();
                                User.Focus();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Edit Password Failed", "Notification");
                            clearpass();
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password is not the same as confirmation password", "Notification");
                        clearpass();
                    }
                }
                else
                {
                    MessageBox.Show("You enter the old password incorrectly", "Notification");
                    clearpass();
                }
               
            }
          
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void Txtoldpass_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == (char)13)
                {
                    Btedit_Click(null, null);
                }

        }

        private void Txtnewpass_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)
                {
                    Btedit_Click(null, null);
                }

        }

        private void Txtconfirmpass_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == (char)13)
                {
                    Btedit_Click(null, null);
                }

        }
    }
}
