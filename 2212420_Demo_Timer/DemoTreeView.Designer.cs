namespace _2212420_Demo_Timer
{
    partial class frmTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            this.treeViewThucVat = new System.Windows.Forms.TreeView();
            this.treeViewImage = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeViewThucVat
            // 
            this.treeViewThucVat.ImageIndex = 0;
            this.treeViewThucVat.ImageList = this.treeViewImage;
            this.treeViewThucVat.Location = new System.Drawing.Point(268, 84);
            this.treeViewThucVat.Name = "treeViewThucVat";
            this.treeViewThucVat.SelectedImageIndex = 0;
            this.treeViewThucVat.Size = new System.Drawing.Size(297, 202);
            this.treeViewThucVat.TabIndex = 0;
            // 
            // treeViewImage
            // 
            this.treeViewImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImage.ImageStream")));
            this.treeViewImage.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImage.Images.SetKeyName(0, "background.jpg");
            this.treeViewImage.Images.SetKeyName(1, "icon password.jpg");
            this.treeViewImage.Images.SetKeyName(2, "icon user.jpg");
            this.treeViewImage.Images.SetKeyName(3, "icon user1.jpeg");
            this.treeViewImage.Images.SetKeyName(4, "iml1.jpg");
            this.treeViewImage.Images.SetKeyName(5, "iml2.jpg");
            this.treeViewImage.Images.SetKeyName(6, "iml3.jpg");
            this.treeViewImage.Images.SetKeyName(7, "iml4.jpg");
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewThucVat);
            this.Name = "frmTreeView";
            this.Text = "DemoTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewThucVat;
        private System.Windows.Forms.ImageList treeViewImage;
    }
}