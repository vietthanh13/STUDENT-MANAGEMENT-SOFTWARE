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
    public partial class GUI_InputScore : Form
    {
        public GUI_InputScore()
        {
            InitializeComponent();
        }

        private void GUI_InputScore_Load(object sender, EventArgs e)
        {
            
            loadcbsubject();
            loadcbsemester();
            loadcbsearch();
        }
        private void loaddgvscore()
        {
            try
            {


                string id = cbsearch.SelectedValue.ToString();
                List<DTO_InputScore> listscore = BUS_InputScore.loadscore(id);
                dgvscore.DataSource = listscore;
            }
            catch (Exception ex)
            {

            }
        }
        private void loadcbsemester()
        {
            cbsemester.Items.Add("");
            cbsemester.Items.Add("I");
            cbsemester.Items.Add("II");
            cbsemester.Items.Add("III");
            cbsemester.Items.Add("IV");
        }
        private void loadcbsearch()
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            cbsearch.DataSource = listclass;
            cbsearch.DisplayMember = "classname"; // Giá trị hiển thị;
            cbsearch.ValueMember = "classid"; // Giá trị cần lấy;          
        }
        private void loadcbsubject()
        {
            List<DTO_Subject> listsubject = BUS_Subject.loadsubject();
            cbsubject.DataSource = listsubject;
            cbsubject.DisplayMember = "subjectname"; // Giá trị hiển thị;
            cbsubject.ValueMember = "subjectid"; // Giá trị cần lấy;          
        }
        private void Btadd_Click(object sender, EventArgs e)
        {

        }

        private void Dgvscore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgvscore.Rows[index];
                txtstudentid.Text = dr.Cells[0].Value.ToString();
                txtclassid.Text = dr.Cells[1].Value.ToString();
                cbsubject.Text = dr.Cells[3].Value.ToString();
                txtscore1.Text = dr.Cells[4].Value.ToString();
                txtscore2.Text = dr.Cells[5].Value.ToString();
                cbsemester.Text = dr.Cells[6].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Btedit_Click(object sender, EventArgs e)
        {
           // DialogResult dialogResult = MessageBox.Show("Score information will be changed", "Notification", MessageBoxButtons.YesNo);
          //  if (dialogResult == DialogResult.Yes)
           // {
                // Kiểm tra dữ liệu đầu vào
                if (txtstudentid.Text == "" || cbsubject.Text == "" || txtscore1.Text == "" || txtscore2.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_InputScore DTOInputScore = new DTO_InputScore();
                DTOInputScore.Studentid = txtstudentid.Text;
                DTOInputScore.Subjectid = cbsubject.SelectedValue.ToString();
                DTOInputScore.Score1 = txtscore1.Text;
                DTOInputScore.Score2 = txtscore2.Text;
                string id = txtid.Text;

                if (BUS_InputScore.EditScore(DTOInputScore, id) == true)
                {
                    MessageBox.Show("Enter Score Success", "Notification");
                    loaddgvscore();
                    return;
                }
                MessageBox.Show("Enter Score Failed", "Notification");
           // }

           // else if (dialogResult == DialogResult.No)
           // {
                //do something else
           // }
            
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtstudentid.Text = "";
            cbsubject.Text = "";
            txtclassid.Text = "";
            txtscore1.Text = "";
            txtscore2.Text = "";
            cbsemester.Text = "";
        }

        private void Btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbsearch.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                txtclassid.Text = cbsearch.SelectedValue.ToString();
                loaddgvscore();
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
            GUI_ManagerRpScore ManagerRpScore = new GUI_ManagerRpScore();
            ManagerRpScore.Show();
            ManagerRpScore.Focus();


        }
    }
}

