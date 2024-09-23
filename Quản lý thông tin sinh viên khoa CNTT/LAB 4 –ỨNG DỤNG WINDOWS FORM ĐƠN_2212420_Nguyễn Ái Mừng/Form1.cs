using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_4__ỨNG_DỤNG_WINDOWS_FORM_ĐƠN_2212420_Nguyễn_Ái_Mừng
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        #region Phương thức bổ trợ
        //Lấy thông tin từ controls thông tin SV
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoVaTen = this.txtHoVaTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cbbLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rbNữ.Checked)
                gt = false;
            sv.Phai = gt;
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i))
                    cn.Add(checkedListBox1.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoVaTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.Phai = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.Phai = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoVaTen.Text = sv.HoVaTen;
            if (sv.Phai)
                this.rbNam.Checked = true;
            else
                this.rbNữ.Checked = true;
this.dtpNgaySinh.Value = sv.NgaySinh; 
            this.cbbLop.Text = sv.Lop; 

            this.txtDiaChi.Text = sv.DiaChi;
         
            this.txtHinh.Text = sv.Hinh;
            this.pictureBox1.ImageLocation = sv.Hinh;
           
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                this.checkedListBox1.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.checkedListBox1.Items[i]) == 0)
                        this.checkedListBox1.SetItemChecked(i,
                        true);
            }
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoVaTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.Phai)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvDanhSachSinhVien.Items.Add(lvitem);
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvDanhSachSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        #endregion

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog MoHinhAnh=new OpenFileDialog();
            MoHinhAnh.Filter = "Image File|*.jpeg;*.jpg;*.png;*.bmp;";
            if(openFileLg.ShowDialog() == DialogResult.OK)
            {
                try {txtHinh.Text = openFileLg.FileName;
                pictureBox1.Image=Image.FromFile(openFileLg.FileName); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể mở file này vì phần mở rộng không phù hợp","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHinh.Text=String.Empty;
                }

            }else
                {
                MessageBox.Show("Bạn chưa chọn hình ảnh","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }   


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Bạn chắc chắn muốn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes) { Application.Exit(); }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
  //Khi chọn dòng sinh viên bên ListView
        //thực hiện gán thông tin lên các control
        private void lvDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDanhSachSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvDanhSachSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
    }
}
