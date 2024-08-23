using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212420_Demo_Timer
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            TreeNode rNode, cNode;
            rNode = this.treeViewThucVat.Nodes.Add("Các loại icon");
            rNode.ImageIndex = 0;
            cNode = new TreeNode("icon lock");
            cNode.ImageIndex = 1;
            rNode.Nodes.Add(cNode);
            cNode = new TreeNode("icon user", 2, 2);
            rNode.Nodes.Add(cNode);
            rNode = this.treeViewThucVat.Nodes.Add("hình ảnh cá nhân");
            rNode.ImageIndex = 3;
            cNode = new TreeNode("con rồng");
            cNode.ImageIndex = 4;
            rNode.Nodes.Add(cNode);
            cNode = new TreeNode("dây xích");
            cNode.ImageIndex = 5;
            rNode.Nodes.Add(cNode);

        }
    }
}
