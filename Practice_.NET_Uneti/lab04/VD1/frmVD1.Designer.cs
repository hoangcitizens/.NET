namespace VD1
{
    partial class frmVD1
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
            this.cbomau = new System.Windows.Forms.ComboBox();
            this.btndoimau = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến với Thực tập lập trình .NET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn màu";
            // 
            // cbomau
            // 
            this.cbomau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomau.FormattingEnabled = true;
            this.cbomau.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Blue",
            "Green"});
            this.cbomau.Location = new System.Drawing.Point(314, 82);
            this.cbomau.Name = "cbomau";
            this.cbomau.Size = new System.Drawing.Size(200, 28);
            this.cbomau.TabIndex = 2;
            // 
            // btndoimau
            // 
            this.btndoimau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndoimau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimau.Location = new System.Drawing.Point(207, 141);
            this.btndoimau.Name = "btndoimau";
            this.btndoimau.Size = new System.Drawing.Size(121, 45);
            this.btndoimau.TabIndex = 3;
            this.btndoimau.Text = "Đổi màu";
            this.btndoimau.UseVisualStyleBackColor = false;
            this.btndoimau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(442, 141);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(121, 45);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmVD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 214);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndoimau);
            this.Controls.Add(this.cbomau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVD1";
            this.Text = "Lựa chọn màu nền qua Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomau;
        private System.Windows.Forms.Button btndoimau;
        private System.Windows.Forms.Button btnthoat;
    }
}

