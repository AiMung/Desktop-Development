namespace Chuong1_TongQuanVeLapTrinhGiaoDien_2212420_Nguyễn_Ái_Mừng
{
    partial class frm57
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.cbkMauChu = new System.Windows.Forms.CheckBox();
            this.cbkMauNen = new System.Windows.Forms.CheckBox();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.ForeColor = System.Drawing.Color.Red;
            this.btnButton.Location = new System.Drawing.Point(71, 63);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(145, 48);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonFlat.Location = new System.Drawing.Point(71, 140);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(145, 49);
            this.btnButtonFlat.TabIndex = 1;
            this.btnButtonFlat.Text = " Button Flat";
            this.btnButtonFlat.UseVisualStyleBackColor = true;
            // 
            // cbkMauChu
            // 
            this.cbkMauChu.AutoSize = true;
            this.cbkMauChu.Location = new System.Drawing.Point(285, 65);
            this.cbkMauChu.Name = "cbkMauChu";
            this.cbkMauChu.Size = new System.Drawing.Size(135, 20);
            this.cbkMauChu.TabIndex = 2;
            this.cbkMauChu.Text = "Thay đổi màu chữ";
            this.cbkMauChu.UseVisualStyleBackColor = true;
            this.cbkMauChu.CheckedChanged += new System.EventHandler(this.cbkMauChu_CheckedChanged);
            // 
            // cbkMauNen
            // 
            this.cbkMauNen.AutoSize = true;
            this.cbkMauNen.Location = new System.Drawing.Point(285, 91);
            this.cbkMauNen.Name = "cbkMauNen";
            this.cbkMauNen.Size = new System.Drawing.Size(136, 20);
            this.cbkMauNen.TabIndex = 3;
            this.cbkMauNen.Text = "Thay đổi màu nền";
            this.cbkMauNen.UseVisualStyleBackColor = true;
            this.cbkMauNen.CheckedChanged += new System.EventHandler(this.cbkMauNen_CheckedChanged);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(285, 142);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(79, 20);
            this.rbFlat.TabIndex = 4;
            this.rbFlat.TabStop = true;
            this.rbFlat.Text = "Kiểu Flat";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(285, 169);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(97, 20);
            this.rbPopup.TabIndex = 5;
            this.rbPopup.TabStop = true;
            this.rbPopup.Text = "Kiểu Popup";
            this.rbPopup.UseVisualStyleBackColor = true;
            // 
            // frm57
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.rbPopup);
            this.Controls.Add(this.rbFlat);
            this.Controls.Add(this.cbkMauNen);
            this.Controls.Add(this.cbkMauChu);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "frm57";
            this.Text = "Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.CheckBox cbkMauChu;
        private System.Windows.Forms.CheckBox cbkMauNen;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbPopup;
    }
}