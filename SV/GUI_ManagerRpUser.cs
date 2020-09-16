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
    public partial class GUI_ManagerRpUser : Form
    {
        public GUI_ManagerRpUser()
        {
            InitializeComponent();
        }

        private void GUI_ManagerRpUser_Load(object sender, EventArgs e)
        {
            loadcbauth();
        }
        private void loadcbauth()
        {          
            cbauth.Items.Add("Admin");
            cbauth.Items.Add("User");
            cbauth.Items.Add("Manager");
        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbauth.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                GUI_ReportUser ReportUser = new GUI_ReportUser();
                ReportUser.Message = cbauth.Text;
                ReportUser.Show();
                ReportUser.Focus();
            }
            catch(Exception ex)
            {

            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cbauth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
