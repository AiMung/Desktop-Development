using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong1_TongQuanVeLapTrinhGiaoDien_2212420_Nguyễn_Ái_Mừng
{
    public partial class frm60 : Form
    {
        public frm60()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s= "";
            //for(int i = 0;i<clbMonHoc.Items.Count;i++)

            //    if (this.clbMonHoc.GetItemChecked(i) == true)
            //        s += clbMonHoc.Items[i].ToString() + ",";
            //MessageBox.Show(s);
            CheckedListBox.CheckedItemCollection items;
            string s = "";
            items = this.clbMonHoc.CheckedItems;
            foreach (object ob in items)
            {
                s += ob.ToString() + ",";

            }
            MessageBox.Show(s.ToString());
        }
    }
}
