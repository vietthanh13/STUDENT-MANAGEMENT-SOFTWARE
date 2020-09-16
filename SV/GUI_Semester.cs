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
    public partial class GUI_Semester : Form
    {
        public GUI_Semester()
        {
            InitializeComponent();
        }

        private void GUI_Semester_Load(object sender, EventArgs e)
        {
            loaddgvsemester();
            cbsubject();
            cbclass();
            cbsemesterload();
        }
        private void loaddgvsemester()
        {
            List<DTO_Semester> listsemester = BUS_Semester.loadsemester();
            dgvsemester.DataSource = listsemester;
        }
        private void cbsubject()
        {
            List<DTO_Subject> listsubject = BUS_Subject.loadsubject();
            cbsubjectid.DataSource = listsubject;
            cbsubjectid.DisplayMember = "subjectid"; // Giá trị hiển thị;
            cbsubjectid.ValueMember = "subjectid"; // Giá trị cần lấy;       
        }
        private void cbclass()
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            cbclassid.DataSource = listclass;
            cbclassid.DisplayMember = "classid"; // Giá trị hiển thị;
            cbclassid.ValueMember = "classid"; // Giá trị cần lấy;    
        }
        private void cbsemesterload()
        {
            cbsemester.Items.Add("I");
            cbsemester.Items.Add("II");
            cbsemester.Items.Add("III");
            cbsemester.Items.Add("IV");
        }

        private void Btadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (cbsubjectid.Text == "" || cbclassid.Text == "" || cbsemester.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Semester DTOSemester = new DTO_Semester();
                DTOSemester.Subjectid = cbsubjectid.Text;
                DTOSemester.Classid = cbclassid.Text;
                DTOSemester.Semester = cbsemester.Text;
                if (BUS_Semester.CheckDup(DTOSemester) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Semester.InsertSemester(DTOSemester) == true)
                    {
                        MessageBox.Show("Add Semester Success", "Notification");
                        loaddgvsemester();
                        return;
                    }
                    MessageBox.Show("Add Semester Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Semester information will be delete from Database", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (cbsubjectid.Text == "" || cbclassid.Text == "" || cbsemester.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Semester DTOSemester = new DTO_Semester();
                    DTOSemester.Subjectid = cbsubjectid.Text;
                    DTOSemester.Classid = cbclassid.Text;
                    DTOSemester.Semester = cbsemester.Text;
                    string id1 = txtid1.Text;
                    string id2 = txtid2.Text;

                    if (BUS_Semester.DeleteSemester(DTOSemester, id1, id2) == true)
                    {
                        MessageBox.Show("Delete Semester Success", "Notification");
                        loaddgvsemester();
                        return;
                    }
                    MessageBox.Show("Delete Semester Failed", "Notification");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Btedit_Click(object sender, EventArgs e)
        {try
            {
                DialogResult dialogResult = MessageBox.Show("Semester information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (cbsubjectid.Text == "" || cbclassid.Text == "" || cbsemester.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Semester DTOSemester = new DTO_Semester();
                    DTOSemester.Subjectid = cbsubjectid.Text;
                    DTOSemester.Classid = cbclassid.Text;
                    DTOSemester.Semester = cbsemester.Text;
                    string id1 = txtid1.Text;
                    string id2 = txtid2.Text;

                    if (BUS_Semester.EditSemester(DTOSemester, id1, id2) == true)
                    {
                        MessageBox.Show("Edit Semester Success", "Notification");
                        loaddgvsemester();
                        return;
                    }
                    MessageBox.Show("Edit Semester Failed", "Notification");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Dgvsemester_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đưa dữ liệu lên datagirdview
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvsemester.Rows[index];
                cbsubjectid.Text = dr.Cells[0].Value.ToString();
                cbclassid.Text = dr.Cells[1].Value.ToString();
                cbsemester.Text = dr.Cells[2].Value.ToString();
                txtid1.Text = dr.Cells[0].Value.ToString();
                txtid2.Text = dr.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

            }
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
                List<DTO_Semester> search = BUS_Semester.searchsemester(id);
                dgvsemester.DataSource = search;
            }
            catch(Exception ex)
            {

            }
        }

        private void Btshowall_Click(object sender, EventArgs e)
        {
            loaddgvsemester();
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
    }

}
