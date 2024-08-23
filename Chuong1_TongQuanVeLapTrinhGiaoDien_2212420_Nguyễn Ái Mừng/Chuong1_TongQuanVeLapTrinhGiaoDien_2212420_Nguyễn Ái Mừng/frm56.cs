using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong1_TongQuanVeLapTrinhGiaoDien_2212420_Nguyễn_Ái_Mừng
{
    public partial class frm56 : Form
    {
        public frm56()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked) { MessageBox.Show("giới tính bạn là " + rbNam.Text); }
            
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked) { MessageBox.Show("giới tính bạn là " + rbNu.Text); }
        }
    }
}
