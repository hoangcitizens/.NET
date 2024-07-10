namespace NguyenHuuHoang_21103100320_week7
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbDen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvbm = new System.Windows.Forms.TextBox();
            this.chbDam = new System.Windows.Forms.CheckBox();
            this.chbNghieng = new System.Windows.Forms.CheckBox();
            this.chbGachChan = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDen);
            this.groupBox1.Controls.Add(this.rbDo);
            this.groupBox1.Controls.Add(this.rbXanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(227, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu chữ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbGachChan);
            this.groupBox2.Controls.Add(this.chbNghieng);
            this.groupBox2.Controls.Add(this.chbDam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(508, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(224, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu chữ";
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(20, 61);
            this.rbXanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(90, 33);
            this.rbXanh.TabIndex = 0;
            this.rbXanh.Text = "Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            this.rbXanh.CheckedChanged += new System.EventHandler(this.rbXanh_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(20, 111);
            this.rbDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(65, 33);
            this.rbDo.TabIndex = 1;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rbDen
            // 
            this.rbDen.AutoSize = true;
            this.rbDen.Checked = true;
            this.rbDen.Location = new System.Drawing.Point(20, 162);
            this.rbDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDen.Name = "rbDen";
            this.rbDen.Size = new System.Drawing.Size(78, 33);
            this.rbDen.TabIndex = 2;
            this.rbDen.TabStop = true;
            this.rbDen.Text = "Đen";
            this.rbDen.UseVisualStyleBackColor = true;
            this.rbDen.CheckedChanged += new System.EventHandler(this.rbDen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Văn bản mẫu";
            // 
            // txtvbm
            // 
            this.txtvbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbm.Location = new System.Drawing.Point(69, 439);
            this.txtvbm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvbm.Multiline = true;
            this.txtvbm.Name = "txtvbm";
            this.txtvbm.Size = new System.Drawing.Size(674, 164);
            this.txtvbm.TabIndex = 3;
            // 
            // chbDam
            // 
            this.chbDam.AutoSize = true;
            this.chbDam.Location = new System.Drawing.Point(46, 56);
            this.chbDam.Name = "chbDam";
            this.chbDam.Size = new System.Drawing.Size(85, 33);
            this.chbDam.TabIndex = 0;
            this.chbDam.Text = "Đậm";
            this.chbDam.UseVisualStyleBackColor = true;
            this.chbDam.CheckedChanged += new System.EventHandler(this.chbDam_CheckedChanged);
            // 
            // chbNghieng
            // 
            this.chbNghieng.AutoSize = true;
            this.chbNghieng.Location = new System.Drawing.Point(46, 111);
            this.chbNghieng.Name = "chbNghieng";
            this.chbNghieng.Size = new System.Drawing.Size(127, 33);
            this.chbNghieng.TabIndex = 1;
            this.chbNghieng.Text = "Nghiêng";
            this.chbNghieng.UseVisualStyleBackColor = true;
            this.chbNghieng.CheckedChanged += new System.EventHandler(this.chbNghieng_CheckedChanged);
            // 
            // chbGachChan
            // 
            this.chbGachChan.AutoSize = true;
            this.chbGachChan.Location = new System.Drawing.Point(46, 163);
            this.chbGachChan.Name = "chbGachChan";
            this.chbGachChan.Size = new System.Drawing.Size(148, 33);
            this.chbGachChan.TabIndex = 2;
            this.chbGachChan.Text = "Gạch chân";
            this.chbGachChan.UseVisualStyleBackColor = true;
            this.chbGachChan.CheckedChanged += new System.EventHandler(this.chbGachChan_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 679);
            this.Controls.Add(this.txtvbm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Điều khiển Check box và Radio button";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDen;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbGachChan;
        private System.Windows.Forms.CheckBox chbNghieng;
        private System.Windows.Forms.CheckBox chbDam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvbm;
    }
}