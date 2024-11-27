namespace Ex01_lab9
{
    partial class Yc4a_FrmTimKiemKH
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_makh = new System.Windows.Forms.RadioButton();
            this.radio_tenkh = new System.Windows.Forms.RadioButton();
            this.radio_sdt = new System.Windows.Forms.RadioButton();
            this.txt_noidungTK = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listview_kqtimkiem = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.txt_noidungTK);
            this.groupBox1.Controls.Add(this.radio_sdt);
            this.groupBox1.Controls.Add(this.radio_tenkh);
            this.groupBox1.Controls.Add(this.radio_makh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.listview_kqtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm theo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nội dung tìm kiếm";
            // 
            // radio_makh
            // 
            this.radio_makh.AutoSize = true;
            this.radio_makh.Location = new System.Drawing.Point(233, 38);
            this.radio_makh.Name = "radio_makh";
            this.radio_makh.Size = new System.Drawing.Size(94, 29);
            this.radio_makh.TabIndex = 2;
            this.radio_makh.TabStop = true;
            this.radio_makh.Text = "Mã KH";
            this.radio_makh.UseVisualStyleBackColor = true;
            // 
            // radio_tenkh
            // 
            this.radio_tenkh.AutoSize = true;
            this.radio_tenkh.Location = new System.Drawing.Point(369, 38);
            this.radio_tenkh.Name = "radio_tenkh";
            this.radio_tenkh.Size = new System.Drawing.Size(101, 29);
            this.radio_tenkh.TabIndex = 3;
            this.radio_tenkh.TabStop = true;
            this.radio_tenkh.Text = "Tên KH";
            this.radio_tenkh.UseVisualStyleBackColor = true;
            // 
            // radio_sdt
            // 
            this.radio_sdt.AutoSize = true;
            this.radio_sdt.Location = new System.Drawing.Point(511, 38);
            this.radio_sdt.Name = "radio_sdt";
            this.radio_sdt.Size = new System.Drawing.Size(90, 29);
            this.radio_sdt.TabIndex = 4;
            this.radio_sdt.TabStop = true;
            this.radio_sdt.Text = "Số ĐT";
            this.radio_sdt.UseVisualStyleBackColor = true;
            // 
            // txt_noidungTK
            // 
            this.txt_noidungTK.Location = new System.Drawing.Point(233, 98);
            this.txt_noidungTK.Name = "txt_noidungTK";
            this.txt_noidungTK.Size = new System.Drawing.Size(261, 30);
            this.txt_noidungTK.TabIndex = 5;
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_tim.Location = new System.Drawing.Point(233, 148);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(102, 42);
            this.bt_tim.TabIndex = 6;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(392, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listview_kqtimkiem
            // 
            this.listview_kqtimkiem.HideSelection = false;
            this.listview_kqtimkiem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listview_kqtimkiem.Location = new System.Drawing.Point(6, 32);
            this.listview_kqtimkiem.Name = "listview_kqtimkiem";
            this.listview_kqtimkiem.Size = new System.Drawing.Size(636, 120);
            this.listview_kqtimkiem.TabIndex = 0;
            this.listview_kqtimkiem.UseCompatibleStateImageBehavior = false;
            this.listview_kqtimkiem.View = System.Windows.Forms.View.Details;
            // 
            // Yc4a_FrmTimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Yc4a_FrmTimKiemKH";
            this.Text = "FrmTimKiemKH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_noidungTK;
        private System.Windows.Forms.RadioButton radio_sdt;
        private System.Windows.Forms.RadioButton radio_tenkh;
        private System.Windows.Forms.RadioButton radio_makh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listview_kqtimkiem;
    }
}