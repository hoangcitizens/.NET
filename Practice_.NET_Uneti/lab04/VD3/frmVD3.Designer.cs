namespace VD3
{
    partial class frmVD3
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsthienthi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongso = new System.Windows.Forms.TextBox();
            this.btnxoachon = new System.Windows.Forms.Button();
            this.btnxoabandau = new System.Windows.Forms.Button();
            this.btnxoaall = new System.Windows.Forms.Button();
            this.btnxoacuoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(234, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ ";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(117, 33);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(219, 28);
            this.txthoten.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.LightGray;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(117, 82);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(157, 33);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập thông tin";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsthienthi
            // 
            this.lsthienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsthienthi.FormattingEnabled = true;
            this.lsthienthi.ItemHeight = 22;
            this.lsthienthi.Location = new System.Drawing.Point(373, 93);
            this.lsthienthi.Name = "lsthienthi";
            this.lsthienthi.Size = new System.Drawing.Size(464, 202);
            this.lsthienthi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số người đã khai báo";
            // 
            // txttongso
            // 
            this.txttongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongso.Location = new System.Drawing.Point(611, 302);
            this.txttongso.Name = "txttongso";
            this.txttongso.Size = new System.Drawing.Size(226, 28);
            this.txttongso.TabIndex = 6;
            // 
            // btnxoachon
            // 
            this.btnxoachon.BackColor = System.Drawing.Color.LightGray;
            this.btnxoachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoachon.Location = new System.Drawing.Point(372, 359);
            this.btnxoachon.Name = "btnxoachon";
            this.btnxoachon.Size = new System.Drawing.Size(219, 40);
            this.btnxoachon.TabIndex = 7;
            this.btnxoachon.Text = "Xóa thông tin đã chọn";
            this.btnxoachon.UseVisualStyleBackColor = false;
            this.btnxoachon.Click += new System.EventHandler(this.btnxoachon_Click);
            // 
            // btnxoabandau
            // 
            this.btnxoabandau.BackColor = System.Drawing.Color.LightGray;
            this.btnxoabandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoabandau.Location = new System.Drawing.Point(618, 359);
            this.btnxoabandau.Name = "btnxoabandau";
            this.btnxoabandau.Size = new System.Drawing.Size(219, 40);
            this.btnxoabandau.TabIndex = 8;
            this.btnxoabandau.Text = "Xóa thông tin ban đầu";
            this.btnxoabandau.UseVisualStyleBackColor = false;
            this.btnxoabandau.Click += new System.EventHandler(this.btnxoabandau_Click);
            // 
            // btnxoaall
            // 
            this.btnxoaall.BackColor = System.Drawing.Color.LightGray;
            this.btnxoaall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaall.Location = new System.Drawing.Point(372, 419);
            this.btnxoaall.Name = "btnxoaall";
            this.btnxoaall.Size = new System.Drawing.Size(219, 40);
            this.btnxoaall.TabIndex = 9;
            this.btnxoaall.Text = "Xóa tất cả thông tin";
            this.btnxoaall.UseVisualStyleBackColor = false;
            this.btnxoaall.Click += new System.EventHandler(this.btnxoaall_Click);
            // 
            // btnxoacuoi
            // 
            this.btnxoacuoi.BackColor = System.Drawing.Color.LightGray;
            this.btnxoacuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoacuoi.Location = new System.Drawing.Point(618, 419);
            this.btnxoacuoi.Name = "btnxoacuoi";
            this.btnxoacuoi.Size = new System.Drawing.Size(219, 40);
            this.btnxoacuoi.TabIndex = 10;
            this.btnxoacuoi.Text = "Xóa thông tin cuối";
            this.btnxoacuoi.UseVisualStyleBackColor = false;
            this.btnxoacuoi.Click += new System.EventHandler(this.btnxoacuoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 85);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnNhap);
            this.panel2.Controls.Add(this.txthoten);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 366);
            this.panel2.TabIndex = 12;
            // 
            // frmVD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnxoacuoi);
            this.Controls.Add(this.btnxoaall);
            this.Controls.Add(this.btnxoabandau);
            this.Controls.Add(this.btnxoachon);
            this.Controls.Add(this.txttongso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsthienthi);
            this.Name = "frmVD3";
            this.Text = "Tổng hợp khai báo y tế - Covid19";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsthienthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongso;
        private System.Windows.Forms.Button btnxoachon;
        private System.Windows.Forms.Button btnxoabandau;
        private System.Windows.Forms.Button btnxoaall;
        private System.Windows.Forms.Button btnxoacuoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

