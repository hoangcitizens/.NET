namespace Lab9_NguyenHuuHoang_DHTI15A5HN
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thôngTinMặtHàngToolStripMenuItem,
            this.quảnLýHợpĐồngToolStripMenuItem,
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinMặtHàngToolStripMenuItem
            // 
            this.thôngTinMặtHàngToolStripMenuItem.Name = "thôngTinMặtHàngToolStripMenuItem";
            this.thôngTinMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.thôngTinMặtHàngToolStripMenuItem.Text = "Thông tin mặt hàng";
            this.thôngTinMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinMặtHàngToolStripMenuItem_Click);
            // 
            // quảnLýHợpĐồngToolStripMenuItem
            // 
            this.quảnLýHợpĐồngToolStripMenuItem.Name = "quảnLýHợpĐồngToolStripMenuItem";
            this.quảnLýHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.quảnLýHợpĐồngToolStripMenuItem.Text = "Quản lý hợp đồng";
            this.quảnLýHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHợpĐồngToolStripMenuItem_Click);
            // 
            // quảnLýHợpĐồngVàMặtHàngToolStripMenuItem
            // 
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem.Name = "quảnLýHợpĐồngVàMặtHàngToolStripMenuItem";
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem.Text = "Quản lý hợp đồng và mặt hàng";
            this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHợpĐồngVàMặtHàngToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.Location = new System.Drawing.Point(33, 49);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(966, 629);
            this.panelContainer.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 704);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHợpĐồngVàMặtHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
    }
}