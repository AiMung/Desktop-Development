using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TKForm2_2212420_Nguyễn_Ái_Mừng
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            //duyệt qua toàn bộ các mặt hàng đã chọn
            //cộng dồn số tiền cho mỗi loạt hàng hoá đã mua
            foreach (string hang in listBox2.Items)
            {
                switch (hang)
                {
                    //                Chuột
                    //Bàn Phím
                    //Lót Chuột
                    //WebCam
                    //Sạc Nhanh
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn Phím":
                        soTien += 200000;
                        break;
                    case "Lót Chuột":
                        soTien += 20000;
                        break;
                    case "WebCam":
                        soTien += 300000;
                        break;
                    case "Sạc Nhanh":
                        soTien += 230000;
                        break;

                }
                lblThanhTien.Text = soTien + " Đồng";
            }
        }
    }
}
