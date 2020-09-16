using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SV
{
    public partial class GUI_ReportUser : Form
    {

        public GUI_ReportUser()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void GUI_ReportUser_Load(object sender, EventArgs e)
        {
            transdata();
            conquery();

        }
        private void conquery()
        {
            CrystalReportUser rpt = new CrystalReportUser();
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VLG48MC;Initial Catalog=SQLDBUI;Persist Security Info=True;User ID=sa;Password=123456");
            SqlConnection conn = new SqlConnection(@"Data Source = 192.168.1.2,1433; Initial Catalog = SQLDBUI; User ID = sa; Password = 123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from users where auth = '" + txtauth.Text + "'", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
            conn.Close();
        }
        private void transdata()
        {
            txtauth.Text = _message;
        }

        private void CrystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void Reportview1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
