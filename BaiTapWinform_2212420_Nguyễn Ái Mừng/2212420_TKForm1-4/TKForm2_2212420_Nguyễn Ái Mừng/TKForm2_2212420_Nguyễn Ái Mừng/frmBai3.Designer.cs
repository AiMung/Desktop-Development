namespace TKForm2_2212420_Nguyễn_Ái_Mừng
{
    partial class frmBai3
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
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.lblDanhSachTu = new System.Windows.Forms.Label();
            this.lblNghiaCuTu = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtHienThiKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa của từ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(179, 52);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(196, 22);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(179, 95);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(196, 22);
            this.txtNghiaCuaTu.TabIndex = 1;
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(204, 144);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(108, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // lblDanhSachTu
            // 
            this.lblDanhSachTu.AutoSize = true;
            this.lblDanhSachTu.Location = new System.Drawing.Point(77, 206);
            this.lblDanhSachTu.Name = "lblDanhSachTu";
            this.lblDanhSachTu.Size = new System.Drawing.Size(109, 16);
            this.lblDanhSachTu.TabIndex = 0;
            this.lblDanhSachTu.Text = "Danh sách từ mới";
            // 
            // lblNghiaCuTu
            // 
            this.lblNghiaCuTu.AutoSize = true;
            this.lblNghiaCuTu.Location = new System.Drawing.Point(587, 206);
            this.lblNghiaCuTu.Name = "lblNghiaCuTu";
            this.lblNghiaCuTu.Size = new System.Drawing.Size(108, 16);
            this.lblNghiaCuTu.TabIndex = 0;
            this.lblNghiaCuTu.Text = "Nghĩa của từ mới";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(80, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 148);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtHienThiKetQua
            // 
            this.txtHienThiKetQua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtHienThiKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThiKetQua.ForeColor = System.Drawing.SystemColors.Info;
            this.txtHienThiKetQua.Location = new System.Drawing.Point(544, 235);
            this.txtHienThiKetQua.Multiline = true;
            this.txtHienThiKetQua.Name = "txtHienThiKetQua";
            this.txtHienThiKetQua.ReadOnly = true;
            this.txtHienThiKetQua.Size = new System.Drawing.Size(196, 148);
            this.txtHienThiKetQua.TabIndex = 2;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtHienThiKetQua);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblNghiaCuTu);
            this.Controls.Add(this.lblDanhSachTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.Label lblDanhSachTu;
        private System.Windows.Forms.Label lblNghiaCuTu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtHienThiKetQua;
    }
}