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
    public partial class GUI_ReportSubject : Form
    {
        public GUI_ReportSubject()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void conquery()
        {
            CrystalReportSubject rpt = new CrystalReportSubject();
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VLG48MC;Initial Catalog=SQLDBUI;Persist Security Info=True;User ID=sa;Password=123456");
            SqlConnection conn = new SqlConnection(@"Data Source = 192.168.1.2,1433; Initial Catalog = SQLDBUI; User ID = sa; Password = 123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("select * from subjects where credit = '"+txtid.Text+"'", conn);
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

        private void GUI_ReportSubject_Load(object sender, EventArgs e)
        {
            transdata();
            conquery();
        }
    }
}
