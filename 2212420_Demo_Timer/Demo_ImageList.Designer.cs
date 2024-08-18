namespace _2212420_Demo_Timer
{
    partial class Demo_ImageList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo_ImageList));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChonHinh = new System.Windows.Forms.ComboBox();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.imlDemo = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình ảnh hiển thị";
            // 
            // cbbChonHinh
            // 
            this.cbbChonHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonHinh.FormattingEnabled = true;
            this.cbbChonHinh.Location = new System.Drawing.Point(247, 82);
            this.cbbChonHinh.Name = "cbbChonHinh";
            this.cbbChonHinh.Size = new System.Drawing.Size(162, 24);
            this.cbbChonHinh.TabIndex = 1;
            this.cbbChonHinh.SelectedIndexChanged += new System.EventHandler(this.cbbChonHinh_SelectedIndexChanged);
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinhAnh.Location = new System.Drawing.Point(85, 112);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(256, 256);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 2;
            this.pbHinhAnh.TabStop = false;
            // 
            // imlDemo
            // 
            this.imlDemo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDemo.ImageStream")));
            this.imlDemo.TransparentColor = System.Drawing.Color.Transparent;
            this.imlDemo.Images.SetKeyName(0, "iml1.jpg");
            this.imlDemo.Images.SetKeyName(1, "iml2.jpg");
            this.imlDemo.Images.SetKeyName(2, "iml3.jpg");
            this.imlDemo.Images.SetKeyName(3, "iml4.jpg");
            // 
            // Demo_ImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.pbHinhAnh);
            this.Controls.Add(this.cbbChonHinh);
            this.Controls.Add(this.label1);
            this.Name = "Demo_ImageList";
            this.Text = "Demo_ImageList";
            this.Load += new System.EventHandler(this.Demo_ImageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChonHinh;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.ImageList imlDemo;
    }
}