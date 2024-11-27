namespace Homework_Ex01
{
    partial class frmbai1
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
            this.lbn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lbkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "S = 1 + 1/2! + 1/3! + ... + 1/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "!";
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn.Location = new System.Drawing.Point(458, 106);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(30, 32);
            this.lbn.TabIndex = 2;
            this.lbn.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập n = ";
            // 
            // txtn
            // 
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.Location = new System.Drawing.Point(278, 45);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(163, 38);
            this.txtn.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(222, 217);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(156, 48);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính tổng";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkq.Location = new System.Drawing.Point(216, 156);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(92, 32);
            this.lbkq.TabIndex = 7;
            this.lbkq.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 278);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lbkq;
    }
}

