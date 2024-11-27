namespace Ex01_lab9
{
    partial class Yc4b_FrmTimKiemMH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listview_kqtimkiem = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_mamh = new System.Windows.Forms.RadioButton();
            this.radio_tenmh = new System.Windows.Forms.RadioButton();
            this.txt_noidungTK = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM MẶT HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.txt_noidungTK);
            this.groupBox1.Controls.Add(this.radio_tenmh);
            this.groupBox1.Controls.Add(this.radio_mamh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.listview_kqtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // listview_kqtimkiem
            // 
            this.listview_kqtimkiem.HideSelection = false;
            this.listview_kqtimkiem.Location = new System.Drawing.Point(16, 29);
            this.listview_kqtimkiem.Name = "listview_kqtimkiem";
            this.listview_kqtimkiem.Size = new System.Drawing.Size(503, 160);
            this.listview_kqtimkiem.TabIndex = 0;
            this.listview_kqtimkiem.UseCompatibleStateImageBehavior = false;
            this.listview_kqtimkiem.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nội dung tìm kiếm";
            // 
            // radio_mamh
            // 
            this.radio_mamh.AutoSize = true;
            this.radio_mamh.Location = new System.Drawing.Point(221, 32);
            this.radio_mamh.Name = "radio_mamh";
            this.radio_mamh.Size = new System.Drawing.Size(97, 29);
            this.radio_mamh.TabIndex = 2;
            this.radio_mamh.TabStop = true;
            this.radio_mamh.Text = "Mã MH";
            this.radio_mamh.UseVisualStyleBackColor = true;
            // 
            // radio_tenmh
            // 
            this.radio_tenmh.AutoSize = true;
            this.radio_tenmh.Location = new System.Drawing.Point(381, 32);
            this.radio_tenmh.Name = "radio_tenmh";
            this.radio_tenmh.Size = new System.Drawing.Size(104, 29);
            this.radio_tenmh.TabIndex = 3;
            this.radio_tenmh.TabStop = true;
            this.radio_tenmh.Text = "Tên MH";
            this.radio_tenmh.UseVisualStyleBackColor = true;
            // 
            // txt_noidungTK
            // 
            this.txt_noidungTK.Location = new System.Drawing.Point(221, 77);
            this.txt_noidungTK.Name = "txt_noidungTK";
            this.txt_noidungTK.Size = new System.Drawing.Size(258, 30);
            this.txt_noidungTK.TabIndex = 4;
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_tim.Location = new System.Drawing.Point(221, 122);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(100, 46);
            this.bt_tim.TabIndex = 5;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_thoat.Location = new System.Drawing.Point(379, 122);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(100, 46);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Yc4b_FrmTimKiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(561, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Yc4b_FrmTimKiemMH";
            this.Text = "FrmTimKiemMH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_noidungTK;
        private System.Windows.Forms.RadioButton radio_tenmh;
        private System.Windows.Forms.RadioButton radio_mamh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listview_kqtimkiem;
    }
}