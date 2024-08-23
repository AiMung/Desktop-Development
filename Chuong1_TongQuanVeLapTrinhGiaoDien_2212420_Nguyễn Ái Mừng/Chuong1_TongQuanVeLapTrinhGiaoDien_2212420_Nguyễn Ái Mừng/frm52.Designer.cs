namespace Chuong1_TongQuanVeLapTrinhGiaoDien_2212420_Nguyễn_Ái_Mừng
{
    partial class frm52
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblThamGia = new System.Windows.Forms.Label();
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.lbDanhsachchon = new System.Windows.Forms.ListBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(44, 22);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(148, 16);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lblThamGia
            // 
            this.lblThamGia.AutoSize = true;
            this.lblThamGia.Location = new System.Drawing.Point(493, 32);
            this.lblThamGia.Name = "lblThamGia";
            this.lblThamGia.Size = new System.Drawing.Size(255, 16);
            this.lblThamGia.TabIndex = 0;
            this.lblThamGia.Text = "Danh sách sinh viên lớp tham gia bóng đá";
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.ItemHeight = 16;
            this.lbDanhsach.Items.AddRange(new object[] {
            "Nguyễn Ái Mừng\t",
            "Nguyễn Hiệp Hoàng",
            "Messi",
            "Ronaldo",
            "Neymar"});
            this.lbDanhsach.Location = new System.Drawing.Point(47, 79);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(253, 276);
            this.lbDanhsach.TabIndex = 1;
            // 
            // lbDanhsachchon
            // 
            this.lbDanhsachchon.FormattingEnabled = true;
            this.lbDanhsachchon.ItemHeight = 16;
            this.lbDanhsachchon.Items.AddRange(new object[] {
            "Yasuo"});
            this.lbDanhsachchon.Location = new System.Drawing.Point(496, 79);
            this.lbDanhsachchon.Name = "lbDanhsachchon";
            this.lbDanhsachchon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsachchon.Size = new System.Drawing.Size(253, 276);
            this.lbDanhsachchon.TabIndex = 1;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(354, 149);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "ADD>>>";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "<<<DELETE";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm52
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lbDanhsachchon);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.lblThamGia);
            this.Controls.Add(this.lblDanhSach);
            this.Name = "frm52";
            this.Text = "frm52";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblThamGia;
        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.ListBox lbDanhsachchon;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnXoa;
    }
}