namespace _2212420_TKForm1_4
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyễnÁiMừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnÁiMừngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnÁiMừngToolStripMenuItem
            // 
            this.nguyễnÁiMừngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBai1,
            this.tsmBai2,
            this.tsmBai3});
            this.nguyễnÁiMừngToolStripMenuItem.Name = "nguyễnÁiMừngToolStripMenuItem";
            this.nguyễnÁiMừngToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.nguyễnÁiMừngToolStripMenuItem.Text = "Nguyễn Ái Mừng";
            // 
            // tsmBai1
            // 
            this.tsmBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai1.Image")));
            this.tsmBai1.Name = "tsmBai1";
            this.tsmBai1.Size = new System.Drawing.Size(180, 22);
            this.tsmBai1.Text = "Bài 1";
            this.tsmBai1.Click += new System.EventHandler(this.tsmBai1_Click);
            // 
            // tsmBai2
            // 
            this.tsmBai2.BackColor = System.Drawing.Color.White;
            this.tsmBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai2.Image")));
            this.tsmBai2.Name = "tsmBai2";
            this.tsmBai2.Size = new System.Drawing.Size(180, 22);
            this.tsmBai2.Text = "Bài 2";
            // 
            // tsmBai3
            // 
            this.tsmBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai3.Image")));
            this.tsmBai3.Name = "tsmBai3";
            this.tsmBai3.Size = new System.Drawing.Size(180, 22);
            this.tsmBai3.Text = "Bài 3";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnÁiMừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmBai3;
    }
}

