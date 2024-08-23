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
    public partial class Demo_ImageList : Form
    {
        public Demo_ImageList()
        {
            InitializeComponent();
        }

        private void cbbChonHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbHinhAnh.Image = imlDemo.Images[cbbChonHinh.SelectedIndex];
        }

        private void Demo_ImageList_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= imlDemo.Images.Count; i++)
            {
                cbbChonHinh.Items.Add("Hình " + i);
            }
        }
    }
}
