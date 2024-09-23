using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4__ỨNG_DỤNG_WINDOWS_FORM_ĐƠN_2212420_Nguyễn_Ái_Mừng
{
   public class SinhVien
    {//các thuộc tính của lớp sinh viên
        public string MSSV { get; set; }
        public string HoVaTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Phai { get; set; }
        public string Lop { get; set; }
        public string SoDienThoai { get; set; }
        public string Hinh { get; set; }
        public List<string>ChuyenNganh { get; set; } = new List<string>();
        //phương thức tạo lập
        public SinhVien()
        {
            
        }
        public SinhVien(string mSSV, string hoVaTen, string email, string diaChi, DateTime ngaySinh, bool phai, string lop, string soDienThoai,string hinh, List<string> chuyenNganh)
        {
            MSSV = mSSV;
            HoVaTen = hoVaTen;
            Email = email;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Phai = phai;
            Lop = lop;
            SoDienThoai = soDienThoai;
            Hinh = hinh;
            ChuyenNganh = chuyenNganh;
        }
    }
}
