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
    public partial class GUI_Student : Form
    {
        public GUI_Student()
        {
            InitializeComponent();
        }

        private void GUI_Student_Load(object sender, EventArgs e)
        {
            loadstudent();
            loadstudentnull();
            studentnull();
            loadstudentclass();
            loadcbsex();
            loadcbclassid();
        }
        private void loadstudent()
        {
            try
            {
                List<DTO_Student> liststudent = BUS_Student.loadstudent();
                dgvstudent.DataSource = liststudent;
                dgvstudent.Columns[12].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }
        private void studentnull()
        {
            try
            {
                List<DTO_Student> listnullstudent = BUS_Student.studentnull();
                dgvstudentnull.DataSource = listnullstudent;
                dgvstudentnull.Columns[1].Visible = false;
                dgvstudentnull.Columns[2].Visible = false;
                dgvstudentnull.Columns[3].Visible = false;
                dgvstudentnull.Columns[11].Visible = false;
                dgvstudentnull.Columns[12].Visible = false;
                dgvstudentnull.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {

            }
        }
        private void loadstudentnull()
        {
            try
            {
                List<DTO_Student> liststudentnull = BUS_Student.loadstudentnull();
                dgvaccount.DataSource = liststudentnull;
                dgvaccount.Columns[2].Visible = false;
                dgvaccount.Columns[3].Visible = false;
                dgvaccount.Columns[4].Visible = false;
                dgvaccount.Columns[5].Visible = false;
                dgvaccount.Columns[6].Visible = false;
                dgvaccount.Columns[7].Visible = false;
                dgvaccount.Columns[8].Visible = false;
                dgvaccount.Columns[9].Visible = false;
                dgvaccount.Columns[10].Visible = false;
                dgvaccount.Columns[11].Visible = false;
                dgvaccount.Columns[12].Visible = false;
                dgvaccount.Columns[13].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }
        private void loadstudentclass()
        {
            try
            {
                List<DTO_Student> liststudentclass = BUS_Student.loadstudentclass();
                dgvclass.DataSource = liststudentclass;
                dgvclass.Columns[0].Visible = false;
                dgvclass.Columns[1].Visible = false;
                dgvclass.Columns[2].Visible = false;
                dgvclass.Columns[3].Visible = false;
                dgvclass.Columns[4].Visible = false;
                dgvclass.Columns[5].Visible = false;
                dgvclass.Columns[6].Visible = false;
                dgvclass.Columns[7].Visible = false;
                dgvclass.Columns[8].Visible = false;
                dgvclass.Columns[9].Visible = false;
                dgvclass.Columns[11].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }
        private void loadcbsex()
        {
            cbsex.Items.Add("Female");
            cbsex.Items.Add("Male");
        }
        private void loadcbclassid()
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            cbclassid.DataSource = listclass;
            cbclassid.DisplayMember = "classid"; // Giá trị hiển thị;
            cbclassid.ValueMember = "classid"; // Giá trị cần lấy;  
        }
        private void Dgvstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvstudent.Rows[index];
                txtuserid.Text = dr.Cells[0].Value.ToString();
                txtstudentid.Text = dr.Cells[4].Value.ToString();
                txtfirstname.Text = dr.Cells[5].Value.ToString();
                txtlastname.Text = dr.Cells[6].Value.ToString();
                txtdayofbirth.Text = dr.Cells[7].Value.ToString();
                cbsex.Text = dr.Cells[8].Value.ToString();
                txtplaceofbirth.Text = dr.Cells[9].Value.ToString();
                cbclassid.Text = dr.Cells[10].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();  
                txtid1.Text = dr.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Dgvclass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvclass.Rows[index];
                cbclassid.Text = dr.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Dgvaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvaccount.Rows[index];
               // if (txtuserid.Text =="")
                //{
                    txtuserid.Text = dr.Cells[0].Value.ToString();
                //}
                //else
                //{
                   // MessageBox.Show("Student information has an account");
                //}
            }
            catch (Exception ex)
            {

            }
        }

        private void Btadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtuserid.Text == "" || txtstudentid.Text == "" || txtfirstname.Text == "" || txtlastname.Text == "" || txtdayofbirth.Text == "" || cbsex.Text == "" || txtplaceofbirth.Text == "" || cbclassid.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Student DTOStudent = new DTO_Student();
                DTOStudent.Userid = txtuserid.Text;
                DTOStudent.Studentid = txtstudentid.Text;
                DTOStudent.Firstname = txtfirstname.Text;
                DTOStudent.Lastname = txtlastname.Text;
                DTOStudent.Dayofbirth = txtdayofbirth.Text;
                DTOStudent.Sex = cbsex.Text;
                DTOStudent.Placeofbirth = txtplaceofbirth.Text;
                DTOStudent.Classid = cbclassid.Text;
                if (BUS_Student.CheckDup(DTOStudent) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Student.InsertStudent(DTOStudent) == true)
                    {
                        MessageBox.Show("Add Student Success", "Notification");
                        studentnull();
                        loadstudent();
                        loadstudentnull();
                        loadcbclassid();
                        return;
                    }
                    MessageBox.Show("Add Student Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Btedit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Class information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txtuserid.Text == "" || txtstudentid.Text == "" || txtfirstname.Text == "" || txtlastname.Text == "" || txtdayofbirth.Text == "" || cbsex.Text == "" || txtplaceofbirth.Text == "" || cbclassid.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Student DTOStudent = new DTO_Student();
                    DTOStudent.Userid = txtuserid.Text;
                    DTOStudent.Studentid = txtstudentid.Text;
                    DTOStudent.Firstname = txtfirstname.Text;
                    DTOStudent.Lastname = txtlastname.Text;
                    DTOStudent.Dayofbirth = txtdayofbirth.Text;
                    DTOStudent.Sex = cbsex.Text;
                    DTOStudent.Placeofbirth = txtplaceofbirth.Text;
                    DTOStudent.Classid = cbclassid.Text;
                    string id = txtid.Text;
                    string id1 = txtid1.Text;
                    if (BUS_Student.UpdateStudent(DTOStudent, id, id1) == true)
                    {
                        MessageBox.Show("Edit Student Success", "Notification");
                        studentnull();
                        loadstudent();
                        loadstudentnull();
                        loadcbclassid();
                        return;
                    }
                    MessageBox.Show("Edit Student Failed", "Notification");

                }

                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtuserid.Text = "";
            txtstudentid.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text= "";
            txtdayofbirth.Text = "";
            cbsex.Text= "";
            txtplaceofbirth.Text = "";
            cbclassid.Text = "";
        }

        private void Btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Student information will be delete from Database", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txtuserid.Text == "" || txtstudentid.Text == "" || txtfirstname.Text == "" || txtlastname.Text == "" || txtdayofbirth.Text == "" || cbsex.Text == "" || txtplaceofbirth.Text == "" || cbclassid.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Student DTOStudent = new DTO_Student();
                    DTOStudent.Userid = txtuserid.Text;
                    DTOStudent.Studentid = txtstudentid.Text;
                    DTOStudent.Firstname = txtfirstname.Text;
                    DTOStudent.Lastname = txtlastname.Text;
                    DTOStudent.Dayofbirth = txtdayofbirth.Text;
                    DTOStudent.Sex = cbsex.Text;
                    DTOStudent.Placeofbirth = txtplaceofbirth.Text;
                    DTOStudent.Classid = cbclassid.Text;
                    string id = txtid.Text;
                    string id1 = txtid1.Text;

                    if (BUS_Student.DeleteStudentIdInScore(DTOStudent,id1) == true)
                    {
                        if (BUS_Student.DeleteStudent(DTOStudent,id,id1) == true)
                        {
                            MessageBox.Show("Delete Student Success", "Notification");
                            studentnull();
                            loadstudent();
                            loadstudentnull();
                            loadcbclassid();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete Student Failed", "Notification");
                    }
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

        private void Btshowall_Click(object sender, EventArgs e)
        {
            studentnull();
            loadstudent();
            loadstudentnull();
            loadcbclassid();
        }

        private void Btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                string id = txtsearch.Text;
                List<DTO_Student> liststudent = BUS_Student.searchstudent(id);
                dgvstudent.DataSource = liststudent;
            }
            catch(Exception ex)
            {

            }
        }

        private void Btmanager_Click(object sender, EventArgs e)
        {
            try
            {
                GUI_Manager Manager = new GUI_Manager();
                if (Application.OpenForms.OfType<GUI_Manager>().Any())
                {

                    MessageBox.Show("Form is opened");
                    Manager.Focus();
                }
                else
                {
                    Manager.Show();
                    Manager.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            GUI_ManagerRpStudent ManagerRpStudent = new GUI_ManagerRpStudent();
            ManagerRpStudent.Show();
            ManagerRpStudent.Focus();
        }

        private void Dgvstudentnull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvstudentnull.Rows[index];
                txtuserid.Text = dr.Cells[0].Value.ToString();
                txtstudentid.Text = dr.Cells[4].Value.ToString();
                txtfirstname.Text = dr.Cells[5].Value.ToString();
                txtlastname.Text = dr.Cells[6].Value.ToString();
                txtdayofbirth.Text = dr.Cells[7].Value.ToString();
                cbsex.Text = dr.Cells[8].Value.ToString();
                txtplaceofbirth.Text = dr.Cells[9].Value.ToString();
                cbclassid.Text = dr.Cells[10].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
                txtid1.Text = dr.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
