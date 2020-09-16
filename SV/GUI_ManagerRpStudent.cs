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
    public partial class GUI_ManagerRpStudent : Form
    {
        public GUI_ManagerRpStudent()
        {
            InitializeComponent();
        }

        private void GUI_ManagerRpStudent_Load(object sender, EventArgs e)
        {
            loadcbclassid();
        }
        private void loadcbclassid()
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            cbclassid.DataSource = listclass;
            cbclassid.DisplayMember = "classid"; // Giá trị hiển thị;
            cbclassid.ValueMember = "classid"; // Giá trị cần lấy;          
        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbclassid.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                GUI_ReportStudent ReportStudent = new GUI_ReportStudent();
                ReportStudent.Message = cbclassid.Text;
                ReportStudent.Show();
                ReportStudent.Focus();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
