using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SV
{
    public partial class GUI_ManagerRpSubject : Form
    {
        public GUI_ManagerRpSubject()
        {
            InitializeComponent();
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

        private void Btreport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbcredit.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                GUI_ReportSubject ReportSubject = new GUI_ReportSubject();
                ReportSubject.Message = cbcredit.Text;
                ReportSubject.Show();
                ReportSubject.Focus();
            }
            catch(Exception)
            {

            }
        }

        private void GUI_ManagerRpSubject_Load(object sender, EventArgs e)
        {
            loadcbcredit();
        }
    }
}
