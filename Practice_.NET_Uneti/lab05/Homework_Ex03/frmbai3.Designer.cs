namespace Homework_Ex03
{
    partial class frmbai3
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
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoHinhVuong = new System.Windows.Forms.RadioButton();
            this.rdoHinhEllipse = new System.Windows.Forms.RadioButton();
            this.rdoHinhChuNhat = new System.Windows.Forms.RadioButton();
            this.rdoHinhTron = new System.Windows.Forms.RadioButton();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.btnVeHinh = new System.Windows.Forms.Button();
            this.pnlHinhVe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(170, 206);
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(263, 34);
            this.hScrollBarRed.TabIndex = 4;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(170, 251);
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(263, 34);
            this.hScrollBarGreen.TabIndex = 5;
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(170, 304);
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(263, 34);
            this.hScrollBarBlue.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoHinhVuong);
            this.groupBox2.Controls.Add(this.rdoHinhEllipse);
            this.groupBox2.Controls.Add(this.rdoHinhChuNhat);
            this.groupBox2.Controls.Add(this.rdoHinhTron);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn hình vẽ";
            // 
            // rdoHinhVuong
            // 
            this.rdoHinhVuong.AutoSize = true;
            this.rdoHinhVuong.Location = new System.Drawing.Point(204, 96);
            this.rdoHinhVuong.Name = "rdoHinhVuong";
            this.rdoHinhVuong.Size = new System.Drawing.Size(132, 29);
            this.rdoHinhVuong.TabIndex = 3;
            this.rdoHinhVuong.TabStop = true;
            this.rdoHinhVuong.Text = "Hình vuông";
            this.rdoHinhVuong.UseVisualStyleBackColor = true;
            // 
            // rdoHinhEllipse
            // 
            this.rdoHinhEllipse.AutoSize = true;
            this.rdoHinhEllipse.Location = new System.Drawing.Point(31, 96);
            this.rdoHinhEllipse.Name = "rdoHinhEllipse";
            this.rdoHinhEllipse.Size = new System.Drawing.Size(135, 29);
            this.rdoHinhEllipse.TabIndex = 2;
            this.rdoHinhEllipse.TabStop = true;
            this.rdoHinhEllipse.Text = "Hình Ellipse";
            this.rdoHinhEllipse.UseVisualStyleBackColor = true;
            // 
            // rdoHinhChuNhat
            // 
            this.rdoHinhChuNhat.AutoSize = true;
            this.rdoHinhChuNhat.Location = new System.Drawing.Point(204, 43);
            this.rdoHinhChuNhat.Name = "rdoHinhChuNhat";
            this.rdoHinhChuNhat.Size = new System.Drawing.Size(153, 29);
            this.rdoHinhChuNhat.TabIndex = 1;
            this.rdoHinhChuNhat.TabStop = true;
            this.rdoHinhChuNhat.Text = "Hình chữ nhật";
            this.rdoHinhChuNhat.UseVisualStyleBackColor = true;
            // 
            // rdoHinhTron
            // 
            this.rdoHinhTron.AutoSize = true;
            this.rdoHinhTron.Location = new System.Drawing.Point(31, 43);
            this.rdoHinhTron.Name = "rdoHinhTron";
            this.rdoHinhTron.Size = new System.Drawing.Size(111, 29);
            this.rdoHinhTron.TabIndex = 0;
            this.rdoHinhTron.TabStop = true;
            this.rdoHinhTron.Text = "Hình tròn";
            this.rdoHinhTron.UseVisualStyleBackColor = true;
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(127, 206);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(25, 25);
            this.lblRedValue.TabIndex = 1;
            this.lblRedValue.Text = "R";
            this.lblRedValue.Click += new System.EventHandler(this.lblRedValue_Click);
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(127, 251);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(27, 25);
            this.lblGreenValue.TabIndex = 2;
            this.lblGreenValue.Text = "G";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(129, 304);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(25, 25);
            this.lblBlueValue.TabIndex = 3;
            this.lblBlueValue.Text = "B";
            this.lblBlueValue.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnVeHinh
            // 
            this.btnVeHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVeHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeHinh.Location = new System.Drawing.Point(561, 304);
            this.btnVeHinh.Name = "btnVeHinh";
            this.btnVeHinh.Size = new System.Drawing.Size(141, 41);
            this.btnVeHinh.TabIndex = 7;
            this.btnVeHinh.Text = "Vẽ hình";
            this.btnVeHinh.UseVisualStyleBackColor = false;
            this.btnVeHinh.Click += new System.EventHandler(this.btnVeHinh_Click);
            // 
            // pnlHinhVe
            // 
            this.pnlHinhVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHinhVe.Location = new System.Drawing.Point(472, 21);
            this.pnlHinhVe.Name = "pnlHinhVe";
            this.pnlHinhVe.Size = new System.Drawing.Size(308, 246);
            this.pnlHinhVe.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHinhVe);
            this.Controls.Add(this.btnVeHinh);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ hình";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoHinhVuong;
        private System.Windows.Forms.RadioButton rdoHinhEllipse;
        private System.Windows.Forms.RadioButton rdoHinhChuNhat;
        private System.Windows.Forms.RadioButton rdoHinhTron;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Button btnVeHinh;
        private System.Windows.Forms.Panel pnlHinhVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

