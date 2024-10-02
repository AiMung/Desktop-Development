using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_nhập_thông_tin_sinh_viên
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QLSinhVien
    {
        public List<SinhVien> DanhSach;
        public QLSinhVien()
        {
            DanhSach = new List<SinhVien>();

        }
        //them mot sinh vien vao danh sacsh
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        //xoa cac object neu thoa dieu kien
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this.DanhSach.RemoveAt(i);
                }

            }
        }
        //tim mot sinh vien thoa dieu kien
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)

                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        ////timf moot sinh vien trong danh sach thoa man dieu kien so sanh 
        ///sau do gan lai thong tin cho sinh vien nay svSua
        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count ;
            for (i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        //ham doc tu file
        public void DocTuFile()
        {
            string filename = "DSSV.txt", t;
            string[] cot;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                cot = t.Split('\t');
                sv = new SinhVien();
                sv.MSSV = cot[0];
                sv.HoVaTenLot = cot[1];
                sv.Ten = cot[2];
                sv.NgaySinh = DateTime.Parse(cot[3]);
                sv.DiaChi = cot[4];
                sv.Lop = cot[5];
                sv.GioiTinh = true;
                if (cot[6] == "0")
                    sv.GioiTinh = false;


                sv.SoCMND = cot[7];
                sv.SoDT = cot[8];

                string[] mh = cot[9].Split(',');
                foreach (string c in mh)
                    sv.MonHoc.Add(c);
                this.Them(sv);

            }


        }

    }
}
