namespace 设备监控系统
{
    partial class WinformsLED
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
            ListViewItem listViewItem2 = new ListViewItem("asdasd");
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(47, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 731);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(14, 337);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 229);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(292, 611);
            button2.Name = "button2";
            button2.Size = new Size(108, 50);
            button2.TabIndex = 3;
            button2.Text = "清空消息";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(64, 611);
            button1.Name = "button1";
            button1.Size = new Size(108, 50);
            button1.TabIndex = 3;
            button1.Text = "发生消息";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(14, 249);
            label3.Name = "label3";
            label3.Size = new Size(236, 21);
            label3.TabIndex = 2;
            label3.Text = "说明：输出的字符串不能超过50";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 230);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(63, 27);
            label2.TabIndex = 0;
            label2.Text = "请输入...";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(613, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 731);
            panel2.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(19, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(639, 699);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "发生时间";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "发生内容";
            columnHeader3.Width = 460;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(19, -4);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 0;
            label5.Text = "消息记录";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(61, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "显示屏";
            // 
            // WinformsLED
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 824);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WinformsLED";
            Text = "WinformsLED";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox textBox1;
    }
}