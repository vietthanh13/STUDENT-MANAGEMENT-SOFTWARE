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
    public partial class GUI_Subject : Form
    {
        public GUI_Subject()
        {
            InitializeComponent();
        }

        private void GUI_Subject_Load(object sender, EventArgs e)
        {
            loaddgvsubject();
            loadcbcredit();
        }
        private void loaddgvsubject()
        {
            List<DTO_Subject> listsubject = BUS_Subject.loadsubject();
            dgvsubject.DataSource = listsubject;
        }
        private void loadcbcredit()
        {
            cbcredit.Items.Add("1");
            cbcredit.Items.Add("2");
            cbcredit.Items.Add("3");
            cbcredit.Items.Add("4");
            cbcredit.Items.Add("5");
            cbcredit.Items.Add("6");
        }

        private void Btadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtsubjectid.Text == "" || txtsubjectname.Text == "" || cbcredit.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Subject DTOSubject = new DTO_Subject();
                DTOSubject.Subjectid = txtsubjectid.Text;
                DTOSubject.Subjectname = txtsubjectname.Text;
                DTOSubject.Credit = cbcredit.Text;
                if (BUS_Subject.CheckDup(DTOSubject) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Subject.InsertSubject(DTOSubject) == true)
                    {
                        MessageBox.Show("Add Subject Success", "Notification");
                        loaddgvsubject();
                        return;
                    }
                    MessageBox.Show("Add Subject Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btedit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Subject information will be changed", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtsubjectid.Text == "" || txtsubjectname.Text == "" || cbcredit.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Subject DTOSubject = new DTO_Subject();
                DTOSubject.Subjectid = txtsubjectid.Text;
                DTOSubject.Subjectname = txtsubjectname.Text;
                DTOSubject.Credit = cbcredit.Text;
                string id = txtid.Text;
                if (BUS_Subject.EditSubjectIdScore(DTOSubject, id) == true)
                {
                    if (BUS_Subject.EditSubjectIdSemester(DTOSubject, id) == true)
                    {
                        if (BUS_Subject.EditSubject(DTOSubject, id) == true)
                        {
                            if (BUS_Subject.EditNullSubjectIdInScore(DTOSubject) == true)
                            {
                                if (BUS_Subject.EditNullSubjectIdInSemester(DTOSubject) == true)
                                {
                                    MessageBox.Show("Edit Subject Success", "Notification");
                                    loaddgvsubject();
                                    return;
                                }
                            }
                        }
                    }
                    MessageBox.Show("Edit Subject Failed", "Notification");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void Dgvsubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvsubject.Rows[index];
                txtsubjectid.Text = dr.Cells[0].Value.ToString();
                txtsubjectname.Text = dr.Cells[1].Value.ToString();
                cbcredit.Text = dr.Cells[2].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Btdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Class information will be delete from Database", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtsubjectid.Text == "" || txtsubjectname.Text == "" || cbcredit.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Subject DTOSubject = new DTO_Subject();
                DTOSubject.Subjectid = txtsubjectid.Text;
                DTOSubject.Subjectname = txtsubjectname.Text;
                DTOSubject.Credit = cbcredit.Text;
                string id = txtid.Text;
                if (BUS_Subject.DeleteScore(DTOSubject,id) == true)
                {
                    if (BUS_Subject.DeleteSemester(DTOSubject,id) == true)
                    {
                        if (BUS_Subject.DeleteSubject(DTOSubject) == true)
                        {
                            MessageBox.Show("Delete Subject Success", "Notification");
                            loaddgvsubject();
                            return;
                        }
                    }
                    MessageBox.Show("Delete Subject Failed", "Notification");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
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
                List<DTO_Subject> listsubject = BUS_Subject.searchsubject(id);
                dgvsubject.DataSource = listsubject;
            }
            catch(Exception ex)
            {

            }
        }

        private void Btshowall_Click(object sender, EventArgs e)
        {

            List<DTO_Subject> listsubject = BUS_Subject.loadsubject();
            dgvsubject.DataSource = listsubject;
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtsubjectname.Text = "";
            txtsubjectid.Text = "";
            txtsearch.Text = "";
            cbcredit.Text = "";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            GUI_ManagerRpSubject ManagerRpSubject = new GUI_ManagerRpSubject();
            ManagerRpSubject.Show();
            ManagerRpSubject.Focus();
        }
    }
}
