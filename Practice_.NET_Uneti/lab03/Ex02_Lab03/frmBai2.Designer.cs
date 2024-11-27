namespace Ex02_Lab03
{
    partial class frmBai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbTrungTo = new System.Windows.Forms.RichTextBox();
            this.rtbHauTo = new System.Windows.Forms.RichTextBox();
            this.btnChuyenHauTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN BIỂU THỨC TRUNG TỐ ĐẦY ĐỦ DẤU NGOẶC SANG DẠNG HẬU TỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập biểu thức trung tố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biểu thức hậu tố";
            // 
            // rtbTrungTo
            // 
            this.rtbTrungTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTrungTo.Location = new System.Drawing.Point(56, 101);
            this.rtbTrungTo.Name = "rtbTrungTo";
            this.rtbTrungTo.Size = new System.Drawing.Size(726, 114);
            this.rtbTrungTo.TabIndex = 3;
            this.rtbTrungTo.Text = "";
            this.rtbTrungTo.TextChanged += new System.EventHandler(this.rtbTrungTo_TextChanged);
            // 
            // rtbHauTo
            // 
            this.rtbHauTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHauTo.Location = new System.Drawing.Point(56, 323);
            this.rtbHauTo.Name = "rtbHauTo";
            this.rtbHauTo.Size = new System.Drawing.Size(724, 122);
            this.rtbHauTo.TabIndex = 4;
            this.rtbHauTo.Text = "";
            // 
            // btnChuyenHauTo
            // 
            this.btnChuyenHauTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChuyenHauTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenHauTo.Location = new System.Drawing.Point(189, 234);
            this.btnChuyenHauTo.Name = "btnChuyenHauTo";
            this.btnChuyenHauTo.Size = new System.Drawing.Size(138, 46);
            this.btnChuyenHauTo.TabIndex = 5;
            this.btnChuyenHauTo.Text = "Chuyển hậu tố";
            this.btnChuyenHauTo.UseVisualStyleBackColor = false;
            this.btnChuyenHauTo.Click += new System.EventHandler(this.btnChuyenHauTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(477, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 46);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 467);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChuyenHauTo);
            this.Controls.Add(this.rtbHauTo);
            this.Controls.Add(this.rtbTrungTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Chuyển trung tố về hậu tố";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbTrungTo;
        private System.Windows.Forms.RichTextBox rtbHauTo;
        private System.Windows.Forms.Button btnChuyenHauTo;
        private System.Windows.Forms.Button btnThoat;
    }
}

