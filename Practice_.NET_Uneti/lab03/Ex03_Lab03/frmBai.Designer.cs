namespace Ex03_Lab03
{
    partial class frmBai
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
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapN.Location = new System.Drawing.Point(149, 54);
            this.txtNhapN.Multiline = true;
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(254, 35);
            this.txtNhapN.TabIndex = 1;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTinhTong.Location = new System.Drawing.Point(23, 145);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(192, 46);
            this.btnTinhTong.TabIndex = 2;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = false;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKiemTra.Location = new System.Drawing.Point(23, 237);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(192, 46);
            this.btnKiemTra.TabIndex = 3;
            this.btnKiemTra.Text = "Kiểm tra số nguyên tố";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(264, 157);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(53, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "label2";
            // 
            // frmBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 324);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.label1);
            this.Name = "frmBai";
            this.Text = "Tính tổng và kiểm tra só nguyên tố";    
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblKetQua;
    }
}

