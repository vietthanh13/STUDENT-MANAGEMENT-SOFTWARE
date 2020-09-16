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
    public partial class GUI_Class : Form
    {
        public GUI_Class()
        {
            InitializeComponent();
        }

        private void GUI_Class_Load(object sender, EventArgs e)
        {
            loaddgvclass();
            loadcbmajor();
            loadcbtrainsystem();
            loadcbyearofaddmission();
        }
        private void loaddgvclass()
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            dtgvclass.DataSource = listclass;
        }
        private void loadcbmajor()
        {
            List<DTO_Major> listmajor = BUS_Major.loadmajor();
            cbmajorid.DataSource = listmajor;
            cbmajorid.DisplayMember = "majorname"; // Giá trị hiển thị;
            cbmajorid.ValueMember = "majorid"; // Giá trị cần lấy;          
        }
        private void loadcbtrainsystem()
        {
            cbtrainsystem.Items.Add("University");
            cbtrainsystem.Items.Add("College");
        }
        private void loadcbyearofaddmission()
        {
            cbyearofaddmission.Items.Add("2010");
            cbyearofaddmission.Items.Add("2011");
            cbyearofaddmission.Items.Add("2012");
            cbyearofaddmission.Items.Add("2013");
            cbyearofaddmission.Items.Add("2014");
            cbyearofaddmission.Items.Add("2015");
            cbyearofaddmission.Items.Add("2016");
            cbyearofaddmission.Items.Add("2017");
            cbyearofaddmission.Items.Add("2018");
            cbyearofaddmission.Items.Add("2019");
            cbyearofaddmission.Items.Add("2020");
            cbyearofaddmission.Items.Add("2021");
            cbyearofaddmission.Items.Add("2022");
        }

        private void Btadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txtclassid.Text == "" || txtclassname.Text == "" || txtwholesalenumber.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Class DTOClass = new DTO_Class();
                DTOClass.Classid = txtclassid.Text;
                DTOClass.Classname = txtclassname.Text;
                DTOClass.Trainsystem = cbtrainsystem.Text;
                DTOClass.Yearofaddmission = cbyearofaddmission.Text;
                DTOClass.Wholesalenumber = txtwholesalenumber.Text;
                DTOClass.Majorid = cbmajorid.SelectedValue.ToString();
                if (BUS_Class.CheckDup(DTOClass) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Class.InsertClass(DTOClass) == true)
                    {
                        MessageBox.Show("Add Class Success", "Notification");
                        loaddgvclass();
                        return;
                    }
                    MessageBox.Show("Add Class Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

        private void Btedit_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("Class information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txtclassid.Text == "" || txtclassname.Text == "" || cbtrainsystem.Text == "" || cbyearofaddmission.Text == "" || txtwholesalenumber.Text == "" || cbmajorid.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    else
                    {


                        // Đối tượng class trong DTO
                        DTO_Class DTOClass = new DTO_Class();
                        DTOClass.Classid = txtclassid.Text;
                        DTOClass.Classname = txtclassname.Text;
                        DTOClass.Trainsystem = cbtrainsystem.Text;
                        DTOClass.Yearofaddmission = cbyearofaddmission.Text;
                        DTOClass.Wholesalenumber = txtwholesalenumber.Text;
                        DTOClass.Majorid = cbmajorid.SelectedValue.ToString();
                        string id = txtid.Text;
                        if (BUS_Class.EditClassIdSemester(DTOClass, id) == true)
                        {
                            if (BUS_Class.EditClassIdStudent(DTOClass, id) == true)
                            {
                                if (BUS_Class.EditClass(DTOClass, id) == true)
                                {
                                    if (BUS_Class.EditNullClassIdInSemester(DTOClass) == true)
                                    {
                                        if (BUS_Class.EditNullClassIdInStudent(DTOClass) == true)
                                        {
                                            MessageBox.Show("Edit Class Success", "Notification");
                                            loaddgvclass();
                                            return;
                                        }

                                    }
                                }
                            }
                        }
                        MessageBox.Show("Edit Class Failed", "Notification");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dtgvclass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đưa dữ liệu lên datagirdview
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvclass.Rows[index];
                txtclassid.Text = dr.Cells[0].Value.ToString();
                txtclassname.Text = dr.Cells[1].Value.ToString();
                cbtrainsystem.Text = dr.Cells[2].Value.ToString();
                cbyearofaddmission.Text = dr.Cells[3].Value.ToString();
                txtwholesalenumber.Text = dr.Cells[4].Value.ToString();
                cbmajorid.Text = dr.Cells[6].Value.ToString();
                txtid.Text = dr.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Class information will be delete from Database", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txtclassid.Text == "" || txtclassname.Text == "" || cbtrainsystem.Text == "" || cbyearofaddmission.Text == "" || txtwholesalenumber.Text == "" || cbmajorid.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Class DTOClass = new DTO_Class();
                    DTOClass.Classid = txtclassid.Text;
                    DTOClass.Classname = txtclassname.Text;
                    DTOClass.Trainsystem = cbtrainsystem.Text;
                    DTOClass.Yearofaddmission = cbyearofaddmission.Text;
                    DTOClass.Wholesalenumber = txtwholesalenumber.Text;
                    DTOClass.Majorid = cbmajorid.Text;
                    string id = txtid.Text;
                    if (BUS_Class.DeleteSemester(DTOClass,id) == true)
                    {
                        if (BUS_Class.EditClassIdStudent(DTOClass, id) == true)
                        {
                            if (BUS_Class.DeleteClass(DTOClass,id) == true)
                            {
                                MessageBox.Show("Delete Class Success", "Notification");
                                loaddgvclass();
                                return;
                            }
                        }
                        MessageBox.Show("Delete Class Failed", "Notification");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                string id = txtsearch.Text;
                List<DTO_Class> listclass = BUS_Class.searchclass(id);
                dtgvclass.DataSource = listclass;
            }
            catch(Exception ex)
            {

            }
        }

        private void Btshowall_Click(object sender, EventArgs e)
        {
            List<DTO_Class> listclass = BUS_Class.loadclass();
            dtgvclass.DataSource = listclass;
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

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtclassid.Text = "";
            txtclassname.Text = "";
            cbtrainsystem.Text = "";
            cbyearofaddmission.Text = "";
            txtwholesalenumber.Text = "";
            cbmajorid.Text= "";
        }

        private void Cbtrainsystem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btreport_Click(object sender, EventArgs e)
        {
            GUI_ManagerRpClass ManagerRpClass = new GUI_ManagerRpClass();

            ManagerRpClass.Show();
            ManagerRpClass.Focus();
        }
    }
}
