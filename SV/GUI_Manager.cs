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
    public partial class GUI_Manager : Form
    {
        public GUI_Manager()
        {
            InitializeComponent();
        }

        private void Btaddsubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Subject>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Subject Subject = new GUI_Subject();
                    Subject.Show();
                    Subject.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void Btaddmajor_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Major>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Major Major = new GUI_Major();
                    Major.Show();
                    Major.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void Btaddclass_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Class>().Any())
                {
                   
                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Class Class = new GUI_Class();
                    Class.Show();
                    Class.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Btaddscore_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_InputScore>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_InputScore InputScore = new GUI_InputScore();
                    InputScore.Show();
                    InputScore.Focus();
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        private void Btaddstudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Student>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Student Student = new GUI_Student();
                    Student.Show();
                    Student.Focus();
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit ?", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GUI_Manager Manager = new GUI_Manager();
                this.Close();

                GUI_Login Login = new GUI_Login();               
                Login.Show();
                Login.Focus();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btaddsemester_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<GUI_Semester>().Any())
                {

                    MessageBox.Show("Form is opened");
                }
                else
                {
                    GUI_Semester Semester = new GUI_Semester();
                    Semester.Show();
                    Semester.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void GUI_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI_Manager Manager = new GUI_Manager();
            Manager.Close();
        }
    }
}
