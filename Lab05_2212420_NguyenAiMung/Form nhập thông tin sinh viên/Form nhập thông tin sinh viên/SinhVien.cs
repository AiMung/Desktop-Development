using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_nhập_thông_tin_sinh_viên
{
   public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten { get; set; } 
        public DateTime NgaySinh { get; set; }  
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public bool GioiTinh { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public List<string> MonHoc {  get; set; }
        //phương thức tạo lập mặc định
        public SinhVien()
        {
            MonHoc=new List<string>();
        }

        public SinhVien(string mSSV, string hoVaTenLot, string ten, DateTime ngaySinh, string diaChi, string lop, bool gioiTinh, string soCMND, string soDT, List<string> monHoc)
        {
            MSSV = mSSV;
            HoVaTenLot = hoVaTenLot;
            Ten = ten;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Lop = lop;
            GioiTinh = gioiTinh;
            SoCMND = soCMND;
            SoDT = soDT;
            MonHoc = monHoc;
        }
    }
}
