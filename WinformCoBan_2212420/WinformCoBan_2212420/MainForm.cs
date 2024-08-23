using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCoBan_2212420
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap=txtNhapTen.Text;
            MessageBox.Show($"chào bạn {tenDaNhap},rất vui được gặp bạn","LỜI CHÀO HỆ THỐNG");

        }
        //ví dụ ở trên nhập gì thì ở dưới sẽ xuất hiện giống vậy
        //do textbox sao chép chỉ hiển thị nội dung sao chép nên cần chỉnh readonly thành true
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtNhapTen.Text;

        }

      

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text=txtNhapTen.Text;    

        }

        //bây giờ muốn xử lý sự kiên ở ô trên viết gì thì ô dưới sẽ tự động sao chép lại mà không cần đến thao tác sao chép_click
    }
}
