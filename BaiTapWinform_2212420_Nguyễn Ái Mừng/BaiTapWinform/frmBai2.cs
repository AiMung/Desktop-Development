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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        { //lấy thứ tự các mặt hàng được chọn
            //theo thứ tự chuột 0:,máy in:1,bàn phím :2
            var stt = cbbHangHoa.SelectedIndex;
            switch (stt)
            {//0,1,2 là vị trí của các mặt hàng trong danh sách
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int donGia=int.Parse(txtDonGia.Text);
            int soLuong=int.Parse(txtSoLuong.Text);
            double thanhTien = donGia*soLuong;

            if (rbChuyenKhoan.Checked)
            {
                thanhTien = donGia * soLuong *0.95;
            }
            //hiển thị kết quả
            lblSoTien.Text = thanhTien.ToString();
        }
    }
}
