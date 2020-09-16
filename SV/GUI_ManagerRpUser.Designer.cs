namespace SV
{
    partial class GUI_ManagerRpUser
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
            this.cachedCrystalReportUser1 = new SV.CachedCrystalReportUser();
            this.label2 = new System.Windows.Forms.Label();
            this.cbauth = new System.Windows.Forms.ComboBox();
            this.btreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report User";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report List User :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cbauth
            // 
            this.cbauth.FormattingEnabled = true;
            this.cbauth.Location = new System.Drawing.Point(209, 99);
            this.cbauth.Name = "cbauth";
            this.cbauth.Size = new System.Drawing.Size(121, 28);
            this.cbauth.TabIndex = 2;
            this.cbauth.SelectedIndexChanged += new System.EventHandler(this.Cbauth_SelectedIndexChanged);
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(180, 162);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(75, 35);
            this.btreport.TabIndex = 3;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // GUI_ManagerRpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 235);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.cbauth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(468, 291);
            this.MinimumSize = new System.Drawing.Size(468, 291);
            this.Name = "GUI_ManagerRpUser";
            this.Text = "GUI_ManagerRpUser";
            this.Load += new System.EventHandler(this.GUI_ManagerRpUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CachedCrystalReportUser cachedCrystalReportUser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbauth;
        private System.Windows.Forms.Button btreport;
    }
}