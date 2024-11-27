namespace VD4
{
    partial class frmVD4
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trám răng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(113, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(358, 419);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(119, 44);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleanCost.Location = new System.Drawing.Point(354, 153);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(85, 22);
            this.lblCleanCost.TabIndex = 9;
            this.lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteningCost.Location = new System.Drawing.Point(354, 199);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(100, 22);
            this.lblWhiteningCost.TabIndex = 10;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRayCost.Location = new System.Drawing.Point(354, 246);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(85, 22);
            this.lblXRayCost.TabIndex = 11;
            this.lblXRayCost.Text = "$200.000";
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillCost.Location = new System.Drawing.Point(354, 294);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(103, 22);
            this.lblFillCost.TabIndex = 12;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // numFilling
            // 
            this.numFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFilling.Location = new System.Drawing.Point(161, 294);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(92, 28);
            this.numFilling.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(299, 359);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(222, 28);
            this.txtTotal.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(240, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 28);
            this.txtName.TabIndex = 15;
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClean.Location = new System.Drawing.Point(55, 153);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(93, 26);
            this.chkClean.TabIndex = 16;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhitening.Location = new System.Drawing.Point(55, 198);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(109, 26);
            this.chkWhitening.TabIndex = 17;
            this.chkWhitening.Text = "Tẩy trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXRay.Location = new System.Drawing.Point(55, 245);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(155, 26);
            this.chkXRay.TabIndex = 18;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // frmVD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 503);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVD4";
            this.Text = "Dental Payment Application";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.CheckBox chkXRay;
    }
}

