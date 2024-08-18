using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212420_Demo_Timer
{
    public partial class DemoError : Form
    {
        public DemoError()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lỗi chương trình, bạn muốn thoát?", "Error",
MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
