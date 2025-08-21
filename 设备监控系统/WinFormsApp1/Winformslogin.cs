using 设备监控系统;

namespace WinFormsApp1
{
    public partial class Winformslogin : Form
    {
        public Winformslogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinformsRegistered winformsRegistered = new WinformsRegistered();
            winformsRegistered.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext MyDb = new MyDbContext())
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("输入为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserTModel current_user = MyDb.UserT.FirstOrDefault(e => e.username == textBox1.Text && e.password == textBox2.Text);
                if (current_user == null)
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                WinformsMain winformsMain = new WinformsMain();
                winformsMain.ShowDialog();
            }
        }
    }
}
