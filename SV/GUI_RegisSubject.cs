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
    public partial class GUI_RegisSubject : Form
    {
        public GUI_RegisSubject()
        {
            InitializeComponent();
        }
        private string _message;
        public string Dataregister
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _message1;
        public string Datatrans
        {
            get { return _message1; }
            set { _message1 = value; }
        }
        public void trandata()
        {
            txtstudentid.Text = _message;
            txtusername.Text = _message1;
        }
        private void loadcbsubject()
        {
            List<DTO_Subject> listsubject = BUS_Subject.loadsubject();
            cbsubject.DataSource = listsubject;
            cbsubject.DisplayMember = "subjectname"; // Giá trị hiển thị;
            cbsubject.ValueMember = "subjectid"; // Giá trị cần lấy;         
        }
        public void loadregister()
        {
            string id = txtstudentid.Text;
            List<DTO_RegisterSubject> listregister = BUS_RegisterSubject.loadregister(id);
            dataGridView1.DataSource = listregister;
        }
        private void GUI_RegisSubject_Load(object sender, EventArgs e)
        {
            trandata();
            DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
            loadcbsubject();
            loadregister();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtstudentid.Text == "" || cbsubject.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_RegisterSubject DTORegisterSubject = new DTO_RegisterSubject();
                DTORegisterSubject.Studentid = txtstudentid.Text;
                DTORegisterSubject.Subjectid = cbsubject.SelectedValue.ToString();
                string id = txtsubjectid.Text;
                if (BUS_RegisterSubject.CheckDup(DTORegisterSubject) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_RegisterSubject.InsertScore(DTORegisterSubject) == true)
                    {
                        MessageBox.Show("Register Subject Success", "Notification");
                        loadregister();
                        return;
                    }
                    MessageBox.Show("Register Subject Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Your Subject Register will be delete from Database", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txtstudentid.Text == "" || cbsubject.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_RegisterSubject DTORegisterSubject = new DTO_RegisterSubject();
                    DTORegisterSubject.Studentid = txtstudentid.Text;
                    DTORegisterSubject.Subjectid = cbsubject.SelectedValue.ToString();

                    if (BUS_RegisterSubject.DeleteScore(DTORegisterSubject) == true)
                    {
                        MessageBox.Show("Delete Subject Success", "Notification");
                        loadregister();
                        return;
                    }

                    MessageBox.Show("Delete Subject Failed", "Notification");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đưa dữ liệu lên datagirdview
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dataGridView1.Rows[index];
                txtstudentid.Text = dr.Cells[0].Value.ToString();
                cbsubject.Text = dr.Cells[1].Value.ToString();
                txtsubjectid.Text = dr.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Btback_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_User>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_RegisSubject Subject = new GUI_RegisSubject();
                    Subject.Close();
                    GUI_User user = new GUI_User();
                    user.Message2 = txtusername.Text;
                    user.Show();
                    user.Focus();
                }
            }
            catch (Exception ex)
            {

            }
           


        }
    }
}
