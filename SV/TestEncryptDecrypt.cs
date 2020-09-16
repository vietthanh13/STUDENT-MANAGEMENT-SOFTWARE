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
using System.Text.RegularExpressions;

namespace SV
{
    public partial class TestEncryptDecrypt : Form
    {
        public TestEncryptDecrypt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmahoa.Size = new System.Drawing.Size(500, 50);
            txtgiaima.Size = new System.Drawing.Size(500, 50);
            txtketqua.Size = new System.Drawing.Size(500, 50);
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
        public string DecodeMD5(string pass)
        {
            byte[] data = Convert.FromBase64String(pass); // decrypt the incrypted text

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())

            {

                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(pass));

                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })

                {

                    ICryptoTransform transform = tripDes.CreateDecryptor();

                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    pass = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return pass;
        }
        public string EncodeMD5(string toEncrypt, bool useHasing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.Default.GetBytes(toEncrypt);
            if (useHasing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.Default.GetBytes(""));
            }
            else keyArray = Encoding.Default.GetBytes("");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public string DecodeMD5(string toDecrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.Default.GetBytes(""));
            }
            else keyArray = Encoding.Default.GetBytes("");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.Default.GetString(resultArray);
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                return "";
            }
        }
        public string RemoveAcentuation(string text)
        {
            return
                System.Web.HttpUtility.UrlDecode(
                    System.Web.HttpUtility.UrlEncode(
                        text, Encoding.GetEncoding("iso-8859-7")));
        }

        private void Btmahoa_Click(object sender, EventArgs e)
        {
            string EncryptCode = Encrypt(txtmahoa.Text);
            txtketqua.Text = EncryptCode;
        }
        
        private void Btgiaima_Click(object sender, EventArgs e)
        {
            string DecryptCode = Decrypt(txtketqua.Text);
            txtketqua.Text = DecryptCode;
           
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtgiaima.Text = "";
            txtketqua.Text = "";
            txtmahoa.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtketqua.Text = txtgiaima.Text;
        }
    }
}
