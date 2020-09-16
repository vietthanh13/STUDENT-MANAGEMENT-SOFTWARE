namespace SV
{
    partial class GUI_ReportScore
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
            this.reportview1 = new SV.CrystalReportUser();
            this.dataSetSubject1 = new SV.DataSetSubject();
            this.dataSetSemester1 = new SV.DataSetSemester();
            this.dataSetClass1 = new SV.DataSetClass();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetScore1 = new SV.DataSetScore();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSemester1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScore1)).BeginInit();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(25, 69);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 1;
            // 
            // dataSetSubject1
            // 
            this.dataSetSubject1.DataSetName = "DataSetSubject";
            this.dataSetSubject1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetSemester1
            // 
            this.dataSetSemester1.DataSetName = "DataSetSemester";
            this.dataSetSemester1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetClass1
            // 
            this.dataSetClass1.DataSetName = "DataSetClass";
            this.dataSetClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetScore1
            // 
            this.dataSetScore1.DataSetName = "DataSetScore";
            this.dataSetScore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GUI_ReportScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "GUI_ReportScore";
            this.Text = "GUI_ReportScore";
            this.Load += new System.EventHandler(this.GUI_ReportScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSubject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSemester1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScore1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtid;
        private CrystalReportUser reportview1;
        private DataSetSubject dataSetSubject1;
        private DataSetSemester dataSetSemester1;
        private DataSetScore dataSetScore1;
        private DataSetClass dataSetClass1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}