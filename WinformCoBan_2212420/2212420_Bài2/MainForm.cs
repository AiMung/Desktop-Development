using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212420_Bài2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Xử lý sự kiện người dùng chọn giới tính nam
        //đây là sự kiện mà khi thay đổi thì khi chọn hay bỏ chọn màn hình sẽ xuất ra thông báo
        //nếu muốn đúng thì thêm điều kiện if là xong

        private void tbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNam.Checked) 
            MessageBox.Show("bạn đã chọn giới tính nam", "THÔNG BÁO HỆ THỐNG");
            else
            MessageBox.Show("bạn đã chọn giới tính nữ", "THÔNG BÁO HỆ THỐNG");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rbDo.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rbXanh.Checked)
                txtHopMau.BackColor = Color.Green;
        }
    }
}
