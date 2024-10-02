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
    public partial class Form1 : Form
    {
        QLSinhVien qlsv;

        public Form1()
        {
            InitializeComponent();
        }
        #region phuong thuc bo tro
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mh = new List<string>();     //lay thong tin tu control sinh vien
            sv.MSSV = mtxtMSSV.Text;
            sv.HoVaTenLot = txtHoVaTenLot.Text;
            sv.Ten = txtTen.Text; ;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.DiaChi = txtDiaChi.Text;
            sv.Lop = cbbLop.Text;
            if (rbNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.SoCMND = mtxtSoCMND.Text;
            sv.SoDT = mtxtSoDT.Text;
            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                if (clbMonHoc.GetItemChecked(i))
                    mh.Add(clbMonHoc.Items[i].ToString());
            sv.MonHoc = mh;

            sv.MonHoc = mh;
            return sv;



        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoVaTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.DiaChi = lvitem.SubItems[4].Text;
            sv.Lop = lvitem.SubItems[5].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[6].Text == "Nam")
                sv.GioiTinh = true;
            sv.SoCMND = lvitem.SubItems[7].Text;
            sv.SoDT = lvitem.SubItems[8].Text;
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string s2 in s)
                mh.Add(s2);
            sv.MonHoc = mh;
            return sv;

        }
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoVaTenLot.Text = sv.HoVaTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbbLop.Text = sv.Lop;
            if (sv.GioiTinh)
                rbNam.Checked = true;
            else rbNu.Checked = true;
            this.mtxtSoCMND.Text = sv.SoCMND;
            this.mtxtSoDT.Text = sv.SoDT;
            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                this.clbMonHoc.SetItemChecked(i, false);
            foreach (string s in sv.MonHoc)
            {
                for (int i = 0; i < this.clbMonHoc.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbMonHoc.Items[i]) == 0)
                        this.clbMonHoc.SetItemChecked(i,
                        true);
            }






        }
        //them sinh vien vao list view
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoVaTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.SoDT);
            string mh = "";
            foreach (string s in sv.MonHoc)
                mh += s + ",";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvDanhSach.Items.Add(lvitem);

        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvDanhSach.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        #endregion

        #region cac su kien
        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QLSinhVien();
            qlsv.DocTuFile();
            LoadListView();


        }

        #endregion

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDanhSach.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =this.lvDanhSach.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MSSV,
            delegate (object obj1, object obj2)
            {
                return (obj2 as
    SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn muốn thoát ứng dung", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                //// Lấy mã sinh viên từ cột đầu tiên (giả sử cột 0 là mã sinh viên)
                //string maSinhVien = lvDanhSach.SelectedItems[0].SubItems[0].Text;

                //// Xóa sinh viên trong danh sách quản lý sinh viên
                //qlsv.Xoa(maSinhVien, SoSanhTheoMa); // Hàm Xoa dựa trên mã sinh viên

                //// Cập nhật lại ListView sau khi xóa
                //LoadListView();
                foreach (ListViewItem item in lvDanhSach.CheckedItems)
                {
                    string maSinhVien = item.SubItems[0].Text; // Giả sử cột 0 là MSSV
                    qlsv.Xoa(maSinhVien, SoSanhTheoMa); // Gọi hàm xóa sinh viên trong dữ liệu
                    lvDanhSach.Items.Remove(item); // Xóa khỏi ListView
                }

            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //// Lấy thông tin sinh viên mới từ các trường nhập liệu
            //SinhVien sv = GetSinhVien();

            //// Gọi hàm Sửa để cập nhật thông tin sinh viên dựa trên MSSV
            //bool kqsua = qlsv.Sua(sv, sv.MSSV, SoSanhTheoMa);

            //// Nếu việc sửa thành công, tải lại ListView
            //if (kqsua)
            //{
            //    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.LoadListView();
            //}
            //else
            //{
            //    MessageBox.Show("Không tìm thấy sinh viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // Lấy thông tin sinh viên mới từ các trường nhập liệu
            SinhVien sv = GetSinhVien();

            // Gọi hàm Sửa để cập nhật thông tin sinh viên dựa trên MSSV
            bool kqsua = qlsv.Sua(sv, sv.MSSV, SoSanhTheoMa);

            // Nếu việc sửa thành công, tải lại ListView
            if (kqsua)
            {
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadListView(); // Tải lại danh sách sinh viên sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TimKiem(string dieuKien, string giaTri)
        {
            // Dọn sạch ListView trước khi thêm kết quả tìm kiếm mới
            ListViewItem[] allItems = new ListViewItem[lvDanhSach.Items.Count];
            lvDanhSach.Items.CopyTo(allItems, 0); // Sao lưu toàn bộ danh sách ban đầu

            lvDanhSach.Items.Clear();

            foreach (ListViewItem item in allItems)
            {
                bool isMatch = false;

                switch (dieuKien)
                {
                    case "MSSV":
                        if (item.SubItems[0].Text.Equals(giaTri, StringComparison.OrdinalIgnoreCase))
                            isMatch = true;
                        break;

                    case "Tên":
                        if (item.SubItems[2].Text.Equals(giaTri, StringComparison.OrdinalIgnoreCase))
                            isMatch = true;
                        break;

                    case "Lớp":
                        if (item.SubItems[5].Text.Equals(giaTri, StringComparison.OrdinalIgnoreCase))
                            isMatch = true;
                        break;
                }

                // Nếu tìm kiếm trùng khớp, thêm mục vào ListView
                if (isMatch)
                {
                  item.BackColor= Color.Red; 
                }
                lvDanhSach.Items.Add(item);
                if (lvDanhSach.Items.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Thông báo nếu không có kết quả phù hợp
            if (lvDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem formTimKiem = new frmTimKiem())
            {
                if (formTimKiem.ShowDialog() == DialogResult.OK)
                {
                    string dieuKien = formTimKiem.DieuKien;
                    string giaTri = formTimKiem.GiaTri;

                    // Gọi phương thức tìm kiếm dựa trên điều kiện
                    TimKiem(dieuKien, giaTri);
                }
            }
        }
        
        private void thêmMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmThemMon formNhapMon = new frmThemMon())
            {
                if (formNhapMon.ShowDialog() == DialogResult.OK)
                {
                    string tenMonMoi = formNhapMon.TenMon;

                    if (!string.IsNullOrWhiteSpace(tenMonMoi))
                    {
                        // Thêm môn học vào CheckedListBox
                        clbMonHoc.Items.Add(tenMonMoi);

                        // Thêm vào danh sách môn học của sinh viên (nếu cần)
                        // sinhVien.MonHoc.Add(tenMonMoi);
                    }
                    else
                    {
                        MessageBox.Show("Tên môn học không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void xoáToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có môn học nào được chọn không
            if (clbMonHoc.CheckedItems.Count > 0)
            {
                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các môn đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Duyệt ngược qua danh sách để xóa các môn đã chọn
                    for (int i = clbMonHoc.CheckedItems.Count - 1; i >= 0; i--)
                    {
                        string tenMon = clbMonHoc.CheckedItems[i].ToString();

                        // Xóa môn khỏi CheckedListBox
                        clbMonHoc.Items.Remove(tenMon);

                        // Nếu bạn có danh sách môn học trong sinh viên, bạn cũng xóa khỏi đó
                        // sinhVien.MonHoc.Remove(tenMon);
                    }

                    MessageBox.Show("Đã xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn ít nhất một môn học để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

