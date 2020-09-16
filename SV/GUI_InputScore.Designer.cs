namespace SV
{
    partial class GUI_InputScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbsubject = new System.Windows.Forms.ComboBox();
            this.btclear = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.txtclassid = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmanager = new System.Windows.Forms.Button();
            this.dgvscore = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.btshowall = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.btreport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbsubject);
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.txtscore2);
            this.panel1.Controls.Add(this.txtscore1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbsemester);
            this.panel1.Controls.Add(this.txtclassid);
            this.panel1.Controls.Add(this.txtstudentid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 275);
            this.panel1.TabIndex = 0;
            // 
            // cbsubject
            // 
            this.cbsubject.Enabled = false;
            this.cbsubject.FormattingEnabled = true;
            this.cbsubject.Location = new System.Drawing.Point(479, 75);
            this.cbsubject.Name = "cbsubject";
            this.cbsubject.Size = new System.Drawing.Size(193, 28);
            this.cbsubject.TabIndex = 21;
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(561, 213);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(89, 32);
            this.btclear.TabIndex = 20;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(355, 213);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(125, 32);
            this.btedit.TabIndex = 19;
            this.btedit.Text = "Enter Score";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.Btedit_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(847, 22);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(10, 10);
            this.btadd.TabIndex = 18;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Visible = false;
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(794, 133);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(124, 26);
            this.txtscore2.TabIndex = 16;
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(794, 75);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(124, 26);
            this.txtscore1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Score 1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(695, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Score 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subject :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Semester :";
            // 
            // cbsemester
            // 
            this.cbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Location = new System.Drawing.Point(479, 130);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(140, 28);
            this.cbsemester.TabIndex = 8;
            // 
            // txtclassid
            // 
            this.txtclassid.Enabled = false;
            this.txtclassid.Location = new System.Drawing.Point(162, 130);
            this.txtclassid.Name = "txtclassid";
            this.txtclassid.Size = new System.Drawing.Size(167, 26);
            this.txtclassid.TabIndex = 7;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Enabled = false;
            this.txtstudentid.Location = new System.Drawing.Point(162, 75);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(167, 26);
            this.txtstudentid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "StudentID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ClassID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Score";
            // 
            // btmanager
            // 
            this.btmanager.Location = new System.Drawing.Point(1, 1);
            this.btmanager.Name = "btmanager";
            this.btmanager.Size = new System.Drawing.Size(89, 32);
            this.btmanager.TabIndex = 1;
            this.btmanager.Text = "Manager";
            this.btmanager.UseVisualStyleBackColor = true;
            this.btmanager.Click += new System.EventHandler(this.Btmanager_Click);
            // 
            // dgvscore
            // 
            this.dgvscore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvscore.Location = new System.Drawing.Point(1, 380);
            this.dgvscore.Name = "dgvscore";
            this.dgvscore.RowTemplate.Height = 28;
            this.dgvscore.Size = new System.Drawing.Size(1024, 312);
            this.dgvscore.TabIndex = 4;
            this.dgvscore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvscore_CellClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(925, 1);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 5;
            this.txtid.Visible = false;
            // 
            // cbsearch
            // 
            this.cbsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Location = new System.Drawing.Point(131, 334);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(373, 28);
            this.cbsearch.TabIndex = 17;
            // 
            // btshowall
            // 
            this.btshowall.Location = new System.Drawing.Point(12, 332);
            this.btshowall.Name = "btshowall";
            this.btshowall.Size = new System.Drawing.Size(89, 32);
            this.btshowall.TabIndex = 21;
            this.btshowall.Text = "Show All";
            this.btshowall.UseVisualStyleBackColor = true;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(528, 331);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(89, 32);
            this.btsearch.TabIndex = 22;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // btreport
            // 
            this.btreport.Location = new System.Drawing.Point(96, 1);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(89, 32);
            this.btreport.TabIndex = 23;
            this.btreport.Text = "Report";
            this.btreport.UseVisualStyleBackColor = true;
            this.btreport.Click += new System.EventHandler(this.Btreport_Click);
            // 
            // GUI_InputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1026, 689);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btshowall);
            this.Controls.Add(this.cbsearch);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvscore);
            this.Controls.Add(this.btmanager);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1048, 745);
            this.MinimumSize = new System.Drawing.Size(1048, 745);
            this.Name = "GUI_InputScore";
            this.Text = "GUI_InputScore";
            this.Load += new System.EventHandler(this.GUI_InputScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.TextBox txtclassid;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmanager;
        private System.Windows.Forms.DataGridView dgvscore;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbsearch;
        private System.Windows.Forms.Button btshowall;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.ComboBox cbsubject;
        private System.Windows.Forms.Button btreport;
    }
}