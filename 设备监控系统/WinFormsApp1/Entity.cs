using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Server = localhost; Database = equipmentMS; Trusted_Connection = true;")
        {

        }

        public DbSet<UserTModel> UserT { get; set; }
        public DbSet<EquipmentTModel> EquipmentT { get; set; }
    }

}
