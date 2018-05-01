namespace QL_SieuThi.GUI
{
    partial class Main
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
            this.quanrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchQuảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanrToolStripMenuItem,
            this.quảnLýKháchQuảnToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanrToolStripMenuItem
            // 
            this.quanrToolStripMenuItem.Name = "quanrToolStripMenuItem";
            this.quanrToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.quanrToolStripMenuItem.Text = "Nhân Viên";
            this.quanrToolStripMenuItem.Click += new System.EventHandler(this.quanrToolStripMenuItem_Click);
            // 
            // quảnLýKháchQuảnToolStripMenuItem
            // 
            this.quảnLýKháchQuảnToolStripMenuItem.Name = "quảnLýKháchQuảnToolStripMenuItem";
            this.quảnLýKháchQuảnToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.quảnLýKháchQuảnToolStripMenuItem.Text = "Khách Hàng";
            this.quảnLýKháchQuảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchQuảnToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem,
            this.quanToolStripMenuItem});
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnBánHàngToolStripMenuItem
            // 
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem.Name = "quảnLýHóaĐơnBánHàngToolStripMenuItem";
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem.Text = "Quản lý hóa đơn bán hàng";
            this.quảnLýHóaĐơnBánHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // quanToolStripMenuItem
            // 
            this.quanToolStripMenuItem.Name = "quanToolStripMenuItem";
            this.quanToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.quanToolStripMenuItem.Text = "Quản lý hóa đơn nhập hàng";
            this.quanToolStripMenuItem.Click += new System.EventHandler(this.quanToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản lý Hàng Hóa";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 295);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchQuảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanToolStripMenuItem;
    }
}