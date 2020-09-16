namespace SV
{
    partial class GUI_ReportClass
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.dataSetClass1 = new SV.DataSetClass();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter1 = new SV.DataSetClassTableAdapters.ClassTableAdapter();
            this.reportview1 = new SV.CrystalReportUser();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass1)).BeginInit();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1169, 691);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(59, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            // 
            // dataSetClass1
            // 
            this.dataSetClass1.DataSetName = "DataSetClass";
            this.dataSetClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter1
            // 
            this.classTableAdapter1.ClearBeforeFill = true;
            // 
            // GUI_ReportClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 691);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "GUI_ReportClass";
            this.Text = "GUI_ReportClass";
            this.Load += new System.EventHandler(this.GUI_ReportClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtid;
        private DataSetClass dataSetClass1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSetClassTableAdapters.ClassTableAdapter classTableAdapter1;
        private CrystalReportUser reportview1;
    }
}