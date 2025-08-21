using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 设备监控系统
{
    public partial class WinformsFigues : Form
    {
        Series series1 = new Series("温度监测");
        Series series2 = new Series("湿度监测");
        Series series3 = new Series("亮度监测");
        public WinformsFigues()
        {
            InitializeComponent();
          
            InitializeTimer();
        }
        bool Cancel_load = false;
        private System.Windows.Forms.Timer timer1;

        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1秒更新一次
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private async void WinformsFigues_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            checked1.Checked = true;
            checked2.Checked = true;
            checked3.Checked = true;


         

            
           

            series1.Color = Color.Red;
            series1.ChartType = SeriesChartType.Line;  // 设置为折线图
            series1.XValueType = ChartValueType.DateTime;
            series2.Color = Color.Blue;
            series2.ChartType = SeriesChartType.Line;  // 设置为折线图
            series2.XValueType = ChartValueType.DateTime;
            series3.Color = Color.Yellow;
            series3.ChartType = SeriesChartType.Line;  // 设置为折线图
            series3.XValueType = ChartValueType.DateTime;

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            
            while (!Cancel_load)
            {

                this.Invoke(() =>
                {
                    string Current_time = DateTime.Now.ToString();
                    string Current_Temperature = EquipmentCurrentModel.Temperature.ToString();
                    string Current_Brightness = EquipmentCurrentModel.Brightness.ToString();
                    string Current_Humidty = EquipmentCurrentModel.Humidty.ToString();

                    ListViewItem item = new ListViewItem(Current_time); // 第一列值
                    item.SubItems.Add(Current_Temperature); // 第二列
                    item.SubItems.Add(Current_Brightness);  // 第三列
                    item.SubItems.Add(Current_Humidty);  // 第四列

                    listView1.Items.Insert(0, item);


                   


                });
                await Task.Delay(1000);

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime newX = DateTime.Now;
            double newY1 = EquipmentCurrentModel.Temperature;
            double newY2 = EquipmentCurrentModel.Humidty;
            double newY3 = EquipmentCurrentModel.Brightness;
            series1.Points.AddXY(newX, newY1);
            series2.Points.AddXY(newX, newY2);
            series3.Points.AddXY(newX, newY3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancel_load = true;
            this.Close();

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            string seriesName = chk.Name.ToString();
            if (chk.Checked == true)
            {
                AddSeries(seriesName, chk.ForeColor);

            }
            else if (chk.Checked == false)
            {
                RemoveSeries(seriesName);
            }

        }

        private void RemoveSeries(string seriesName)
        {
            if (chart1.Series.Count > 0)
            {
                Series series = chart1.Series.FindByName(seriesName);
                if (series != null)
                    chart1.Series.Remove(series);
            }

        }

        private void AddSeries(string seriesName, Color color)
        {

            Series series = new Series(seriesName);
            series.ChartType = SeriesChartType.Spline;
            series.Tag = seriesName;
            series.BorderWidth = 2;
            series.Color = color;
            series.XValueType = ChartValueType.DateTime;
            chart1.Series.Add(series);
        }
    }
}
