namespace 设备监控系统
{
    partial class WinformsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinformsMain));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 80);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(1145, 16);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 2;
            button1.Text = "退出系统";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文彩云", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(128, 30);
            label1.Name = "label1";
            label1.Size = new Size(225, 36);
            label1.TabIndex = 1;
            label1.Text = "设备管理系统";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(30, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(81, 54);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 606);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(30, 28);
            button2.Name = "button2";
            button2.Size = new Size(146, 50);
            button2.TabIndex = 2;
            button2.Text = "数据实况";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WinformsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1316, 686);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            Name = "WinformsMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "设备管理系统";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}