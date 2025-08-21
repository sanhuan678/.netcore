using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class WinformsRegistered : Form
    {
        public WinformsRegistered()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext MyDb = new MyDbContext())
            {

             
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false))
                {
                    MessageBox.Show("输入为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserTModel current_user1 = MyDb.UserT.FirstOrDefault(e => e.username == textBox1.Text);
                if (current_user1 != null)
                {
                    MessageBox.Show("当前用户已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                UserTModel current_user2 = MyDb.UserT.OrderByDescending(e => e.id).First();
                UserTModel add_user = new UserTModel();
                add_user.id = current_user2.id+1;
                add_user.username = textBox1.Text;
                add_user.password = textBox2.Text;
                add_user.phone = textBox3.Text;
                add_user.adress = textBox4.Text;
                add_user.sex = radioButton1.Checked ? 1 : 0;
                MyDb.UserT.Attach(add_user);
                MyDb.Entry(add_user).State = System.Data.Entity.EntityState.Added;
                MyDb.SaveChanges();


            }

        }
    }
}
