namespace SV
{
    partial class GUI_Major
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
            this.btadd = new System.Windows.Forms.Button();
            this.txtmajorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btclear = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmajorid = new System.Windows.Forms.TextBox();
            this.btmanager = new System.Windows.Forms.Button();
            this.dtgvmajor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmajor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(110, 127);
            this.btadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(55, 19);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // txtmajorname
            // 
            this.txtmajorname.Location = new System.Drawing.Point(195, 82);
            this.txtmajorname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmajorname.Name = "txtmajorname";
            this.txtmajorname.Size = new System.Drawing.Size(141, 20);
            this.txtmajorname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager Major";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MajorName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MajorID :";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(277, 127);
            this.btclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(50, 19);
            this.btclear.TabIndex = 5;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(195, 127);
            this.btedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(53, 19);
            this.btedit.TabIndex = 4;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(392, 0);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 20);
            this.txtid.TabIndex = 8;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.Txtid_TextChanged);
            // 
            // txtmajorid
            // 
            this.txtmajorid.Location = new System.Drawing.Point(195, 40);
            this.txtmajorid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmajorid.Name = "txtmajorid";
            this.txtmajorid.Size = new System.Drawing.Size(141, 20);
            this.txtmajorid.TabIndex = 1;
            this.txtmajorid.TextChanged += new System.EventHandler(this.Txtmajorid_TextChanged);
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(1, 0);
            this.btmanager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(63, 19);
            this.btmanager.TabIndex = 1;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // dtgvmajor
            // 
            this.dtgvmajor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvmajor.Location = new System.Drawing.Point(1, 192);
            this.dtgvmajor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvmajor.Name = "dtgvmajor";
            this.dtgvmajor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvmajor.RowTemplate.Height = 28;
            this.dtgvmajor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvmajor.Size = new System.Drawing.Size(458, 246);
            this.dtgvmajor.TabIndex = 11;
            this.dtgvmajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvmajor_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.txtmajorname);
            this.panel1.Controls.Add(this.txtmajorid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Location = new System.Drawing.Point(1, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 168);
            this.panel1.TabIndex = 2;
            // 
            // GUI_Major
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(463, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvmajor);
            this.Controls.Add(this.btmanager);
            this.Controls.Add(this.txtid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(479, 482);
            this.MinimumSize = new System.Drawing.Size(479, 482);
            this.Name = "GUI_Major";
            this.Text = "GUI_Major";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_Major_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Major_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmajor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtmajorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmajorid;
        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.DataGridView dtgvmajor;
        private System.Windows.Forms.Panel panel1;
    }
}