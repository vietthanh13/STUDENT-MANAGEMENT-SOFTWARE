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
using System.Web.UI.WebControls;

namespace SV
{
    public partial class GUI_MenuAdmin : Form
    {
        public GUI_MenuAdmin()
        {
            InitializeComponent();
        }

        private void GUI_MenuAdmin_Load(object sender, EventArgs e)
        {
            loaddgvuser();
            loadcbauth();          
            colorstatus();

        }
        private void colorstatus()
        {
            try
            {
                int rowscount = dgvuser.Rows.Count;

                for (int i = 0; i < rowscount; i++)
                {
                    if (dgvuser.Rows[i].Cells[4].Value.ToString() == "Disable")
                    {
                        dgvuser.Rows[i].Cells[4].Style.ForeColor = Color.DarkRed;
                        //dgvuser.Rows[i].Cells[4].DataGridView.GridColor = Color.Red;
                    }
                    else
                    {
                        dgvuser.Rows[i].Cells[4].Style.ForeColor = Color.DarkGreen;
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void loaddgvuser()
        {
            List<DTO_MenuAdmin> listuser = BUS_MenuAdmin.loaduser();
            dgvuser.DataSource = listuser;
            dgvuser.Columns[4].HeaderText = "Status";
        }
        private void loadcbauth()
        {
            cbauth.Items.Add("Admin");
            cbauth.Items.Add("User");
            cbauth.Items.Add("Manager");
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

        private void Btadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtusername.Text == "" || txtpassword.Text == "" || cbauth.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_MenuAdmin DTOMenuAdmin = new DTO_MenuAdmin();
                DTOMenuAdmin.Username = txtusername.Text;
                DTOMenuAdmin.Password = Encrypt(txtpassword.Text);
                DTOMenuAdmin.Auth = cbauth.Text;
                if (BUS_MenuAdmin.CheckDup(DTOMenuAdmin) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_MenuAdmin.InsertUser(DTOMenuAdmin) == true)
                    {
                        MessageBox.Show("Add User Success", "Notification");
                        loaddgvuser();
                        colorstatus();
                        return;
                    }
                    MessageBox.Show("Add User Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btedit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("User information will be changed", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtusername.Text == "" || txtpassword.Text == "" || cbauth.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                else
                {
                    // Đối tượng class trong DTO
                    DTO_MenuAdmin DTOMenuAdmin = new DTO_MenuAdmin();
                    DTOMenuAdmin.Username = txtusername.Text;
                    DTOMenuAdmin.Password = Encrypt(txtpassword.Text);
                    DTOMenuAdmin.Auth = cbauth.Text;
                    string id = txtid.Text;
                    if (txtpassword.Text == txtpass1.Text)
                    {
                        txtpassword.Text = Decrypt(txtpass2.Text);
                        DTOMenuAdmin.Password = Encrypt(txtpassword.Text);
                    }
                    txtpassword.Text = txtpass1.Text;
                    if (BUS_MenuAdmin.EditUser(DTOMenuAdmin, id) == true)
                    {
                        MessageBox.Show("Edit User Success", "Notification");
                        loaddgvuser();
                        colorstatus();
                        clear();
                        return;
                    }
                    MessageBox.Show("Edit User Failed", "Notification");

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void Dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //Đưa dữ liệu lên datagirdview
                int index = e.RowIndex;
                DataGridViewRow dr = dgvuser.Rows[index];
                txtuserid.Text = dr.Cells[0].Value.ToString();
                txtusername.Text = dr.Cells[1].Value.ToString();
                txtpassword.Text = dr.Cells[2].Value.ToString();
                cbauth.Text = dr.Cells[3].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
                txtcheckstatus.Text = dr.Cells[4].Value.ToString();
                txtpass1.Text = dr.Cells[2].Value.ToString();
                txtpass2.Text = dr.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtuserid.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            cbauth.Text = "";
            txtid.Text = "";
            txtcheckstatus.Text = "";
        }

        private void Btdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("User information will be delete from Database", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtusername.Text == "" || txtpassword.Text == "" || cbauth.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_MenuAdmin DTOMenuAdmin = new DTO_MenuAdmin();
                DTOMenuAdmin.Username = txtusername.Text;
                DTOMenuAdmin.Password = txtpassword.Text;
                DTOMenuAdmin.Auth = cbauth.Text;
                string id = txtid.Text;
                if (BUS_MenuAdmin.DeleteUserIdInStudent(DTOMenuAdmin, id) == true)
                {
                    if (BUS_MenuAdmin.DeleteUser(DTOMenuAdmin, id) == true)
                    {
                        MessageBox.Show("Delete Class Success", "Notification");
                        loaddgvuser();
                        colorstatus();
                        return;
                    }
                }

                MessageBox.Show("Delete Class Failed", "Notification");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void Btsearch_Click(object sender, EventArgs e)
        {
            string id = txtsearch.Text;
            List<DTO_MenuAdmin> listuser = BUS_MenuAdmin.searchuser(id);
            dgvuser.DataSource = listuser;
            colorstatus();
        }

        private void Btshowall_Click(object sender, EventArgs e)
        {
            List<DTO_MenuAdmin> listuser = BUS_MenuAdmin.loaduser();
            dgvuser.DataSource = listuser;
            colorstatus();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit ?", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GUI_Login Login = new GUI_Login();
                this.Hide();
                Login.Show();
                Login.Focus();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            GUI_ManagerRpUser ManagerRptUser = new GUI_ManagerRpUser();
            ManagerRptUser.Show();
        }

        private void Txtenable_Click(object sender, EventArgs e)
        {
                // Kiểm tra dữ liệu đầu vào
                if (txtusername.Text == "" || txtpassword.Text == "" || cbauth.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                else
                {
                    // Đối tượng class trong DTO
                    DTO_MenuAdmin DTOMenuAdmin = new DTO_MenuAdmin();
                    DTOMenuAdmin.Userid = txtuserid.Text;
                    if (BUS_MenuAdmin.UpdateEnable(DTOMenuAdmin) == true)
                    {
                    if (txtcheckstatus.Text == "Enable")
                    {
                        MessageBox.Show("Account is Enable", "Notification");
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Enable User Success", "Notification");
                        loaddgvuser();
                        colorstatus();
                        return;
                    }
                    
                    }
                    MessageBox.Show("Enable User Failed", "Notification");
                }
            
        }

        private void Txtdisable_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (txtusername.Text == "" || txtpassword.Text == "" || cbauth.Text == "")
            {
                MessageBox.Show("All Fields Are Compulsory");
                return;
            }
            else
            {
                // Đối tượng class trong DTO
                DTO_MenuAdmin DTOMenuAdmin = new DTO_MenuAdmin();
                DTOMenuAdmin.Userid = txtuserid.Text;
                if (BUS_MenuAdmin.UpdateDisable(DTOMenuAdmin) == true)
                {
                    if (txtcheckstatus.Text == "Disable")
                    {
                        MessageBox.Show("Account is Disable", "Notification");
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Disable User Success", "Notification");
                        loaddgvuser();
                        colorstatus();
                        return;
                    }
                }
                MessageBox.Show("Disable User Failed", "Notification");
            }
        }
    }
}
