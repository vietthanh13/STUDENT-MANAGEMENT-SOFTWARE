namespace SV
{
    partial class GUI_Manager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btaddsemester = new System.Windows.Forms.Button();
            this.btaddscore = new System.Windows.Forms.Button();
            this.btaddstudent = new System.Windows.Forms.Button();
            this.btaddclass = new System.Windows.Forms.Button();
            this.btaddmajor = new System.Windows.Forms.Button();
            this.btaddsubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(1, 1);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(87, 34);
            this.btlogout.TabIndex = 0;
            this.btlogout.Text = "Log-Out";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.Btlogout_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btaddsemester);
            this.panel1.Controls.Add(this.btaddscore);
            this.panel1.Controls.Add(this.btaddstudent);
            this.panel1.Controls.Add(this.btaddclass);
            this.panel1.Controls.Add(this.btaddmajor);
            this.panel1.Controls.Add(this.btaddsubject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 539);
            this.panel1.TabIndex = 1;
            // 
            // btaddsemester
            // 
            this.btaddsemester.Location = new System.Drawing.Point(452, 286);
            this.btaddsemester.Name = "btaddsemester";
            this.btaddsemester.Size = new System.Drawing.Size(153, 99);
            this.btaddsemester.TabIndex = 6;
            this.btaddsemester.Text = "Add Semester";
            this.btaddsemester.UseVisualStyleBackColor = true;
            this.btaddsemester.Click += new System.EventHandler(this.Btaddsemester_Click);
            // 
            // btaddscore
            // 
            this.btaddscore.Location = new System.Drawing.Point(49, 286);
            this.btaddscore.Name = "btaddscore";
            this.btaddscore.Size = new System.Drawing.Size(148, 99);
            this.btaddscore.TabIndex = 4;
            this.btaddscore.Text = "Add Score";
            this.btaddscore.UseVisualStyleBackColor = true;
            this.btaddscore.Click += new System.EventHandler(this.Btaddscore_Click);
            // 
            // btaddstudent
            // 
            this.btaddstudent.Location = new System.Drawing.Point(249, 286);
            this.btaddstudent.Name = "btaddstudent";
            this.btaddstudent.Size = new System.Drawing.Size(148, 99);
            this.btaddstudent.TabIndex = 5;
            this.btaddstudent.Text = "Add Student";
            this.btaddstudent.UseVisualStyleBackColor = true;
            this.btaddstudent.Click += new System.EventHandler(this.Btaddstudent_Click);
            // 
            // btaddclass
            // 
            this.btaddclass.Location = new System.Drawing.Point(452, 118);
            this.btaddclass.Name = "btaddclass";
            this.btaddclass.Size = new System.Drawing.Size(153, 99);
            this.btaddclass.TabIndex = 3;
            this.btaddclass.Text = "Add Class";
            this.btaddclass.UseVisualStyleBackColor = true;
            this.btaddclass.Click += new System.EventHandler(this.Btaddclass_Click);
            // 
            // btaddmajor
            // 
            this.btaddmajor.Location = new System.Drawing.Point(249, 118);
            this.btaddmajor.Name = "btaddmajor";
            this.btaddmajor.Size = new System.Drawing.Size(148, 99);
            this.btaddmajor.TabIndex = 2;
            this.btaddmajor.Text = "Add Major";
            this.btaddmajor.UseVisualStyleBackColor = true;
            this.btaddmajor.Click += new System.EventHandler(this.Btaddmajor_Click);
            // 
            // btaddsubject
            // 
            this.btaddsubject.Location = new System.Drawing.Point(49, 118);
            this.btaddsubject.Name = "btaddsubject";
            this.btaddsubject.Size = new System.Drawing.Size(148, 99);
            this.btaddsubject.TabIndex = 1;
            this.btaddsubject.Text = "Add Subject";
            this.btaddsubject.UseVisualStyleBackColor = true;
            this.btaddsubject.Click += new System.EventHandler(this.Btaddsubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Manager";
            // 
            // GUI_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(658, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btlogout);
            this.MaximumSize = new System.Drawing.Size(680, 631);
            this.MinimumSize = new System.Drawing.Size(680, 631);
            this.Name = "GUI_Manager";
            this.Text = "GUI_Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_Manager_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btaddscore;
        private System.Windows.Forms.Button btaddstudent;
        private System.Windows.Forms.Button btaddclass;
        private System.Windows.Forms.Button btaddmajor;
        private System.Windows.Forms.Button btaddsubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btaddsemester;
    }
}