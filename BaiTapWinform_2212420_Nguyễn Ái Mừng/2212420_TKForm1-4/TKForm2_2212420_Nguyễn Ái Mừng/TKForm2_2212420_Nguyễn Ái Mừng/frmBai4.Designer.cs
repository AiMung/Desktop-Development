namespace TKForm2_2212420_Nguyễn_Ái_Mừng
{
    partial class frmBai4
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
            this.btnTimSo = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbDanhSachSo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimSo
            // 
            this.btnTimSo.Location = new System.Drawing.Point(460, 193);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(75, 23);
            this.btnTimSo.TabIndex = 0;
            this.btnTimSo.Text = "Tìm Số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(460, 165);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(100, 22);
            this.txtNhapSo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số cần tìm";
            // 
            // lsbDanhSachSo
            // 
            this.lsbDanhSachSo.FormattingEnabled = true;
            this.lsbDanhSachSo.ItemHeight = 16;
            this.lsbDanhSachSo.Location = new System.Drawing.Point(53, 69);
            this.lsbDanhSachSo.Name = "lsbDanhSachSo";
            this.lsbDanhSachSo.Size = new System.Drawing.Size(263, 292);
            this.lsbDanhSachSo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(462, 274);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(73, 32);
            this.lblThongBao.TabIndex = 2;
            this.lblThongBao.Text = "......................\r\n\r\n";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbDanhSachSo);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnTimSo);
            this.Name = "frmBai4";
            this.Text = "frm4";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbDanhSachSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongBao;
    }
}