using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设备监控系统
{
    public partial class WinformsMain : Form
    {
        public WinformsMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinformsDataLook winformsDataLook = new WinformsDataLook();
            winformsDataLook.MdiParent= this;
            winformsDataLook.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            WinformsLED winformsLED = new WinformsLED();
            winformsLED.MdiParent = this;
            winformsLED.Show();
        }

      
    }

}
