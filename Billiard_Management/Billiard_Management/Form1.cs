using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_Management
{
    public partial class frmTrangChu : Form
    {
       

        public frmTrangChu()
        {
            InitializeComponent();
            timerNgayVaGio.Start();
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            ToolTip toolTip1 = new ToolTip();

            // Thiết lập thuộc tính cho ToolTip (tùy chọn)
            toolTip1.AutoPopDelay = 2000;   // Thời gian hiển thị ToolTip (tính bằng mili giây)
            toolTip1.InitialDelay = 100;   // Thời gian delay trước khi ToolTip xuất hiện
            toolTip1.ReshowDelay = 5000;     // Thời gian delay giữa các lần xuất hiện ToolTip
          /*  toolTip1.ShowAlways = true;  */   // Cho phép ToolTip hiển thị ngay cả khi control không được chọn

            // Gán ToolTip cho một Button
            toolTip1.SetToolTip(this.button1, "Giá Bàn:35.000đ"+ Environment.NewLine+"Loại bàn:Libre");


        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnChon.Height = btnTrangChu.Height;
            pnChon.Top= btnTrangChu.Top;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnChon.Height= btnSanPham.Height;
            pnChon.Top = btnSanPham.Top;
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            pnChon.Height=btnTonKho.Height;
            pnChon.Top=btnTonKho.Top;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnChon.Height = btnNhanVien.Height;
            pnChon.Top = btnNhanVien.Top;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnChon.Height=btnDoanhThu.Height;
            pnChon.Top = btnDoanhThu.Top;
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            pnChon.Height=btnHuongDan.Height;
            pnChon.Top= btnHuongDan.Top;
        }


        int i = 0;
     
        
        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
      
            lblSoLuong.Show();
            i++;
            lblSoLuong.Text = i.ToString();
        }









        private void button1_Click(object sender, EventArgs e)
        {
            timerNgayVaGio.Stop();
            DateTime now = DateTime.Now;

            // Thiết lập văn hóa Việt Nam
            CultureInfo viCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = viCulture;
            Thread.CurrentThread.CurrentUICulture = viCulture;

            // Định dạng ngày giờ với tên tháng và ngày trong tuần
            string formattedDate = now.ToString("dddd, DD MMMM YYYY HH:mm:ss", viCulture);
            Console.WriteLine(formattedDate); // Kết quả ví dụ: Thứ sáu, 02 tháng 8 2024 14:30:45
            lblGioBatDau.Text = now.ToString("HH:mm:ss-dddd, dd MMMM yyyy ", viCulture);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(lblGioBatDau.Text=="...")
            {
                MessageBox.Show("Không thể thanh toán vì chưa có thời gian bắt đầu");
                lblGioKetThuc.Text = "...";
            }
            else { timerNgayVaGio.Stop();
            DateTime now = DateTime.Now;

            // Thiết lập văn hóa Việt Nam
            CultureInfo viCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = viCulture;
            Thread.CurrentThread.CurrentUICulture = viCulture;

            // Định dạng ngày giờ với tên tháng và ngày trong tuần
            string formattedDate = now.ToString("dddd, dd MMMM yyyy HH:mm:ss", viCulture);
            Console.WriteLine(formattedDate); // Kết quả ví dụ: Thứ sáu, 02 tháng 8 2024 14:30:45
            lblGioKetThuc.Text = now.ToString("HH:mm:ss-dddd, dd MMMM yyyy ", viCulture);}
            
     
        }

     
    }
}
