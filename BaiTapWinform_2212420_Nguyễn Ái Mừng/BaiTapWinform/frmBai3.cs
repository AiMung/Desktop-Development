using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinform
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        //click vào nút kết quả
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int a=int.Parse(txtSoA.Text);
            int b=int .Parse(txtSoB.Text);  
            int n=int.Parse(txtSoN.Text);
            int kq = 0;
            if (rbTongAB.Checked)
            {
            TinhToan.CongHaiSo(a, b, ref kq);

            }
            else
               kq= TinhToan.TongDaySo(n);
            //hiển thị kết quả
            lblKetQua.Text=kq.ToString();

        }
    }
}
