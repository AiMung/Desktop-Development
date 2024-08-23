using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong1_TongQuanVeLapTrinhGiaoDien_2212420_Nguyễn_Ái_Mừng
{
    public partial class frm57 : Form
    {
        public frm57()
        {
            InitializeComponent();
        }

        private void cbkMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbkMauChu.Checked)
                this.btnButton.ForeColor = Color.Red;
            else
                this.btnButton.ForeColor = Color.Black;
        }

        private void cbkMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbkMauNen.Checked)
                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.btnButtonFlat.BackColor;
        }

        private void rbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbFlat.Checked)
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
        }
    }
}
