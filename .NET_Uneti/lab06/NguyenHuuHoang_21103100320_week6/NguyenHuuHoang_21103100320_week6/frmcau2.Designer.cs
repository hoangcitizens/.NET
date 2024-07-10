namespace NguyenHuuHoang_21103100320_week6
{
    partial class frmcau2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.texta = new System.Windows.Forms.TextBox();
            this.textb = new System.Windows.Forms.TextBox();
            this.textc = new System.Windows.Forms.TextBox();
            this.textPhuongtrinh = new System.Windows.Forms.TextBox();
            this.textNghiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập c = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phương trình ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nghiệm của phương trình";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tiếp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // texta
            // 
            this.texta.Location = new System.Drawing.Point(173, 41);
            this.texta.Multiline = true;
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(135, 37);
            this.texta.TabIndex = 8;
            // 
            // textb
            // 
            this.textb.Location = new System.Drawing.Point(173, 116);
            this.textb.Multiline = true;
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(135, 37);
            this.textb.TabIndex = 9;
            // 
            // textc
            // 
            this.textc.Location = new System.Drawing.Point(173, 168);
            this.textc.Multiline = true;
            this.textc.Name = "textc";
            this.textc.Size = new System.Drawing.Size(135, 37);
            this.textc.TabIndex = 10;
            // 
            // textPhuongtrinh
            // 
            this.textPhuongtrinh.Location = new System.Drawing.Point(173, 277);
            this.textPhuongtrinh.Multiline = true;
            this.textPhuongtrinh.Name = "textPhuongtrinh";
            this.textPhuongtrinh.Size = new System.Drawing.Size(232, 38);
            this.textPhuongtrinh.TabIndex = 11;
            // 
            // textNghiem
            // 
            this.textNghiem.Location = new System.Drawing.Point(163, 359);
            this.textNghiem.Multiline = true;
            this.textNghiem.Name = "textNghiem";
            this.textNghiem.Size = new System.Drawing.Size(260, 79);
            this.textNghiem.TabIndex = 12;
            
            // 
            // frmcau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNghiem);
            this.Controls.Add(this.textPhuongtrinh);
            this.Controls.Add(this.textc);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.texta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcau2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm nghiệm phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.TextBox textc;
        private System.Windows.Forms.TextBox textPhuongtrinh;
        private System.Windows.Forms.TextBox textNghiem;
    }
}