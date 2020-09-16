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
    public partial class GUI_ManagerRpClass : Form
    {
        public GUI_ManagerRpClass()
        {
            InitializeComponent();
        }

        private void GUI_ManagerRpClass_Load(object sender, EventArgs e)
        {
            laodcbclassid();
        }
        private void laodcbclassid()
        {
            List<DTO_Major> listmajor = BUS_Major.loadmajor();
            cbclassid.DataSource = listmajor;
            cbclassid.DisplayMember = "majorid"; // Giá trị hiển thị;
            cbclassid.ValueMember = "majorid"; // Giá trị cần lấy;          
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
                GUI_ReportClass ReportClass = new GUI_ReportClass();
                ReportClass.Message = cbclassid.Text;
                ReportClass.Show();
                ReportClass.Focus();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
