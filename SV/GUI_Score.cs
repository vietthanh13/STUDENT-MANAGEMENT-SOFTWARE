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
    public partial class GUI_Score : Form
    {
        private string _getdata;
        private string _getdata1;
        public string Getdata
        {
            get { return _getdata; }
            set { _getdata = value; }
        }
        public string Getdata1
        {
            get { return _getdata1; }
            set { _getdata1 = value; }
        }
        public GUI_Score()
        {
            InitializeComponent();
        }

        private void GUI_Score_Load(object sender, EventArgs e)
        {
            try
            {
                txtgetstudentid.Text = _getdata; // lấy dữ liệu student id từ Form User 
                txtgetdatausername.Text = _getdata1; //// lấy dữ liệu username từ Form User 
                loaddgvscore();
                dgvscore.Columns[0].Width = 108;
                dgvscore.Columns[2].Width = 150;
            }
            catch(Exception ex)
            {

            }
        }
        private void loaddgvscore()
        {
            string id = txtgetstudentid.Text;
            List<DTO_Score> listscore = BUS_Score.loadscore(id);
            dgvscore.DataSource = listscore;
        }

        private void Btsearch_Click(object sender, EventArgs e)
        {
            string id = txtsearch.Text;
            List<DTO_Score> listscore = BUS_Score.loadscore(id);
            dgvscore.DataSource = listscore;
        }

        private void Btviewmyscore_Click(object sender, EventArgs e)
        {
            string id = txtgetstudentid.Text; 
            List<DTO_Score> listscore = BUS_Score.loadscore(id);
            dgvscore.DataSource = listscore;
        }

        private void Txtback_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (Application.OpenForms.OfType<GUI_User>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Score Score = new GUI_Score();
                    Score.Close();
                    GUI_User User = new GUI_User();
                    User.Message1 = txtgetdatausername.Text; // đưa dữ liệu username cho form user
                    User.Show();
                    User.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
