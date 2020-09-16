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
    public partial class GUI_ManagerRpScore : Form
    {
        public GUI_ManagerRpScore()
        {
            InitializeComponent();
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
                GUI_ReportScore ReportScore = new GUI_ReportScore();
                ReportScore.Message = cbclassid.Text;
                ReportScore.Show();
                ReportScore.Focus();
            }
            catch(Exception ex)
            {

            }


        }

        private void GUI_ManagerRpScore_Load(object sender, EventArgs e)
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

    }
}
