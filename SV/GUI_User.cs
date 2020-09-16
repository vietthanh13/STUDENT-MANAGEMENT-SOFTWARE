using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace SV
{
    public partial class GUI_User : Form
    {
        public GUI_User()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _message1;
        public string Message1
        {
            get { return _message1; }
            set { _message1 = value; }
        }
        private string _message2;
        public string Message2
        {
            get { return _message2; }
            set { _message2 = value; }
        }
        private string _message3;
        public string Message3
        {
            get { return _message3; }
            set { _message3 = value; }
        }
        private void GUI_User_Load(object sender, EventArgs e)
        {
            transdata(); // đưa dữ liệu qua lại giữ các Form User và Score
            loaddgvuser();
            Dgvuser_CellClick(dgvuser, new DataGridViewCellEventArgs(0, 0));
        }
        private void transdata()
        {
            try
            {
                txtgetusername.Text = _message; // lấy dữ liệu từ form login
                if (txtgetusername.Text == "")
                {
                    txtgetusername.Text = _message1; // lấy username từ form score
                    loaddgvuser();

                }
                if(txtgetusername.Text =="")
                {
                    txtgetusername.Text = _message2;
                    loaddgvuser();
                }
                if (txtgetusername.Text == "")
                {
                    txtgetusername.Text = _message3;
                    loaddgvuser();
                }
            }
            catch(Exception ex)
            {

            }


        }
        private void loaddgvuser()
        {
            string id = txtgetusername.Text;
            List<DTO_User> listuser = BUS_User.loaduser(id);
            dgvuser.DataSource = listuser;

        }

        private void Dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvuser.Rows[index];
                txtstudentid.Text = dr.Cells[4].Value.ToString();
                txtfirstname.Text = dr.Cells[5].Value.ToString();
                txtlastname.Text = dr.Cells[6].Value.ToString();
                txtdayofbirth.Text = dr.Cells[7].Value.ToString();
                txtsex.Text = dr.Cells[8].Value.ToString();
                txtplaceofbirth.Text = dr.Cells[9].Value.ToString();
                txtclassid.Text = dr.Cells[10].Value.ToString();
                txtmajor.Text = dr.Cells[12].Value.ToString();
            }
            catch (Exception ex)
            {

            }
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

        private void Btviewscore_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Score>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Score Score = new GUI_Score();
                    Score.Getdata = txtstudentid.Text;
                    Score.Getdata1 = txtgetusername.Text;
                    Score.Show();
                    Score.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void Btregistersubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_RegisSubject>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_RegisSubject RegisterSubject = new GUI_RegisSubject();
                    RegisterSubject.Dataregister = txtstudentid.Text;
                    RegisterSubject.Datatrans = txtgetusername.Text;
                    RegisterSubject.Show();
                    RegisterSubject.Focus();
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        private void Btpass_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (Application.OpenForms.OfType<GUI_Pass>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Pass Pass = new GUI_Pass();
                    Pass.Message = txtgetusername.Text;
                    Pass.Show();
                    Pass.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
