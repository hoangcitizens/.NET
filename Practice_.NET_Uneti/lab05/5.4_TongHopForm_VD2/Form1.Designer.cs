namespace _5._4_TongHopForm_VD2
{
    partial class Form1
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
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.combo_pheptoan = new System.Windows.Forms.ComboBox();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.bt_tinhtoan = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toán hạng 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phép toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toán hạng 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketqua.Location = new System.Drawing.Point(572, 83);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(67, 26);
            this.lb_ketqua.TabIndex = 4;
            this.lb_ketqua.Text = "label5";
            // 
            // combo_pheptoan
            // 
            this.combo_pheptoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.combo_pheptoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pheptoan.FormattingEnabled = true;
            this.combo_pheptoan.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.combo_pheptoan.Location = new System.Drawing.Point(211, 75);
            this.combo_pheptoan.Name = "combo_pheptoan";
            this.combo_pheptoan.Size = new System.Drawing.Size(121, 34);
            this.combo_pheptoan.TabIndex = 5;
            // 
            // txt_so1
            // 
            this.txt_so1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so1.Location = new System.Drawing.Point(43, 75);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(121, 34);
            this.txt_so1.TabIndex = 6;
            // 
            // txt_so2
            // 
            this.txt_so2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so2.Location = new System.Drawing.Point(383, 75);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(121, 34);
            this.txt_so2.TabIndex = 7;
            // 
            // bt_tinhtoan
            // 
            this.bt_tinhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_tinhtoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tinhtoan.Location = new System.Drawing.Point(164, 150);
            this.bt_tinhtoan.Name = "bt_tinhtoan";
            this.bt_tinhtoan.Size = new System.Drawing.Size(147, 46);
            this.bt_tinhtoan.TabIndex = 8;
            this.bt_tinhtoan.Text = "Tính toán";
            this.bt_tinhtoan.UseVisualStyleBackColor = false;
            this.bt_tinhtoan.Click += new System.EventHandler(this.bt_tinhtoan_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Location = new System.Drawing.Point(441, 150);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(147, 46);
            this.bt_Thoat.TabIndex = 9;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 219);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_tinhtoan);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.combo_pheptoan);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.ComboBox combo_pheptoan;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Button bt_tinhtoan;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label label6;
    }
}

