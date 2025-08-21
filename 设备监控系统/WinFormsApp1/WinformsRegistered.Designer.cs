namespace WinFormsApp1
{
    partial class WinformsRegistered
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F);
            label1.Location = new Point(62, 92);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 0;
            label1.Text = "用户名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F);
            label2.Location = new Point(62, 133);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 1;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F);
            label3.Location = new Point(62, 171);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 1;
            label3.Text = "性别";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F);
            label4.Location = new Point(62, 214);
            label4.Name = "label4";
            label4.Size = new Size(72, 27);
            label4.TabIndex = 1;
            label4.Text = "手机号";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F);
            label5.Location = new Point(62, 255);
            label5.Name = "label5";
            label5.Size = new Size(52, 27);
            label5.TabIndex = 1;
            label5.Text = "住址";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei UI", 12F);
            radioButton1.Location = new Point(157, 171);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(44, 25);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei UI", 12F);
            radioButton2.Location = new Point(282, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 25);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(88, 333);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 5;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(245, 333);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 5;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WinformsRegistered
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 434);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WinformsRegistered";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户注册";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}