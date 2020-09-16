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
    public partial class GUI_ReportClass : Form
    {
        public GUI_ReportClass()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void GUI_ReportClass_Load(object sender, EventArgs e)
        {
            transdata();
            conquery();

        }
        private void conquery()
        {
            CrystalReportClass rpt = new CrystalReportClass();
           // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VLG48MC;Initial Catalog=SQLDBUI;Persist Security Info=True;User ID=sa;Password=123456");
            SqlConnection conn = new SqlConnection(@"Data Source = 192.168.1.2,1433; Initial Catalog = SQLDBUI; User ID = sa; Password = 123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from class where majorid = '"+ txtid.Text +"'", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
            conn.Close();
        }
        private void transdata()
        {
            txtid.Text = _message;
        }
    }
}
