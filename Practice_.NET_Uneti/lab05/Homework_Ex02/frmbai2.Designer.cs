namespace Homework_Ex02
{
    partial class frmbai2
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
            this.cboDanhSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.btnXoaTu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.txtTiengViet = new System.Windows.Forms.RichTextBox();
            this.txtTiengAnh = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboDanhSach
            // 
            this.cboDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhSach.FormattingEnabled = true;
            this.cboDanhSach.Location = new System.Drawing.Point(41, 66);
            this.cboDanhSach.Name = "cboDanhSach";
            this.cboDanhSach.Size = new System.Drawing.Size(214, 33);
            this.cboDanhSach.TabIndex = 0;
            this.cboDanhSach.SelectedIndexChanged += new System.EventHandler(this.cboDanhSach_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiếng Anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiếng Việt";
            // 
            // btnThemTu
            // 
            this.btnThemTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTu.Location = new System.Drawing.Point(316, 66);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(119, 44);
            this.btnThemTu.TabIndex = 3;
            this.btnThemTu.Text = "Thêm từ";
            this.btnThemTu.UseVisualStyleBackColor = false;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // btnXoaTu
            // 
            this.btnXoaTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTu.Location = new System.Drawing.Point(316, 187);
            this.btnXoaTu.Name = "btnXoaTu";
            this.btnXoaTu.Size = new System.Drawing.Size(119, 44);
            this.btnXoaTu.TabIndex = 4;
            this.btnXoaTu.Text = "Xóa từ";
            this.btnXoaTu.UseVisualStyleBackColor = false;
            this.btnXoaTu.Click += new System.EventHandler(this.btnXoaTu_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCa.Location = new System.Drawing.Point(316, 306);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(119, 44);
            this.btnXoaTatCa.TabIndex = 5;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = false;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // txtTiengViet
            // 
            this.txtTiengViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiengViet.Location = new System.Drawing.Point(478, 66);
            this.txtTiengViet.Name = "txtTiengViet";
            this.txtTiengViet.Size = new System.Drawing.Size(238, 284);
            this.txtTiengViet.TabIndex = 6;
            this.txtTiengViet.Text = "";
            // 
            // txtTiengAnh
            // 
            this.txtTiengAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiengAnh.Location = new System.Drawing.Point(41, 105);
            this.txtTiengAnh.Name = "txtTiengAnh";
            this.txtTiengAnh.Size = new System.Drawing.Size(214, 245);
            this.txtTiengAnh.TabIndex = 7;
            this.txtTiengAnh.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.txtTiengAnh);
            this.Controls.Add(this.txtTiengViet);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXoaTu);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDanhSach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển Anh - Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Button btnXoaTu;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.RichTextBox txtTiengViet;
        private System.Windows.Forms.RichTextBox txtTiengAnh;
    }
}

