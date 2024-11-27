namespace Homework_Ex04
{
    partial class frm_Ex04
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnSuaDoi = new System.Windows.Forms.Button();
            this.txtSoCongTo = new System.Windows.Forms.TextBox();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.txtSoCu = new System.Windows.Forms.TextBox();
            this.txtSoMoi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoCongTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN TIỀN ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số công tơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chủ hộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số cũ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMoi.Location = new System.Drawing.Point(26, 344);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(122, 39);
            this.btnNhapMoi.TabIndex = 6;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = false;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnSuaDoi
            // 
            this.btnSuaDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDoi.Location = new System.Drawing.Point(176, 344);
            this.btnSuaDoi.Name = "btnSuaDoi";
            this.btnSuaDoi.Size = new System.Drawing.Size(122, 39);
            this.btnSuaDoi.TabIndex = 7;
            this.btnSuaDoi.Text = "Sửa đổi";
            this.btnSuaDoi.UseVisualStyleBackColor = false;
            this.btnSuaDoi.Click += new System.EventHandler(this.btnSuaDoi_Click);
            // 
            // txtSoCongTo
            // 
            this.txtSoCongTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCongTo.Location = new System.Drawing.Point(158, 67);
            this.txtSoCongTo.Name = "txtSoCongTo";
            this.txtSoCongTo.Size = new System.Drawing.Size(227, 30);
            this.txtSoCongTo.TabIndex = 8;
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuHo.Location = new System.Drawing.Point(158, 118);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.Size = new System.Drawing.Size(227, 30);
            this.txtTenChuHo.TabIndex = 9;
            // 
            // txtSoCu
            // 
            this.txtSoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCu.Location = new System.Drawing.Point(158, 174);
            this.txtSoCu.Name = "txtSoCu";
            this.txtSoCu.Size = new System.Drawing.Size(227, 30);
            this.txtSoCu.TabIndex = 10;
            // 
            // txtSoMoi
            // 
            this.txtSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoMoi.Location = new System.Drawing.Point(158, 230);
            this.txtSoMoi.Name = "txtSoMoi";
            this.txtSoMoi.Size = new System.Drawing.Size(227, 30);
            this.txtSoMoi.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(158, 284);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(227, 30);
            this.txtDonGia.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 233);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCongTo,
            this.TenChuHo,
            this.SoCu,
            this.SoMoi,
            this.SoTieuThu,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // SoCongTo
            // 
            this.SoCongTo.DataPropertyName = "SoCongTo";
            this.SoCongTo.HeaderText = "Số công tơ";
            this.SoCongTo.MinimumWidth = 6;
            this.SoCongTo.Name = "SoCongTo";
            this.SoCongTo.Width = 125;
            // 
            // TenChuHo
            // 
            this.TenChuHo.DataPropertyName = "TenChuHo";
            this.TenChuHo.HeaderText = "Tên chủ hộ";
            this.TenChuHo.MinimumWidth = 6;
            this.TenChuHo.Name = "TenChuHo";
            this.TenChuHo.Width = 125;
            // 
            // SoCu
            // 
            this.SoCu.DataPropertyName = "SoCu";
            this.SoCu.HeaderText = "Số cũ";
            this.SoCu.MinimumWidth = 6;
            this.SoCu.Name = "SoCu";
            this.SoCu.Width = 125;
            // 
            // SoMoi
            // 
            this.SoMoi.DataPropertyName = "SoMoi";
            this.SoMoi.HeaderText = "Số mới";
            this.SoMoi.MinimumWidth = 6;
            this.SoMoi.Name = "SoMoi";
            this.SoMoi.Width = 125;
            // 
            // SoTieuThu
            // 
            this.SoTieuThu.DataPropertyName = "SoTieuThu";
            this.SoTieuThu.HeaderText = "Số tiêu thụ";
            this.SoTieuThu.MinimumWidth = 6;
            this.SoTieuThu.Name = "SoTieuThu";
            this.SoTieuThu.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // frm_Ex04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(773, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoMoi);
            this.Controls.Add(this.txtSoCu);
            this.Controls.Add(this.txtTenChuHo);
            this.Controls.Add(this.txtSoCongTo);
            this.Controls.Add(this.btnSuaDoi);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Ex04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn điện";
            this.Load += new System.EventHandler(this.frm_Ex04_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnSuaDoi;
        private System.Windows.Forms.TextBox txtSoCongTo;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.TextBox txtSoCu;
        private System.Windows.Forms.TextBox txtSoMoi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCongTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

