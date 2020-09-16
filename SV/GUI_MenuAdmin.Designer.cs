namespace SV
{
    partial class GUI_MenuAdmin
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdisable = new System.Windows.Forms.Button();
            this.txtenable = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.cbauth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btshowall = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.btreport = new System.Windows.Forms.Button();
            this.txtcheckstatus = new System.Windows.Forms.TextBox();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(0, 0);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(80, 32);
            this.btlogout.TabIndex = 1;
            this.btlogout.Text = "LogOut";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.Btlogout_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(152, 518);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(300, 26);
            this.txtsearch.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtdisable);
            this.panel1.Controls.Add(this.txtenable);
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtuserid);
            this.panel1.Controls.Add(this.cbauth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 457);
            this.panel1.TabIndex = 3;
            // 
            // txtdisable
            // 
            this.txtdisable.Location = new System.Drawing.Point(270, 390);
            this.txtdisable.Name = "txtdisable";
            this.txtdisable.Size = new System.Drawing.Size(148, 32);
            this.txtdisable.TabIndex = 12;
            this.txtdisable.Text = "Disable Account";
            this.txtdisable.UseVisualStyleBackColor = true;
            this.txtdisable.Click += new System.EventHandler(this.Txtdisable_Click);
            // 
            // txtenable
            // 
            this.txtenable.Location = new System.Drawing.Point(79, 390);
            this.txtenable.Name = "txtenable";
            this.txtenable.Size = new System.Drawing.Size(143, 32);
            this.txtenable.TabIndex = 11;
            this.txtenable.Text = "Enable Account";
            this.txtenable.UseVisualStyleBackColor = true;
            this.txtenable.Click += new System.EventHandler(this.Txtenable_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(486, 390);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(80, 32);
            this.btclear.TabIndex = 8;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(111, 329);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(80, 32);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(303, 329);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(80, 32);
            this.btdelete.TabIndex = 6;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.Btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(486, 329);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(80, 32);
            this.btedit.TabIndex = 7;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(263, 209);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(283, 26);
            this.txtpassword.TabIndex = 3;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(263, 158);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(283, 26);
            this.txtusername.TabIndex = 2;
            // 
            // txtuserid
            // 
            this.txtuserid.Enabled = false;
            this.txtuserid.Location = new System.Drawing.Point(263, 103);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(283, 26);
            this.txtuserid.TabIndex = 1;
            // 
            // cbauth
            // 
            this.cbauth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbauth.FormattingEnabled = true;
            this.cbauth.Location = new System.Drawing.Point(263, 257);
            this.cbauth.Name = "cbauth";
            this.cbauth.Size = new System.Drawing.Size(152, 28);
            this.cbauth.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Authirities :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager Users";
            // 
            // dgvuser
            // 
            this.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(0, 566);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowTemplate.Height = 28;
            this.dgvuser.Size = new System.Drawing.Size(677, 333);
            this.dgvuser.TabIndex = 4;
            this.dgvuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvuser_CellClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(667, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(10, 26);
            this.txtid.TabIndex = 5;
            this.txtid.Visible = false;
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(28, 515);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(104, 32);
            this.btshowall.TabIndex = 2;
            this.btshowall.Text = "Show All";
            this.btshowall.UseVisualStyleBackColor = true;
            this.btshowall.Click += new System.EventHandler(this.Btshowall_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(476, 515);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(104, 32);
            this.btsearch.TabIndex = 4;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(80, 0);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(83, 32);
            this.btreport.TabIndex = 6;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // txtcheckstatus
            // 
            this.txtcheckstatus.Enabled = false;
            this.txtcheckstatus.Location = new System.Drawing.Point(667, 0);
            this.txtcheckstatus.Name = "txtcheckstatus";
            this.txtcheckstatus.Size = new System.Drawing.Size(10, 26);
            this.txtcheckstatus.TabIndex = 9;
            this.txtcheckstatus.Visible = false;
            // 
            // txtpass1
            // 
            this.txtpass1.Location = new System.Drawing.Point(667, 0);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(10, 26);
            this.txtpass1.TabIndex = 10;
            this.txtpass1.Visible = false;
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(667, 0);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(10, 26);
            this.txtpass2.TabIndex = 11;
            this.txtpass2.Visible = false;
            // 
            // GUI_MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(678, 899);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.txtpass1);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtcheckstatus);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btlogout);
            this.MaximumSize = new System.Drawing.Size(700, 955);
            this.MinimumSize = new System.Drawing.Size(700, 955);
            this.Name = "GUI_MenuAdmin";
            this.Text = "GUI_MenuAdmin";
            this.Load += new System.EventHandler(this.GUI_MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.ComboBox cbauth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.TextBox txtcheckstatus;
        private System.Windows.Forms.Button txtdisable;
        private System.Windows.Forms.Button txtenable;
        private System.Windows.Forms.TextBox txtpass1;
        private System.Windows.Forms.TextBox txtpass2;
    }
}