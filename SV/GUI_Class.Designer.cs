namespace SV
{
    partial class GUI_Class
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtwholesalenumber = new System.Windows.Forms.TextBox();
            this.txtclassname = new System.Windows.Forms.TextBox();
            this.txtclassid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btmanager = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.btshowall = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbyearofaddmission = new System.Windows.Forms.ComboBox();
            this.cbmajorid = new System.Windows.Forms.ComboBox();
            this.cbtrainsystem = new System.Windows.Forms.ComboBox();
            this.dtgvclass = new System.Windows.Forms.DataGridView();
            this.btreport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvclass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(700, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 0;
            this.txtid.Visible = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(176, 400);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(362, 26);
            this.txtsearch.TabIndex = 3;
            // 
            // txtwholesalenumber
            // 
            this.txtwholesalenumber.Location = new System.Drawing.Point(554, 157);
            this.txtwholesalenumber.Name = "txtwholesalenumber";
            this.txtwholesalenumber.Size = new System.Drawing.Size(193, 26);
            this.txtwholesalenumber.TabIndex = 6;
            // 
            // txtclassname
            // 
            this.txtclassname.Location = new System.Drawing.Point(193, 157);
            this.txtclassname.Name = "txtclassname";
            this.txtclassname.Size = new System.Drawing.Size(193, 26);
            this.txtclassname.TabIndex = 3;
            // 
            // txtclassid
            // 
            this.txtclassid.Location = new System.Drawing.Point(193, 111);
            this.txtclassid.Name = "txtclassid";
            this.txtclassid.Size = new System.Drawing.Size(193, 26);
            this.txtclassid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manager Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Major ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "WholeSaleNumber :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "YearOfAddMission :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "TrainSystem :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ClassID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ClassName :";
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(0, 1);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(81, 36);
            this.btmanager.TabIndex = 1;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(604, 400);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(81, 29);
            this.btsearch.TabIndex = 4;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(38, 400);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(81, 29);
            this.btshowall.TabIndex = 2;
            this.btshowall.Text = "Show All";
            this.btshowall.UseVisualStyleBackColor = true;
            this.btshowall.Click += new System.EventHandler(this.Btshowall_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(442, 283);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(81, 29);
            this.btedit.TabIndex = 10;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(615, 283);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(81, 29);
            this.btclear.TabIndex = 11;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(119, 283);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(81, 29);
            this.btadd.TabIndex = 8;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(276, 283);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(81, 29);
            this.btdelete.TabIndex = 9;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.Btdelete_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbyearofaddmission);
            this.panel1.Controls.Add(this.cbmajorid);
            this.panel1.Controls.Add(this.cbtrainsystem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.txtwholesalenumber);
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.txtclassname);
            this.panel1.Controls.Add(this.txtclassid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 341);
            this.panel1.TabIndex = 22;
            // 
            // cbyearofaddmission
            // 
            this.cbyearofaddmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbyearofaddmission.FormattingEnabled = true;
            this.cbyearofaddmission.Location = new System.Drawing.Point(554, 108);
            this.cbyearofaddmission.Name = "cbyearofaddmission";
            this.cbyearofaddmission.Size = new System.Drawing.Size(193, 28);
            this.cbyearofaddmission.TabIndex = 5;
            // 
            // cbmajorid
            // 
            this.cbmajorid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmajorid.FormattingEnabled = true;
            this.cbmajorid.Location = new System.Drawing.Point(554, 210);
            this.cbmajorid.Name = "cbmajorid";
            this.cbmajorid.Size = new System.Drawing.Size(193, 28);
            this.cbmajorid.TabIndex = 7;
            // 
            // cbtrainsystem
            // 
            this.cbtrainsystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrainsystem.FormattingEnabled = true;
            this.cbtrainsystem.Location = new System.Drawing.Point(193, 210);
            this.cbtrainsystem.Name = "cbtrainsystem";
            this.cbtrainsystem.Size = new System.Drawing.Size(193, 28);
            this.cbtrainsystem.TabIndex = 4;
            this.cbtrainsystem.SelectedIndexChanged += new System.EventHandler(this.Cbtrainsystem_SelectedIndexChanged);
            // 
            // dtgvclass
            // 
            this.dtgvclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvclass.Location = new System.Drawing.Point(0, 435);
            this.dtgvclass.Name = "dtgvclass";
            this.dtgvclass.RowTemplate.Height = 28;
            this.dtgvclass.Size = new System.Drawing.Size(800, 318);
            this.dtgvclass.TabIndex = 23;
            this.dtgvclass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvclass_CellClick);
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(82, 2);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(81, 35);
            this.btreport.TabIndex = 24;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // GUI_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.dtgvclass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btmanager);
            this.Controls.Add(this.txtsearch);
            this.MaximumSize = new System.Drawing.Size(822, 809);
            this.MinimumSize = new System.Drawing.Size(822, 809);
            this.Name = "GUI_Class";
            this.Text = "GUI_Class";
            this.Load += new System.EventHandler(this.GUI_Class_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtwholesalenumber;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.TextBox txtclassid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbyearofaddmission;
        private System.Windows.Forms.ComboBox cbmajorid;
        private System.Windows.Forms.ComboBox cbtrainsystem;
        private System.Windows.Forms.DataGridView dtgvclass;
        private System.Windows.Forms.Button btreport;
    }
}