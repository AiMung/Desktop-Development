using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWinform
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;

        }
        public static int  TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += i;

            }
            return tong;
        }
    }
}
