namespace SV
{
    partial class GUI_Semester
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
            this.btmanager = new System.Windows.Forms.Button();
            this.dgvsemester = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btedit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.cbsubjectid = new System.Windows.Forms.ComboBox();
            this.cbclassid = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btshowall = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.txtid2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsemester)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(2, -1);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(91, 36);
            this.btmanager.TabIndex = 0;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // dgvsemester
            // 
            this.dgvsemester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsemester.Location = new System.Drawing.Point(2, 406);
            this.dgvsemester.Name = "dgvsemester";
            this.dgvsemester.RowTemplate.Height = 28;
            this.dgvsemester.Size = new System.Drawing.Size(545, 280);
            this.dgvsemester.TabIndex = 2;
            this.dgvsemester.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvsemester_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SubjectID :";
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(369, 229);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(77, 38);
            this.btedit.TabIndex = 5;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ClassID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Semester :";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(238, 229);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(77, 38);
            this.btdelete.TabIndex = 9;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.Btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(110, 229);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(77, 38);
            this.btadd.TabIndex = 10;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // cbsubjectid
            // 
            this.cbsubjectid.FormattingEnabled = true;
            this.cbsubjectid.Location = new System.Drawing.Point(266, 69);
            this.cbsubjectid.Name = "cbsubjectid";
            this.cbsubjectid.Size = new System.Drawing.Size(121, 28);
            this.cbsubjectid.TabIndex = 11;
            // 
            // cbclassid
            // 
            this.cbclassid.FormattingEnabled = true;
            this.cbclassid.Location = new System.Drawing.Point(266, 119);
            this.cbclassid.Name = "cbclassid";
            this.cbclassid.Size = new System.Drawing.Size(121, 28);
            this.cbclassid.TabIndex = 12;
            // 
            // cbsemester
            // 
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Location = new System.Drawing.Point(266, 169);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(121, 28);
            this.cbsemester.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbclassid);
            this.panel1.Controls.Add(this.cbsemester);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbsubjectid);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 292);
            this.panel1.TabIndex = 14;
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(2, 350);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(77, 38);
            this.btshowall.TabIndex = 14;
            this.btshowall.Text = "Show All";
            this.btshowall.UseVisualStyleBackColor = true;
            this.btshowall.Click += new System.EventHandler(this.Btshowall_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(114, 356);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(251, 26);
            this.txtsearch.TabIndex = 15;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(391, 350);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(87, 38);
            this.btsearch.TabIndex = 14;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(139, 4);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(51, 26);
            this.txtid1.TabIndex = 16;
            this.txtid1.Visible = false;
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(212, 4);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(51, 26);
            this.txtid2.TabIndex = 17;
            this.txtid2.Visible = false;
            // 
            // GUI_Semester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(547, 687);
            this.Controls.Add(this.txtid2);
            this.Controls.Add(this.txtid1);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvsemester);
            this.Controls.Add(this.btmanager);
            this.MaximumSize = new System.Drawing.Size(569, 743);
            this.MinimumSize = new System.Drawing.Size(569, 743);
            this.Name = "GUI_Semester";
            this.Text = "GUI_Semester";
            this.Load += new System.EventHandler(this.GUI_Semester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsemester)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.DataGridView dgvsemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.ComboBox cbsubjectid;
        private System.Windows.Forms.ComboBox cbclassid;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.TextBox txtid2;
    }
}