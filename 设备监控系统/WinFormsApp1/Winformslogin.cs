using �豸���ϵͳ;

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
                    MessageBox.Show("����Ϊ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserTModel current_user = MyDb.UserT.FirstOrDefault(e => e.username == textBox1.Text && e.password == textBox2.Text);
                if (current_user == null)
                {
                    MessageBox.Show("�û������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                WinformsMain winformsMain = new WinformsMain();
                winformsMain.ShowDialog();
            }
        }
    }
}
