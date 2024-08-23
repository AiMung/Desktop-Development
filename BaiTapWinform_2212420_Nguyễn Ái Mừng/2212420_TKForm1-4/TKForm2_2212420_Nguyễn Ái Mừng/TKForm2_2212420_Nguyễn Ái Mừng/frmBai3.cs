using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKForm2_2212420_Nguyễn_Ái_Mừng
{
    public partial class frmBai3 : Form
    {
        List<string>list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tu=txtTuMoi.Text;
            var nghia=txtNghiaCuaTu.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtNghiaCuaTu.Text= "";
            txtTuMoi.Text = "";
           listBox1.SelectedIndex=listBox1.Items.Count-1;//chọn phần tử cuối cùng
            txtHienThiKetQua.Text= nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//lấy số thứ tự của từ trong listbox1
            var stt = listBox1.SelectedIndex;
            //tra nghĩa của từ dựa theo số thứ tự
            txtHienThiKetQua.Text= list[stt];


        }
    }
}
