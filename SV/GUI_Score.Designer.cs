namespace SV
{
    partial class GUI_Score
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
            this.txtback = new System.Windows.Forms.Button();
            this.btviewmyscore = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvscore = new System.Windows.Forms.DataGridView();
            this.txtgetstudentid = new System.Windows.Forms.TextBox();
            this.txtgetdatausername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscore)).BeginInit();
            this.SuspendLayout();
            // 
            // txtback
            // 
            this.txtback.Location = new System.Drawing.Point(-1, 0);
            this.txtback.Name = "txtback";
            this.txtback.Size = new System.Drawing.Size(84, 33);
            this.txtback.TabIndex = 0;
            this.txtback.Text = "Menu";
            this.txtback.UseVisualStyleBackColor = true;
            this.txtback.Click += new System.EventHandler(this.Txtback_Click);
            // 
            // btviewmyscore
            // 
            this.btviewmyscore.ForeColor = System.Drawing.Color.Crimson;
            this.btviewmyscore.Location = new System.Drawing.Point(80, 0);
            this.btviewmyscore.Name = "btviewmyscore";
            this.btviewmyscore.Size = new System.Drawing.Size(177, 33);
            this.btviewmyscore.TabIndex = 1;
            this.btviewmyscore.Text = "View My Score";
            this.btviewmyscore.UseVisualStyleBackColor = true;
            this.btviewmyscore.Click += new System.EventHandler(this.Btviewmyscore_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btsearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 131);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "StudentID :";
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(617, 60);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(87, 34);
            this.btsearch.TabIndex = 2;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.Btsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(303, 64);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(270, 26);
            this.txtsearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Score";
            // 
            // dgvscore
            // 
            this.dgvscore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvscore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvscore.Location = new System.Drawing.Point(-1, 165);
            this.dgvscore.Name = "dgvscore";
            this.dgvscore.RowTemplate.Height = 28;
            this.dgvscore.Size = new System.Drawing.Size(893, 451);
            this.dgvscore.TabIndex = 3;
            // 
            // txtgetstudentid
            // 
            this.txtgetstudentid.Location = new System.Drawing.Point(508, 0);
            this.txtgetstudentid.Name = "txtgetstudentid";
            this.txtgetstudentid.Size = new System.Drawing.Size(121, 26);
            this.txtgetstudentid.TabIndex = 4;
            this.txtgetstudentid.Visible = false;
            // 
            // txtgetdatausername
            // 
            this.txtgetdatausername.Location = new System.Drawing.Point(635, 0);
            this.txtgetdatausername.Name = "txtgetdatausername";
            this.txtgetdatausername.Size = new System.Drawing.Size(121, 26);
            this.txtgetdatausername.TabIndex = 5;
            this.txtgetdatausername.Visible = false;
            // 
            // GUI_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(893, 617);
            this.Controls.Add(this.txtgetdatausername);
            this.Controls.Add(this.txtgetstudentid);
            this.Controls.Add(this.dgvscore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btviewmyscore);
            this.Controls.Add(this.txtback);
            this.MaximumSize = new System.Drawing.Size(915, 673);
            this.MinimumSize = new System.Drawing.Size(915, 673);
            this.Name = "GUI_Score";
            this.Text = "GUI_Score";
            this.Load += new System.EventHandler(this.GUI_Score_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtback;
        private System.Windows.Forms.Button btviewmyscore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvscore;
        private System.Windows.Forms.TextBox txtgetstudentid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgetdatausername;
    }
}