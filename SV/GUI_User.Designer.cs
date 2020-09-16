namespace SV
{
    partial class GUI_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmajor = new System.Windows.Forms.TextBox();
            this.txtclassid = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtplaceofbirth = new System.Windows.Forms.TextBox();
            this.txtdayofbirth = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgetusername = new System.Windows.Forms.TextBox();
            this.txtauth = new System.Windows.Forms.TextBox();
            this.btviewscore = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btregistersubject = new System.Windows.Forms.Button();
            this.btpass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(1, 0);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(81, 31);
            this.btlogout.TabIndex = 1;
            this.btlogout.Text = "Log-Out";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.Btlogout_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtmajor);
            this.panel1.Controls.Add(this.txtclassid);
            this.panel1.Controls.Add(this.txtsex);
            this.panel1.Controls.Add(this.txtplaceofbirth);
            this.panel1.Controls.Add(this.txtdayofbirth);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.txtstudentid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 237);
            this.panel1.TabIndex = 1;
            // 
            // txtmajor
            // 
            this.txtmajor.Enabled = false;
            this.txtmajor.Location = new System.Drawing.Point(895, 124);
            this.txtmajor.Name = "txtmajor";
            this.txtmajor.Size = new System.Drawing.Size(206, 26);
            this.txtmajor.TabIndex = 21;
            // 
            // txtclassid
            // 
            this.txtclassid.Enabled = false;
            this.txtclassid.Location = new System.Drawing.Point(895, 66);
            this.txtclassid.Name = "txtclassid";
            this.txtclassid.Size = new System.Drawing.Size(206, 26);
            this.txtclassid.TabIndex = 20;
            // 
            // txtsex
            // 
            this.txtsex.Enabled = false;
            this.txtsex.Location = new System.Drawing.Point(539, 182);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(206, 26);
            this.txtsex.TabIndex = 19;
            // 
            // txtplaceofbirth
            // 
            this.txtplaceofbirth.Enabled = false;
            this.txtplaceofbirth.Location = new System.Drawing.Point(539, 124);
            this.txtplaceofbirth.Name = "txtplaceofbirth";
            this.txtplaceofbirth.Size = new System.Drawing.Size(206, 26);
            this.txtplaceofbirth.TabIndex = 18;
            // 
            // txtdayofbirth
            // 
            this.txtdayofbirth.Enabled = false;
            this.txtdayofbirth.Location = new System.Drawing.Point(539, 66);
            this.txtdayofbirth.Name = "txtdayofbirth";
            this.txtdayofbirth.Size = new System.Drawing.Size(206, 26);
            this.txtdayofbirth.TabIndex = 17;
            // 
            // txtlastname
            // 
            this.txtlastname.Enabled = false;
            this.txtlastname.Location = new System.Drawing.Point(147, 182);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(206, 26);
            this.txtlastname.TabIndex = 16;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Enabled = false;
            this.txtfirstname.Location = new System.Drawing.Point(147, 124);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(206, 26);
            this.txtfirstname.TabIndex = 15;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Enabled = false;
            this.txtstudentid.Location = new System.Drawing.Point(147, 66);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(206, 26);
            this.txtstudentid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Major";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(810, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "ClassID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "PlaceOfBirth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "DayOfBirth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "LastName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "StudentID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Information";
            // 
            // txtgetusername
            // 
            this.txtgetusername.Location = new System.Drawing.Point(204, -2);
            this.txtgetusername.Name = "txtgetusername";
            this.txtgetusername.Size = new System.Drawing.Size(100, 26);
            this.txtgetusername.TabIndex = 4;
            this.txtgetusername.Visible = false;
            // 
            // txtauth
            // 
            this.txtauth.Location = new System.Drawing.Point(310, -2);
            this.txtauth.Name = "txtauth";
            this.txtauth.Size = new System.Drawing.Size(100, 26);
            this.txtauth.TabIndex = 5;
            this.txtauth.Visible = false;
            // 
            // btviewscore
            // 
            this.btviewscore.Location = new System.Drawing.Point(40, 292);
            this.btviewscore.Name = "btviewscore";
            this.btviewscore.Size = new System.Drawing.Size(131, 70);
            this.btviewscore.TabIndex = 2;
            this.btviewscore.Text = "View Score";
            this.btviewscore.UseVisualStyleBackColor = true;
            this.btviewscore.Click += new System.EventHandler(this.Btviewscore_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(425, 12);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowTemplate.Height = 28;
            this.dgvuser.Size = new System.Drawing.Size(10, 10);
            this.dgvuser.TabIndex = 7;
            this.dgvuser.Visible = false;
            this.dgvuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvuser_CellClick);
            // 
            // btregistersubject
            // 
            this.btregistersubject.Location = new System.Drawing.Point(224, 292);
            this.btregistersubject.Name = "btregistersubject";
            this.btregistersubject.Size = new System.Drawing.Size(131, 70);
            this.btregistersubject.TabIndex = 8;
            this.btregistersubject.Text = "Register Subject";
            this.btregistersubject.UseVisualStyleBackColor = true;
            this.btregistersubject.Click += new System.EventHandler(this.Btregistersubject_Click);
            // 
            // btpass
            // 
            this.btpass.Location = new System.Drawing.Point(409, 292);
            this.btpass.Name = "btpass";
            this.btpass.Size = new System.Drawing.Size(124, 70);
            this.btpass.TabIndex = 9;
            this.btpass.Text = "Change Password";
            this.btpass.UseVisualStyleBackColor = true;
            this.btpass.Click += new System.EventHandler(this.Btpass_Click);
            // 
            // GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1193, 401);
            this.Controls.Add(this.btpass);
            this.Controls.Add(this.btregistersubject);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.btviewscore);
            this.Controls.Add(this.txtauth);
            this.Controls.Add(this.txtgetusername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlogout);
            this.MaximumSize = new System.Drawing.Size(1215, 457);
            this.MinimumSize = new System.Drawing.Size(1215, 457);
            this.Name = "GUI_User";
            this.Text = "GUI_User";
            this.Load += new System.EventHandler(this.GUI_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmajor;
        private System.Windows.Forms.TextBox txtclassid;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtplaceofbirth;
        private System.Windows.Forms.TextBox txtdayofbirth;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgetusername;
        private System.Windows.Forms.TextBox txtauth;
        private System.Windows.Forms.Button btviewscore;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.Button btregistersubject;
        private System.Windows.Forms.Button btpass;
    }
}