namespace SV
{
    partial class GUI_ManagerRpClass
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
            this.cbclassid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(138, 160);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(75, 35);
            this.btreport.TabIndex = 7;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // cbclassid
            // 
            this.cbclassid.FormattingEnabled = true;
            this.cbclassid.Location = new System.Drawing.Point(188, 97);
            this.cbclassid.Name = "cbclassid";
            this.cbclassid.Size = new System.Drawing.Size(121, 28);
            this.cbclassid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report List Class :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report Class";
            // 
            // GUI_ManagerRpClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 247);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.cbclassid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(391, 303);
            this.MinimumSize = new System.Drawing.Size(391, 303);
            this.Name = "GUI_ManagerRpClass";
            this.Text = "GUI_ManagerRpClass";
            this.Load += new System.EventHandler(this.GUI_ManagerRpClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.ComboBox cbclassid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}