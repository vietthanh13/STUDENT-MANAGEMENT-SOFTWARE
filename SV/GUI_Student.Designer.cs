namespace SV
{
    partial class GUI_Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btclear = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.cbclassid = new System.Windows.Forms.ComboBox();
            this.txtplaceofbirth = new System.Windows.Forms.TextBox();
            this.txtdayofbirth = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btshowall = new System.Windows.Forms.Button();
            this.btmanager = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvaccount = new System.Windows.Forms.DataGridView();
            this.dgvclass = new System.Windows.Forms.DataGridView();
            this.btreport = new System.Windows.Forms.Button();
            this.dgvstudentnull = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentnull)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.cbclassid);
            this.panel1.Controls.Add(this.txtplaceofbirth);
            this.panel1.Controls.Add(this.txtdayofbirth);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.cbsex);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.txtstudentid);
            this.panel1.Controls.Add(this.txtuserid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 369);
            this.panel1.TabIndex = 0;
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(772, 298);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(100, 36);
            this.btclear.TabIndex = 21;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(567, 298);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(100, 36);
            this.btedit.TabIndex = 20;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(374, 298);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(100, 36);
            this.btdelete.TabIndex = 19;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.Btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(169, 298);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(100, 36);
            this.btadd.TabIndex = 6;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // cbclassid
            // 
            this.cbclassid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassid.FormattingEnabled = true;
            this.cbclassid.Location = new System.Drawing.Point(812, 154);
            this.cbclassid.Name = "cbclassid";
            this.cbclassid.Size = new System.Drawing.Size(180, 28);
            this.cbclassid.TabIndex = 18;
            // 
            // txtplaceofbirth
            // 
            this.txtplaceofbirth.Location = new System.Drawing.Point(812, 95);
            this.txtplaceofbirth.Name = "txtplaceofbirth";
            this.txtplaceofbirth.Size = new System.Drawing.Size(180, 26);
            this.txtplaceofbirth.TabIndex = 6;
            // 
            // txtdayofbirth
            // 
            this.txtdayofbirth.Location = new System.Drawing.Point(463, 213);
            this.txtdayofbirth.Name = "txtdayofbirth";
            this.txtdayofbirth.Size = new System.Drawing.Size(180, 26);
            this.txtdayofbirth.TabIndex = 17;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(463, 95);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(180, 26);
            this.txtlastname.TabIndex = 16;
            // 
            // cbsex
            // 
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(463, 154);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(180, 28);
            this.cbsex.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(138, 213);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(180, 26);
            this.txtfirstname.TabIndex = 15;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(138, 154);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(180, 26);
            this.txtstudentid.TabIndex = 14;
            // 
            // txtuserid
            // 
            this.txtuserid.Enabled = false;
            this.txtuserid.Location = new System.Drawing.Point(138, 95);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(180, 26);
            this.txtuserid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(705, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "ClassID :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(705, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "PlaceOfbirth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "DayOfBirth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sex :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "LastName :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "FirstName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "StudentID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Information Student";
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(277, 1);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(44, 26);
            this.txtid1.TabIndex = 23;
            this.txtid1.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(228, 1);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(44, 26);
            this.txtid.TabIndex = 22;
            this.txtid.Visible = false;
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(12, 438);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(100, 36);
            this.btshowall.TabIndex = 2;
            this.btshowall.Text = "ShowAll";
            this.btshowall.UseVisualStyleBackColor = true;
            this.btshowall.Click += new System.EventHandler(this.Btshowall_Click);
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(2, 1);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(100, 40);
            this.btmanager.TabIndex = 4;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(204, 443);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(404, 26);
            this.txtsearch.TabIndex = 5;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(652, 438);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(100, 36);
            this.btsearch.TabIndex = 6;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // dgvstudent
            // 
            this.dgvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(2, 502);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowTemplate.Height = 28;
            this.dgvstudent.Size = new System.Drawing.Size(1508, 256);
            this.dgvstudent.TabIndex = 7;
            this.dgvstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvstudent_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1112, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Account has not yet linked";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1222, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "List Class";
            // 
            // dgvaccount
            // 
            this.dgvaccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccount.Location = new System.Drawing.Point(1080, 77);
            this.dgvaccount.Name = "dgvaccount";
            this.dgvaccount.RowTemplate.Height = 28;
            this.dgvaccount.Size = new System.Drawing.Size(423, 168);
            this.dgvaccount.TabIndex = 25;
            this.dgvaccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvaccount_CellClick);
            // 
            // dgvclass
            // 
            this.dgvclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclass.Location = new System.Drawing.Point(1080, 294);
            this.dgvclass.Name = "dgvclass";
            this.dgvclass.RowTemplate.Height = 28;
            this.dgvclass.Size = new System.Drawing.Size(423, 169);
            this.dgvclass.TabIndex = 26;
            this.dgvclass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvclass_CellClick);
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(108, 1);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(100, 40);
            this.btreport.TabIndex = 27;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // dgvstudentnull
            // 
            this.dgvstudentnull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudentnull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudentnull.Location = new System.Drawing.Point(2, 822);
            this.dgvstudentnull.Name = "dgvstudentnull";
            this.dgvstudentnull.RowTemplate.Height = 28;
            this.dgvstudentnull.Size = new System.Drawing.Size(1508, 214);
            this.dgvstudentnull.TabIndex = 28;
            this.dgvstudentnull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvstudentnull_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(493, 776);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 32);
            this.label12.TabIndex = 29;
            this.label12.Text = "List Student has not UserID or ClassID";
            // 
            // GUI_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1513, 926);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvstudentnull);
            this.Controls.Add(this.txtid1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.dgvclass);
            this.Controls.Add(this.dgvaccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btmanager);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Student";
            this.Load += new System.EventHandler(this.GUI_Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentnull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.TextBox txtplaceofbirth;
        private System.Windows.Forms.TextBox txtdayofbirth;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbclassid;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvaccount;
        private System.Windows.Forms.DataGridView dgvclass;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.DataGridView dgvstudentnull;
        private System.Windows.Forms.Label label12;
    }
}