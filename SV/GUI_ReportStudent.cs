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
    public partial class GUI_ReportStudent : Form
    {
        public GUI_ReportStudent()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void GUI_ReportStudent_Load(object sender, EventArgs e)
        {
                transdata();
                conquery();
        }
        private void conquery()
        {
            CrystalReportStudent rpt = new CrystalReportStudent();
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VLG48MC;Initial Catalog=SQLDBUI;Persist Security Info=True;User ID=sa;Password=123456");
            SqlConnection conn = new SqlConnection(@"Data Source = 192.168.1.2,1433; Initial Catalog = SQLDBUI; User ID = sa; Password = 123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT Student.studentid, Student.firstname, Student.lastname, Student.dayofbirth, Student.sex, Student.placeofbirth, Class.classid, Major.majorid, Major.majorname FROM Student INNER JOIN Class ON Student.classid = Class.classid INNER JOIN Major ON Class.majorid = Major.majorid INNER JOIN Users ON Student.userid = Users.userid where class.classid ='"+txtid.Text+"'", conn);
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
