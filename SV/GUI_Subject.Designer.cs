namespace SV
{
    partial class GUI_Subject
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
            this.txtsubjectname = new System.Windows.Forms.TextBox();
            this.txtsubjectid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcredit = new System.Windows.Forms.ComboBox();
            this.btadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvsubject = new System.Windows.Forms.DataGridView();
            this.btmanager = new System.Windows.Forms.Button();
            this.btshowall = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.txtsubjectname);
            this.panel1.Controls.Add(this.txtsubjectid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbcredit);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 317);
            this.panel1.TabIndex = 0;
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(457, 243);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(78, 33);
            this.btclear.TabIndex = 7;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(343, 243);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(78, 33);
            this.btedit.TabIndex = 6;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(225, 243);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(78, 33);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.Btdelete_Click);
            // 
            // txtsubjectname
            // 
            this.txtsubjectname.Location = new System.Drawing.Point(247, 127);
            this.txtsubjectname.Name = "txtsubjectname";
            this.txtsubjectname.Size = new System.Drawing.Size(251, 26);
            this.txtsubjectname.TabIndex = 2;
            // 
            // txtsubjectid
            // 
            this.txtsubjectid.Location = new System.Drawing.Point(247, 84);
            this.txtsubjectid.Name = "txtsubjectid";
            this.txtsubjectid.Size = new System.Drawing.Size(251, 26);
            this.txtsubjectid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Credit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SubjectName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SubjectID :";
            // 
            // cbcredit
            // 
            this.cbcredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcredit.FormattingEnabled = true;
            this.cbcredit.Location = new System.Drawing.Point(247, 169);
            this.cbcredit.Name = "cbcredit";
            this.cbcredit.Size = new System.Drawing.Size(121, 28);
            this.cbcredit.TabIndex = 3;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(105, 243);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(78, 33);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager Subject";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(105, 378);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(364, 26);
            this.txtsearch.TabIndex = 3;
            // 
            // dgvsubject
            // 
            this.dgvsubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubject.Location = new System.Drawing.Point(-1, 431);
            this.dgvsubject.Name = "dgvsubject";
            this.dgvsubject.RowTemplate.Height = 28;
            this.dgvsubject.Size = new System.Drawing.Size(614, 333);
            this.dgvsubject.TabIndex = 5;
            this.dgvsubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvsubject_CellClick);
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(-1, 0);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(100, 33);
            this.btmanager.TabIndex = 1;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(12, 375);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(87, 33);
            this.btshowall.TabIndex = 2;
            this.btshowall.Text = "Show All";
            this.btshowall.UseVisualStyleBackColor = true;
            this.btshowall.Click += new System.EventHandler(this.Btshowall_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(493, 375);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(86, 33);
            this.btsearch.TabIndex = 4;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(527, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 26);
            this.txtid.TabIndex = 11;
            this.txtid.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GUI_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(615, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.btmanager);
            this.Controls.Add(this.dgvsubject);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(637, 822);
            this.MinimumSize = new System.Drawing.Size(637, 822);
            this.Name = "GUI_Subject";
            this.Text = "GUI_Subject";
            this.Load += new System.EventHandler(this.GUI_Subject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtsubjectname;
        private System.Windows.Forms.TextBox txtsubjectid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcredit;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvsubject;
        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
    }
}