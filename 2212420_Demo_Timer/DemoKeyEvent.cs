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
    public partial class DemoKeyEvent : Form
    {
        public DemoKeyEvent()
        {
            InitializeComponent();
        }

        private void DemoKeyEvent_KeyDown(object sender, KeyEventArgs e)
        {
            this.lblInfo.Text = "Alt:" + (e.Alt ? "Yes" : "No") + '\n' +
                "Shift:" + (e.Shift ? "Yes" : "No") + '\n' +
                "Ctrl:" + (e.Control ? "Yes" : "No") + '\n' +
             "KeyCode:" + e.KeyCode + "\n" + "KeyValue:" + e.KeyValue + "\n" +
                "KeyData:" + e.KeyData;
        }

        private void DemoKeyEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblChar.Text = e.KeyChar.ToString();

        }
    }
}
