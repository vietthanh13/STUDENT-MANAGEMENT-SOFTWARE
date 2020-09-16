namespace SV
{
    partial class GUI_ManagerRpSubject
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
            this.btreport = new System.Windows.Forms.Button();
            this.cbcredit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(160, 154);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(75, 35);
            this.btreport.TabIndex = 7;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // cbcredit
            // 
            this.cbcredit.FormattingEnabled = true;
            this.cbcredit.Location = new System.Drawing.Point(189, 91);
            this.cbcredit.Name = "cbcredit";
            this.cbcredit.Size = new System.Drawing.Size(121, 28);
            this.cbcredit.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report List Credit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report Subject";
            // 
            // GUI_ManagerRpSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 258);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.cbcredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(432, 314);
            this.MinimumSize = new System.Drawing.Size(432, 314);
            this.Name = "GUI_ManagerRpSubject";
            this.Text = "GUI_ManagerRpSubject";
            this.Load += new System.EventHandler(this.GUI_ManagerRpSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.ComboBox cbcredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}