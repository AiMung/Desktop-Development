using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212420_TKForm1_4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

   

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "15000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(txtDonGia.Text)*int.Parse(txtSoLuong.Text);    
            lblSoTien.Text = soTien.ToString();
        }

        private void rbMauDen_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "45000";
        }
    }
}
