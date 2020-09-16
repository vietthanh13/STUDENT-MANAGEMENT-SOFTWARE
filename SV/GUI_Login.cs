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


namespace SV
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }
        private void GUI_Login_Load(object sender, EventArgs e)
        {
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

        public static string Decrypt(string toDecrypt)
        {
            try
            {
                string key = "123";
                bool useHashing = true;
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

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

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private void Btlogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtusername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                    // Đối tượng class trong DTO
                    DTO_Login DTOLogin = new DTO_Login();
                    DTOLogin.Username = txtusername.Text;
                    DTOLogin.Password = txtpassword.Text;
                    DTOLogin.CheckStatus = txtdisable.Text;

                    string id1 = txtcheckadmin.Text;
                    string id2 = txtcheckuser.Text;
                    string id3 = txtcheckmanager.Text;
                if (BUS_Login.CheckAuth(DTOLogin) == true)
                {
                    MessageBox.Show("Your account has not been activated yet");
                }
                else
                {
                    if (BUS_Login.CheckLogin(DTOLogin, id1) == true)
                    {
                        GUI_MenuAdmin MenuAdmin = new GUI_MenuAdmin();
                        this.Hide();
                        MenuAdmin.Show();
                        MenuAdmin.Focus();

                    }
                    else if (BUS_Login.CheckLogin(DTOLogin, id2) == true)
                    {
                        GUI_User User = new GUI_User();
                        User.Message = txtusername.Text;
                        this.Hide();
                        User.Show();
                        User.Focus();

                    }
                    else if (BUS_Login.CheckLogin(DTOLogin, id3) == true)
                    {
                        this.Hide();
                        GUI_Manager Manager = new GUI_Manager();
                        Manager.Show();
                        Manager.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Account Or Password !!!");
                        txtpassword.Text = "";
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GUI_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btlogin_Click(null,null);
            }
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btlogin_Click(null, null);
            }
        }

        private void Txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btlogin_Click(null, null);
            }
        }

        private void GUI_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI_Login Login = new GUI_Login();
            Application.Exit();
        }

        private void Txtenable_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcheckuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
