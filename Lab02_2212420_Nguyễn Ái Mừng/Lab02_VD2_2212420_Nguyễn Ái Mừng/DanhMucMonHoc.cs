using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_VD2_2212420_Nguyễn_Ái_Mừng
{
    public class DanhMucMonHoc
    {
        public ArrayList ds;
        public DanhMucMonHoc()
        {
            ds = new ArrayList();

        }
        public MonHoc this[int index]
        { 
            get {  return (MonHoc)ds[index] as MonHoc; }
            set { ds[index] = value; }

        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc: ";
            foreach(object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }
    } 
    

}
