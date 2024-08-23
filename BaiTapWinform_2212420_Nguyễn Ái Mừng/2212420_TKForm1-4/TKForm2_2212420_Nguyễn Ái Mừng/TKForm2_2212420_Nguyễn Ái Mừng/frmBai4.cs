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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for (int i = 0; i < 10; i++)
            {
                so = random.Next(1, 100);
                lsbDanhSachSo.Items.Add(so);

            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            var SoCanTim = int.Parse(txtNhapSo.Text);
            lblThongBao.Text = "Không có số này trong danh sách"; 
            foreach (int so in lsbDanhSachSo.Items) 
            {
                if (so == SoCanTim)
                {
                    lblThongBao.Text = "Có số này trong danh sách";
                    break;
                }

            }
        }
       
}
}

