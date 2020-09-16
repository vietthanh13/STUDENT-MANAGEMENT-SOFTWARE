namespace SV
{
    partial class GUI_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtcheckadmin = new System.Windows.Forms.TextBox();
            this.txtcheckuser = new System.Windows.Forms.TextBox();
            this.txtcheckmanager = new System.Windows.Forms.TextBox();
            this.btexit = new System.Windows.Forms.Button();
            this.txtenable = new System.Windows.Forms.TextBox();
            this.txtdisable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(87, 179);
            this.btlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(65, 27);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "Log-in";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.Btlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(162, 133);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(131, 20);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Passwords :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(162, 81);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(131, 20);
            this.txtusername.TabIndex = 0;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtusername_KeyPress);
            // 
            // txtcheckadmin
            // 
            this.txtcheckadmin.Location = new System.Drawing.Point(27, 11);
            this.txtcheckadmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtcheckadmin.Name = "txtcheckadmin";
            this.txtcheckadmin.Size = new System.Drawing.Size(67, 20);
            this.txtcheckadmin.TabIndex = 0;
            this.txtcheckadmin.Text = "admin";
            this.txtcheckadmin.Visible = false;
            // 
            // txtcheckuser
            // 
            this.txtcheckuser.Location = new System.Drawing.Point(209, 38);
            this.txtcheckuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtcheckuser.Name = "txtcheckuser";
            this.txtcheckuser.Size = new System.Drawing.Size(71, 20);
            this.txtcheckuser.TabIndex = 0;
            this.txtcheckuser.Text = "user";
            this.txtcheckuser.Visible = false;
            this.txtcheckuser.TextChanged += new System.EventHandler(this.Txtcheckuser_TextChanged);
            // 
            // txtcheckmanager
            // 
            this.txtcheckmanager.Location = new System.Drawing.Point(244, 27);
            this.txtcheckmanager.Margin = new System.Windows.Forms.Padding(2);
            this.txtcheckmanager.Name = "txtcheckmanager";
            this.txtcheckmanager.Size = new System.Drawing.Size(97, 20);
            this.txtcheckmanager.TabIndex = 0;
            this.txtcheckmanager.Text = "manager";
            this.txtcheckmanager.Visible = false;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(209, 179);
            this.btexit.Margin = new System.Windows.Forms.Padding(2);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(69, 27);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.Btexit_Click);
            // 
            // txtenable
            // 
            this.txtenable.Location = new System.Drawing.Point(222, 60);
            this.txtenable.Margin = new System.Windows.Forms.Padding(2);
            this.txtenable.Name = "txtenable";
            this.txtenable.Size = new System.Drawing.Size(75, 20);
            this.txtenable.TabIndex = 2;
            this.txtenable.Text = "Enable";
            this.txtenable.Visible = false;
            this.txtenable.TextChanged += new System.EventHandler(this.Txtenable_TextChanged);
            // 
            // txtdisable
            // 
            this.txtdisable.Location = new System.Drawing.Point(54, 37);
            this.txtdisable.Margin = new System.Windows.Forms.Padding(2);
            this.txtdisable.Name = "txtdisable";
            this.txtdisable.Size = new System.Drawing.Size(104, 20);
            this.txtdisable.TabIndex = 3;
            this.txtdisable.Text = "Disable";
            this.txtdisable.Visible = false;
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(365, 251);
            this.Controls.Add(this.txtdisable);
            this.Controls.Add(this.txtenable);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.txtcheckmanager);
            this.Controls.Add(this.txtcheckuser);
            this.Controls.Add(this.txtcheckadmin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(381, 290);
            this.MinimumSize = new System.Drawing.Size(381, 290);
            this.Name = "GUI_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_Login_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GUI_Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtcheckadmin;
        private System.Windows.Forms.TextBox txtcheckuser;
        private System.Windows.Forms.TextBox txtcheckmanager;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox txtenable;
        private System.Windows.Forms.TextBox txtdisable;
    }
}