namespace SV
{
    partial class GUI_ReportUser
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
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataSetUser1 = new SV.DataSetUser();
            this.reportview1 = new SV.CrystalReportUser();
            this.txtauth = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1552, 744);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.CrystalReportViewer1_Load_1);
            // 
            // dataSetUser1
            // 
            this.dataSetUser1.DataSetName = "DataSetUser";
            this.dataSetUser1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportview1
            // 
            this.reportview1.InitReport += new System.EventHandler(this.Reportview1_InitReport);
            // 
            // txtauth
            // 
            this.txtauth.Location = new System.Drawing.Point(0, 40);
            this.txtauth.Name = "txtauth";
            this.txtauth.Size = new System.Drawing.Size(10, 26);
            this.txtauth.TabIndex = 1;
            this.txtauth.Visible = false;
            // 
            // GUI_ReportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 744);
            this.Controls.Add(this.txtauth);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "GUI_ReportUser";
            this.Text = "GUI_ReportUser";
            this.Load += new System.EventHandler(this.GUI_ReportUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalReportUser reportview1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DataSetUser dataSetUser1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtauth;
    }
}