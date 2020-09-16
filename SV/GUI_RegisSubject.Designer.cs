namespace SV
{
    partial class GUI_RegisSubject
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
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.cbsubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.cachedCrystalReportClass1 = new SV.CachedCrystalReportClass();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtsubjectid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentid
            // 
            this.txtstudentid.Enabled = false;
            this.txtstudentid.Location = new System.Drawing.Point(276, 71);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(121, 26);
            this.txtstudentid.TabIndex = 0;
            // 
            // cbsubject
            // 
            this.cbsubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsubject.FormattingEnabled = true;
            this.cbsubject.Location = new System.Drawing.Point(276, 119);
            this.cbsubject.Name = "cbsubject";
            this.cbsubject.Size = new System.Drawing.Size(121, 28);
            this.cbsubject.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbsubject);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtstudentid);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 231);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register Subject";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(0, -2);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(100, 39);
            this.btback.TabIndex = 6;
            this.btback.Text = "Menu";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.Btback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(558, 235);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(427, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 26);
            this.txtusername.TabIndex = 8;
            this.txtusername.Visible = false;
            // 
            // txtsubjectid
            // 
            this.txtsubjectid.Location = new System.Drawing.Point(300, 4);
            this.txtsubjectid.Name = "txtsubjectid";
            this.txtsubjectid.Size = new System.Drawing.Size(121, 26);
            this.txtsubjectid.TabIndex = 9;
            this.txtsubjectid.Visible = false;
            // 
            // GUI_RegisSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.txtsubjectid);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(582, 566);
            this.MinimumSize = new System.Drawing.Size(582, 566);
            this.Name = "GUI_RegisSubject";
            this.Text = "GUI_RegisSubject";
            this.Load += new System.EventHandler(this.GUI_RegisSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.ComboBox cbsubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btback;
        private CachedCrystalReportClass cachedCrystalReportClass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtsubjectid;
    }
}