namespace Ex04_lab04
{
    partial class frmbai4
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
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.lstSoNguyen = new System.Windows.Forms.ListBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoaPhanTuCuoi = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDau = new System.Windows.Forms.Button();
            this.btnXoaPhanTuChon = new System.Windows.Forms.Button();
            this.btnChonSoLeCuoi = new System.Windows.Forms.Button();
            this.btnChonSoChanDau = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên";
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguyen.Location = new System.Drawing.Point(204, 23);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(286, 28);
            this.txtSoNguyen.TabIndex = 1;
            // 
            // lstSoNguyen
            // 
            this.lstSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSoNguyen.FormattingEnabled = true;
            this.lstSoNguyen.ItemHeight = 22;
            this.lstSoNguyen.Location = new System.Drawing.Point(43, 100);
            this.lstSoNguyen.Name = "lstSoNguyen";
            this.lstSoNguyen.Size = new System.Drawing.Size(256, 246);
            this.lstSoNguyen.TabIndex = 2;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(43, 374);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(591, 40);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnXoaPhanTuCuoi);
            this.grbChucNang.Controls.Add(this.btnXoaPhanTuDau);
            this.grbChucNang.Controls.Add(this.btnXoaPhanTuChon);
            this.grbChucNang.Controls.Add(this.btnChonSoLeCuoi);
            this.grbChucNang.Controls.Add(this.btnChonSoChanDau);
            this.grbChucNang.Controls.Add(this.btnTangLen2);
            this.grbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(319, 85);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(315, 268);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnXoaPhanTuCuoi
            // 
            this.btnXoaPhanTuCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoaPhanTuCuoi.Location = new System.Drawing.Point(19, 222);
            this.btnXoaPhanTuCuoi.Name = "btnXoaPhanTuCuoi";
            this.btnXoaPhanTuCuoi.Size = new System.Drawing.Size(277, 33);
            this.btnXoaPhanTuCuoi.TabIndex = 5;
            this.btnXoaPhanTuCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaPhanTuCuoi.UseVisualStyleBackColor = false;
            this.btnXoaPhanTuCuoi.Click += new System.EventHandler(this.btnXoaPhanTuCuoi_Click);
            // 
            // btnXoaPhanTuDau
            // 
            this.btnXoaPhanTuDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoaPhanTuDau.Location = new System.Drawing.Point(19, 183);
            this.btnXoaPhanTuDau.Name = "btnXoaPhanTuDau";
            this.btnXoaPhanTuDau.Size = new System.Drawing.Size(277, 33);
            this.btnXoaPhanTuDau.TabIndex = 4;
            this.btnXoaPhanTuDau.Text = "Xóa phần tử đầu";
            this.btnXoaPhanTuDau.UseVisualStyleBackColor = false;
            this.btnXoaPhanTuDau.Click += new System.EventHandler(this.btnXoaPhanTuDau_Click);
            // 
            // btnXoaPhanTuChon
            // 
            this.btnXoaPhanTuChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoaPhanTuChon.Location = new System.Drawing.Point(19, 144);
            this.btnXoaPhanTuChon.Name = "btnXoaPhanTuChon";
            this.btnXoaPhanTuChon.Size = new System.Drawing.Size(277, 33);
            this.btnXoaPhanTuChon.TabIndex = 3;
            this.btnXoaPhanTuChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTuChon.UseVisualStyleBackColor = false;
            this.btnXoaPhanTuChon.Click += new System.EventHandler(this.btnXoaPhanTuChon_Click);
            // 
            // btnChonSoLeCuoi
            // 
            this.btnChonSoLeCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChonSoLeCuoi.Location = new System.Drawing.Point(19, 105);
            this.btnChonSoLeCuoi.Name = "btnChonSoLeCuoi";
            this.btnChonSoLeCuoi.Size = new System.Drawing.Size(277, 33);
            this.btnChonSoLeCuoi.TabIndex = 2;
            this.btnChonSoLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonSoLeCuoi.UseVisualStyleBackColor = false;
            this.btnChonSoLeCuoi.Click += new System.EventHandler(this.btnChonSoLeCuoi_Click);
            // 
            // btnChonSoChanDau
            // 
            this.btnChonSoChanDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChonSoChanDau.Location = new System.Drawing.Point(19, 66);
            this.btnChonSoChanDau.Name = "btnChonSoChanDau";
            this.btnChonSoChanDau.Size = new System.Drawing.Size(277, 33);
            this.btnChonSoChanDau.TabIndex = 1;
            this.btnChonSoChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonSoChanDau.UseVisualStyleBackColor = false;
            this.btnChonSoChanDau.Click += new System.EventHandler(this.btnChonSoChanDau_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTangLen2.Location = new System.Drawing.Point(19, 27);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(277, 33);
            this.btnTangLen2.TabIndex = 0;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = false;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(509, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(125, 36);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmbai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 430);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lstSoNguyen);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.label1);
            this.Name = "frmbai4";
            this.Text = "Thao tác số";
            this.Load += new System.EventHandler(this.frmbai4_Load);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.ListBox lstSoNguyen;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnXoaPhanTuCuoi;
        private System.Windows.Forms.Button btnXoaPhanTuDau;
        private System.Windows.Forms.Button btnXoaPhanTuChon;
        private System.Windows.Forms.Button btnChonSoLeCuoi;
        private System.Windows.Forms.Button btnChonSoChanDau;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnCapNhat;
    }
}

