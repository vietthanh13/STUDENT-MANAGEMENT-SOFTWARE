namespace SV
{
    partial class TestEncryptDecrypt
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
            this.txtmahoa = new System.Windows.Forms.TextBox();
            this.btmahoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiaima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btgiaima = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Chuỗi Cần Mã Hóa : ";
            // 
            // txtmahoa
            // 
            this.txtmahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahoa.Location = new System.Drawing.Point(520, 222);
            this.txtmahoa.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtmahoa.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtmahoa.Name = "txtmahoa";
            this.txtmahoa.Size = new System.Drawing.Size(500, 50);
            this.txtmahoa.TabIndex = 1;
            // 
            // btmahoa
            // 
            this.btmahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmahoa.Location = new System.Drawing.Point(222, 600);
            this.btmahoa.Name = "btmahoa";
            this.btmahoa.Size = new System.Drawing.Size(219, 68);
            this.btmahoa.TabIndex = 2;
            this.btmahoa.Text = "Mã Hóa";
            this.btmahoa.UseVisualStyleBackColor = true;
            this.btmahoa.Click += new System.EventHandler(this.Btmahoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Chuỗi Cần Giải Mã :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chương Trình Mã Hóa Encrypt và Decrypt";
            // 
            // txtgiaima
            // 
            this.txtgiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaima.Location = new System.Drawing.Point(520, 348);
            this.txtgiaima.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtgiaima.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtgiaima.Name = "txtgiaima";
            this.txtgiaima.Size = new System.Drawing.Size(500, 50);
            this.txtgiaima.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết Quả :";
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(520, 468);
            this.txtketqua.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtketqua.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(500, 50);
            this.txtketqua.TabIndex = 7;
            // 
            // btgiaima
            // 
            this.btgiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgiaima.Location = new System.Drawing.Point(602, 600);
            this.btgiaima.Name = "btgiaima";
            this.btgiaima.Size = new System.Drawing.Size(219, 68);
            this.btgiaima.TabIndex = 8;
            this.btgiaima.Text = "Giải Mã";
            this.btgiaima.UseVisualStyleBackColor = true;
            this.btgiaima.Click += new System.EventHandler(this.Btgiaima_Click);
            // 
            // btclear
            // 
            this.btclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(976, 600);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(219, 68);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "Xóa";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 801);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btgiaima);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgiaima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmahoa);
            this.Controls.Add(this.txtmahoa);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1394, 857);
            this.MinimumSize = new System.Drawing.Size(1394, 857);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahoa;
        private System.Windows.Forms.Button btmahoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiaima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btgiaima;
        private System.Windows.Forms.Button btclear;
    }
}