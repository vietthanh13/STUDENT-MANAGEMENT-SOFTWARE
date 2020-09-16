namespace SV
{
    partial class GUI_Pass
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
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btedit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtoldpass
            // 
            this.txtoldpass.Location = new System.Drawing.Point(268, 56);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.PasswordChar = '*';
            this.txtoldpass.Size = new System.Drawing.Size(188, 26);
            this.txtoldpass.TabIndex = 0;
            this.txtoldpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtoldpass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password :";
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(189, 257);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(152, 37);
            this.btedit.TabIndex = 1;
            this.btedit.Text = "Change Password";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password :";
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(268, 187);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '*';
            this.txtconfirmpass.Size = new System.Drawing.Size(188, 26);
            this.txtconfirmpass.TabIndex = 1;
            this.txtconfirmpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtconfirmpass_KeyPress);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(1, 0);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(103, 26);
            this.txtusername.TabIndex = 7;
            this.txtusername.Visible = false;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(268, 123);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(188, 26);
            this.txtnewpass.TabIndex = 1;
            this.txtnewpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnewpass_KeyPress);
            // 
            // GUI_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 341);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoldpass);
            this.MaximumSize = new System.Drawing.Size(549, 397);
            this.MinimumSize = new System.Drawing.Size(549, 397);
            this.Name = "GUI_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Pass";
            this.Load += new System.EventHandler(this.GUI_Pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtnewpass;
    }
}