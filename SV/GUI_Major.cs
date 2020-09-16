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
    public partial class GUI_Major : Form
    {
        public GUI_Major()
        {
            InitializeComponent();
        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_Major_Load(object sender, EventArgs e)
        {
            Loaddgvmajor();
        }
        private void Loaddgvmajor()
        {
            List<DTO_Major> listmajor = BUS_Major.loadmajor();
            dtgvmajor.DataSource = listmajor;
        }

        private void Btadd_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (txtmajorid.Text == "" || txtmajorname.Text == "")
            {
                MessageBox.Show("All Fields Are Compulsory");
                return;
            }
            // Đối tượng class trong DTO
            DTO_Major DTOMajor = new DTO_Major();
            DTOMajor.Majorid = txtmajorid.Text;
            DTOMajor.Majorname = txtmajorname.Text;
            if (BUS_Major.CheckDup(DTOMajor) == true)
            {
                MessageBox.Show("The data you entered already exists");
            }
            else
            {
                if (BUS_Major.InsertMajor(DTOMajor) == true)
                {
                    MessageBox.Show("Add Major Success", "Notification");
                    Loaddgvmajor();
                    return;
                }
                MessageBox.Show("Add Major Failed", "Notification");
            }
        }
        private void Dtgvmajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Đưa dữ liệu lên datagirdview
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvmajor.Rows[index];
                txtmajorid.Text = dr.Cells[0].Value.ToString();
                txtmajorname.Text = dr.Cells[1].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Btedit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Major information will be changed", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtmajorid.Text == "" || txtmajorname.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Major DTOMajor = new DTO_Major();
                DTOMajor.Majorid = txtmajorid.Text;
                DTOMajor.Majorname = txtmajorname.Text;
                string id = txtid.Text;
                if (BUS_Major.EditMajorIdInClass(DTOMajor, id) == true)
                {
                    if (BUS_Major.EditMajor(DTOMajor, id) == true)
                    {
                        if (BUS_Major.EditNullMajorIdInClass(DTOMajor) == true)
                        {
                            MessageBox.Show("Edit Major Success", "Notification");
                            Loaddgvmajor();
                            return;
                        }
                    }
                }
                MessageBox.Show("Edit Major Failed", "Notification");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtmajorid.Text = "";
            txtmajorname.Text = "";

        }

        private void Btmanager_Click(object sender, EventArgs e)
        {
            try
            {
                GUI_Manager Manager = new GUI_Manager();
                if (Application.OpenForms.OfType<GUI_Manager>().Any())
                {

                    MessageBox.Show("Form is opened");
                    Manager.Focus();
                }
                else
                {               
                    Manager.Show();
                    Manager.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void GUI_Major_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI_Major Major = new GUI_Major();
            Major.Close();
        }

        private void Txtmajorid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
