using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace 设备监控系统
{
    public partial class WinformsDataLook : Form
    {
        public WinformsDataLook()
        {
            InitializeComponent();
        }
        SerialPort SerialPort = new SerialPort();
        alamSet alamSet = new alamSet();
        bool[] CoilState = new bool[6];
        ushort[] ReadHoldingRegisters = new ushort[3];
        double[] ReadHoldingRegisters_double = new double[3];
        int[] ReadHoldingRegisters_int = new int[3];
        private System.Windows.Forms.Label light6;
        


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WinformsDataLook_Load(object sender, EventArgs e)
        {
            RefreshPortNames();//加载端口
            InitBuadRates();//加载波特率
            InitParitys();//加载校验位
            InitDataBit();//加载数据位
            InitStopBit();//加载停止位
            InitSlaveID();//加载从站地址

            InitEquipmentData();
        }

        private void InitEquipmentData()
        {
            label11.BackColor = Color.White;
            label19.BackColor = Color.White;
            label34.BackColor = Color.White;

            label12.Text = "0.0";
            label21.Text = "0.0";
            label32.Text = "0.0";


            label15.Text = "0.0";
            label18.Text = "0.0";
            label23.Text = "0.0";
            label26.Text = "0.0";
            label29.Text = "0.0";
            label35.Text = "0.0";




            light1.Text = "关";
            light2.Text = "关";
            light3.Text = "关";
            light4.Text = "关";
            light5.Text = "关";
            light0.Text = "全开";

            light1.BackColor = Color.Silver;
            light2.BackColor = Color.Silver;
            light3.BackColor = Color.Silver;
            light4.BackColor = Color.Silver;
            light5.BackColor = Color.Silver;
            light0.BackColor = Color.Orange;

            light1.Enabled = false;
            light2.Enabled = false;
            light3.Enabled = false;
            light4.Enabled = false;
            light5.Enabled = false;
            light0.Enabled = false;

            label51.Text = "等待设备连接....";


            button2.BackColor = Color.Blue;



        }

        private void RefreshPortNames()
        {
            comboBox1.Items.Clear();
            var portNames = SerialPort.GetPortNames();
            foreach (var portName in portNames)
                comboBox1.Items.Add(portName);
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void InitBuadRates()
        {
            comboBox2.Items.Clear();
            int[] baudrates = new int[] {
                4800,
                9600,
                14400,
                19200,
                38400,
                57600,
                115200,
                128000
            };

            foreach (int baudrate in baudrates)
            {
                comboBox2.Items.Add(baudrate);
            }
            comboBox2.SelectedItem = 9600;


        }

        private void InitParitys()
        {
            string[] paritys = Enum.GetNames(typeof(Parity));
            foreach (string name in paritys)
            {
                comboBox3.Items.Add(name);
            }

            comboBox3.SelectedItem = "None";
        }

        private void InitDataBit()
        {
            comboBox4.Items.Clear();
            comboBox4.Items.Add(8);
            comboBox4.Items.Add(16);
            comboBox4.Items.Add(32);
            comboBox4.SelectedItem = 8;
        }

        private void InitStopBit()
        {
            string[] paritys = Enum.GetNames(typeof(StopBits));
            foreach (string name in paritys)
            {
                comboBox5.Items.Add(name);
            }

            comboBox5.SelectedItem = "One";
        }

        private void InitSlaveID()
        {
            comboBox6.Items.Clear();
            string[] id = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8"
            }
            ;
            foreach (string name in id)
            {
                comboBox6.Items.Add(name);
            }
            comboBox3.SelectedItem = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshPortNames();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SetControlsEnable(!SerialPort.IsOpen);
                if (SerialPort.IsOpen)
                {
                    SerialPort.Close();
                    button2.Text = "连接设备";
                    button2.BackColor = Color.Blue;
                    label51.Text = "等待连接设备";
                    label51.ForeColor = Color.Blue;
                    InitEquipmentData();


                }
                else
                {

                    SerialPort.PortName = comboBox1.Text;
                    string[] ports = SerialPort.GetPortNames();
                    SerialPort.BaudRate = Convert.ToInt32(comboBox2.Text);
                    SerialPort.DataBits = Convert.ToInt32(comboBox4.Text);
                    SerialPort.Parity = Enum.Parse<Parity>(comboBox3.Text);
                    SerialPort.StopBits = Enum.Parse<StopBits>(comboBox5.Text);
                    SerialPort.ReadTimeout = 100000;
                    SerialPort.WriteTimeout = 100000;
                    SerialPort.ReadBufferSize = 1024;
                    SerialPort.WriteBufferSize = 1024;
                    SerialPort.Open();

                    button2.Text = "断开连接";
                    button2.BackColor = Color.Red;

                    label51.Text = "已连接设备!";
                    label51.ForeColor = Color.Green;





                    EquipmentCurrentModel.Master = ModbusSerialMaster.CreateRtu(SerialPort);

                    EquipmentStateAsync(EquipmentCurrentModel.Master);






                }





            }
            catch (Exception ex)
            {
                label51.Text = $"{ex.Message}";
                label51.ForeColor = Color.Red;

            }

        }

        private void SetControlsEnable(bool isConnected)
        {
            if (isConnected == true)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;



            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;

            }
        }
        private async void EquipmentStateAsync(IModbusSerialMaster Master)
        {

            while (SerialPort.IsOpen)
            {

                ReadHoldingRegisters = await Master.ReadHoldingRegistersAsync(
                    slaveAddress: Convert.ToByte(comboBox6.Text),//从1号从站设备读
                    startAddress: 0,//起始寄存器地址
                    numberOfPoints: 3//读取寄存器个数

                    );


                for (int a = 0; a < 3; a++)
                {
                    ReadHoldingRegisters_int[a] = ReadHoldingRegisters[a];
                    ReadHoldingRegisters_double[a] = Math.Round(ReadHoldingRegisters_int[a] * 0.1, 1);
                }
                EquipmentCurrentModel.Temperature = ReadHoldingRegisters_double[0];
                EquipmentCurrentModel.Humidty = ReadHoldingRegisters_double[1];
                EquipmentCurrentModel.Brightness = ReadHoldingRegisters_double[2];
                int current_temprature = ReadHoldingRegisters_int[0];
                int current_Humidty = ReadHoldingRegisters_int[1];
                int current_Brightness = ReadHoldingRegisters_int[2];
                this.Invoke(() =>
                {
                    label12.Text = Convert.ToString(ReadHoldingRegisters_double[0]);
                    label21.Text = Convert.ToString(ReadHoldingRegisters_double[1]);
                    label32.Text = Convert.ToString(ReadHoldingRegisters_double[2]);


                    if (current_temprature < alamSet.TemperatureLow)
                    {
                        label11.Text = "低温";
                        label11.BackColor = Color.Blue;
                    }
                    else if (current_temprature > alamSet.TemperatureHigh)
                    {
                        label11.Text = "高温";
                        label11.BackColor = Color.Red;
                    }
                    else
                    {
                        label11.Text = "正常";
                        label11.BackColor = Color.Green;
                    }

                    if (current_Humidty < alamSet.HumidtyLow)
                    {
                        label19.Text = "干燥";
                        label19.BackColor = Color.Red;
                    }
                    else if (current_Humidty > alamSet.HumidtyHigh)
                    {
                        label19.Text = "潮湿";
                        label19.BackColor = Color.Blue;
                    }
                    else
                    {
                        label19.Text = "正常";
                        label19.BackColor = Color.Green;
                    }

                    if (current_Brightness < alamSet.BrightnessLow)
                    {
                        label34.Text = "过暗";
                        label34.BackColor = Color.Blue;
                    }
                    else if (current_Brightness > alamSet.BrightnessHigh)
                    {
                        label34.Text = "过亮";
                        label34.BackColor = Color.Red;
                    }
                    else
                    {
                        label34.Text = "正常";
                        label34.BackColor = Color.Green;
                    }
                    ///////////////////灯泡

                });
                using (MyDbContext MyDb = new MyDbContext())
                {
                    int eid_slave = Convert.ToInt32(comboBox6.Text);
                    EquipmentTModel current_EquipmentT = MyDb.EquipmentT.FirstOrDefault(e => e.eid == eid_slave);
                    if (current_temprature < current_EquipmentT.TemperatureLowM)
                    {
                        current_EquipmentT.TemperatureLowM = current_temprature;
                    }
                    if (current_temprature > current_EquipmentT.TemperatureHighM)
                    {
                        current_EquipmentT.TemperatureHighM = current_temprature;
                    }
                    ///////
                    if (current_Humidty < current_EquipmentT.HumidtyLowM)
                    {
                        current_EquipmentT.HumidtyLowM = current_Humidty;
                    }
                    if (current_Humidty > current_EquipmentT.HumidtyHighM)
                    {
                        current_EquipmentT.HumidtyHighM = current_Humidty;
                    }
                    /////////
                    if (current_Brightness < current_EquipmentT.BrightnessLowM)
                    {
                        current_EquipmentT.BrightnessLowM = current_Brightness;
                    }
                    if (current_Brightness > current_EquipmentT.BrightnessHighM)
                    {
                        current_EquipmentT.BrightnessHighM = current_Brightness;
                    }



                    MyDb.EquipmentT.Add(current_EquipmentT);//把修改后的对象扔到三连里
                    MyDb.Entry(current_EquipmentT).State = System.Data.Entity.EntityState.Modified;
                    await MyDb.SaveChangesAsync();
                    this.Invoke(() =>
                    {
                        label15.Text = Math.Round((current_EquipmentT.TemperatureHighM * 0.1), 1).ToString();
                        label18.Text = Math.Round((current_EquipmentT.TemperatureLowM * 0.1), 1).ToString();
                        label23.Text = Math.Round((current_EquipmentT.HumidtyHighM * 0.1), 1).ToString();
                        label26.Text = Math.Round((current_EquipmentT.HumidtyLowM * 0.1), 1).ToString();
                        label29.Text = Math.Round((current_EquipmentT.BrightnessHighM * 0.1), 1).ToString();
                        label35.Text = Math.Round((current_EquipmentT.BrightnessLowM * 0.1), 1).ToString();
                    });
                }
                CoilState = await Master.ReadCoilsAsync(
                slaveAddress: Convert.ToByte(comboBox6.Text),//从1号从站设备读
                startAddress: 0,//起始寄存器地址
                numberOfPoints: 6//读取寄存器个数
                );


                System.Windows.Forms.Button[] lights = { light0, light1, light2, light3, light4, light5 };

                for (int i = 0; i < lights.Length; i++)
                {
                    this.Invoke(() =>
                    {
                        lights[i].Enabled = true;
                        lights[i].Text = CoilState[i] ? "开" : "关";
                        lights[i].BackColor = CoilState[i] ? Color.Orange : Color.Silver;
                    });
                }
                await Task.Delay(1000);
            }


        }


        private async void light0_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button[] lights = { light0, light1, light2, light3, light4, light5 };
            if (light0.Text == "开")
            {
                for (int i = 1; i < lights.Length; i++)
                {
                    lights[i].Enabled = true;
                    lights[i].Text = "开";
                    lights[i].BackColor = Color.Orange;
                }
                light0.Text = "关";
                light0.BackColor = Color.Silver;

            }
            else
            {
                for (int i = 0; i < lights.Length; i++)
                {
                    lights[i].Enabled = true;
                    lights[i].Text = "关";
                    lights[i].BackColor = Color.Silver;
                }
                light0.Text = "开";
                light0.BackColor = Color.Orange;
            }
            await ControlLightsAsync(EquipmentCurrentModel.Master);

        }

        private async void lightall_ClickAsync(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {

                if (clickedButton.Text == "关")
                {
                    clickedButton.Text = "开";
                    clickedButton.BackColor = Color.Orange;
                }
                else
                {
                    clickedButton.Text = "关";
                    clickedButton.BackColor = Color.Silver;
                }
                await ControlLightsAsync(EquipmentCurrentModel.Master);
            }
        }
        private async Task ControlLightsAsync(IModbusSerialMaster Master)
        {

            System.Windows.Forms.Button[] lights = { light0, light1, light2, light3, light4, light5 };
            for (int j = 0; j < lights.Length; j++)
            {
                if (lights[j].Text == "开")
                {
                    CoilState[j] = true;
                }
                else
                {
                    CoilState[j] = false;
                }
            }

            await Master.WriteMultipleCoilsAsync(
            slaveAddress: Convert.ToByte(comboBox6.Text),//往1号从站设备写
            startAddress: 0,//从6号地址开始写 values变量有几个就依次往下写几个
            data: CoilState//写的值
            );

        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                WinformsFigues winformsFigues = new WinformsFigues();

                winformsFigues.Show();
            }
            else
            {
                MessageBox.Show("请先连接设备", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                WinformsLED winformsLED = new WinformsLED();

                winformsLED.Show();
            }
            else
            {
                MessageBox.Show("请先连接设备", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
    }
}
