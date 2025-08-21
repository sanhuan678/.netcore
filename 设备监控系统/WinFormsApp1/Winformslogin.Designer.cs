namespace WinFormsApp1
{
    partial class Winformslogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.Location = new Point(43, 109);
            label1.Name = "label1";
            label1.Size = new Size(123, 35);
            label1.TabIndex = 0;
            label1.Text = "用户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 20F);
            label2.Location = new Point(61, 159);
            label2.Name = "label2";
            label2.Size = new Size(96, 35);
            label2.TabIndex = 0;
            label2.Text = "密码：";
            // 
            // button1
            // 
            button1.Location = new Point(91, 258);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 1;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 258);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 1;
            button2.Text = "注册";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 15F);
            textBox1.Location = new Point(163, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 33);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 15F);
            textBox2.Location = new Point(163, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 33);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("华文彩云", 30F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(103, 33);
            label3.Name = "label3";
            label3.Size = new Size(258, 41);
            label3.TabIndex = 3;
            label3.Text = "设备监控系统";
            // 
            // Winformslogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 352);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Winformslogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
