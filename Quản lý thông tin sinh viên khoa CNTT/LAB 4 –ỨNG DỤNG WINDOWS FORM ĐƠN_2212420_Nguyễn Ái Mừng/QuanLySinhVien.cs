using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4__ỨNG_DỤNG_WINDOWS_FORM_ĐƠN_2212420_Nguyễn_Ái_Mừng
{
    public delegate int SoSanh(object x, object y);
    public class QuanLySinhVien
    {

        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        //thêm sinh viên vào danh sách
        public void Them(SinhVien sv)
        {
            DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        //Xoá sinh viên nếu thoải điều kiện so sánh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    DanhSach.RemoveAt(i);


        }
        //tìm một sinh viên thoã điều kiện
        public SinhVien Tim(Object obj, SoSanh ss)
        {
            SinhVien ketqua = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    ketqua = sv;
                    break;
                }
            return ketqua;
        }
        // tìm một sinh viên trong danh sách thoả điều kiện so sánh gán thông tin cho sinh viên này sinh viên sửa
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = DanhSach.Count - 1;
            for (i = 0; i <= count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        //hàm đọc sinh viên từ file
        public void DocTuFile()
        {
            string filename = "DanhSachSVKhoaCNTT.txt", t;
            string[] s;
            SinhVien sv;
          
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('\t');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HoVaTen = s[1];
                sv.Phai = false;
                if (s[2] == "1")
                    sv.Phai = false;
                sv.Phai = true;
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SoDienThoai = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                string[] cn = s[8].Split(',');
                foreach (string c in cn)
                    sv.ChuyenNganh.Add(c);
                this.Them(sv);
            }
        }

    }
}
