using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_nhập_thông_tin_sinh_viên
{

    public partial class frmTimKiem : Form
    {
        public string DieuKien { get; private set; }
        public string GiaTri { get; private set; }
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DieuKien = cbbDieuKien.SelectedItem?.ToString();
            GiaTri = txtGiaTri.Text;

            if (string.IsNullOrWhiteSpace(DieuKien) || string.IsNullOrWhiteSpace(GiaTri))
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm và nhập giá trị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK; // Chỉ định kết quả
            this.Close(); // Đóng form
        }
    }
}

