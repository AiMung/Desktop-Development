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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        //click đôi vào nút Bài 1
        private void tsbBai1_Click(object sender, EventArgs e)
        {
            //mở form bài 1 khi nhấn vào nút bài 1
            var form = new frmBai1(); 
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//mở form bài 2 khi nhấn vào nút bài 2
            var form = new frmBai2();
            form.ShowDialog();

        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            //mở form bài 3 khi nhấn vào nút bài 3
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
