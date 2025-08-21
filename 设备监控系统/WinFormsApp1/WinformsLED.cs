using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 设备监控系统
{
    public partial class WinformsLED : Form
    {
        public WinformsLED()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ushort[] ushortArray = textBox1.Text.Select(c => (ushort)c).ToArray();
            label2.Text = textBox1.Text;
            EquipmentCurrentModel.Master.WriteMultipleRegisters(
                slaveAddress: 1,//往1号从站设备写
                startAddress: 3,//从6号地址开始写 values变量有几个就依次往下写几个
                data: ushortArray //写的值
                );
            string Current_time = DateTime.Now.ToString();
            ListViewItem item = new ListViewItem(); // 第一列值
            item.SubItems.Add(Current_time); // 第二列
            item.SubItems.Add(textBox1.Text);
            listView1.Items.Add(item);
            textBox1.Text = null;

        }
    }
}
