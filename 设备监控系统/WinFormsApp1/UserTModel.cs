using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Table("t_user")]
    public class UserTModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int sex { get; set; }
        public string phone { get; set; }

        public string adress { get; set; }
    }

    [Table("t_equipmentM")]
    public class EquipmentTModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eid { get; set; }
        public int TemperatureLowM { get; set; }
        public int TemperatureHighM { get; set; }
        public int HumidtyLowM { get; set; }
        public int HumidtyHighM { get; set; }
        public int BrightnessLowM { get; set; }
        public int BrightnessHighM { get; set; }
    }

    public class EquipmentCurrentModel
    {
        public static double Temperature { get; set; }
        public static double Humidty  { get; set; }
        public static double Brightness { get; set; }
        public static IModbusSerialMaster Master;
    }

    
}