namespace 设备监控系统
{
    partial class WinformsFigues
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "", "", "", "" }, -1);
            panel1 = new Panel();
            checked3 = new CheckBox();
            checked2 = new CheckBox();
            checked1 = new CheckBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listView1 = new ListView();
            colutime = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checked3);
            panel1.Controls.Add(checked2);
            panel1.Controls.Add(checked1);
            panel1.Location = new Point(52, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 52);
            panel1.TabIndex = 0;
            // 
            // checked3
            // 
            checked3.AutoSize = true;
            checked3.Font = new Font("Microsoft YaHei UI", 14.25F);
            checked3.ForeColor = Color.Goldenrod;
            checked3.Location = new Point(243, 16);
            checked3.Name = "checked3";
            checked3.Size = new Size(69, 29);
            checked3.TabIndex = 0;
            checked3.Text = "亮度";
            checked3.UseVisualStyleBackColor = true;
            checked3.CheckedChanged += CheckedChanged;
            // 
            // checked2
            // 
            checked2.AutoSize = true;
            checked2.Font = new Font("Microsoft YaHei UI", 14.25F);
            checked2.ForeColor = SystemColors.HotTrack;
            checked2.Location = new Point(126, 16);
            checked2.Name = "checked2";
            checked2.Size = new Size(69, 29);
            checked2.TabIndex = 0;
            checked2.Text = "湿度";
            checked2.UseVisualStyleBackColor = true;
            checked2.CheckedChanged += CheckedChanged;
            // 
            // checked1
            // 
            checked1.AutoSize = true;
            checked1.Font = new Font("Microsoft YaHei UI", 14.25F);
            checked1.ForeColor = Color.Brown;
            checked1.Location = new Point(18, 16);
            checked1.Name = "checked1";
            checked1.Size = new Size(69, 29);
            checked1.TabIndex = 0;
            checked1.Text = "温度";
            checked1.UseVisualStyleBackColor = true;
            checked1.CheckedChanged += CheckedChanged;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chart1.BorderlineColor = Color.Silver;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.Gray;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.LineColor = Color.LightGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 5D;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Title = "时间";
            chartArea1.AxisX.TitleAlignment = StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.Gray;
            chartArea1.AxisY.LineColor = Color.LightGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Interval = 10D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.Title = "实时值";
            chartArea1.AxisY.TitleAlignment = StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.BackColor = Color.White;
            chartArea1.BorderColor = Color.Silver;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.InnerPlotPosition.Y = 4F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 88F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(52, 98);
            chart1.Name = "chart1";
            chart1.Size = new Size(1229, 373);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colutime, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(52, 493);
            listView1.Name = "listView1";
            listView1.Size = new Size(1229, 310);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colutime
            // 
            colutime.Text = "采集时间";
            colutime.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "当前温度(℃)";
            columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "当前湿度(%)";
            columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "当前亮度(cd/m2)";
            columnHeader4.Width = 230;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1139, 31);
            button1.Name = "button1";
            button1.Size = new Size(119, 35);
            button1.TabIndex = 3;
            button1.Text = "退出监控";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WinformsFigues
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1312, 815);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Name = "WinformsFigues";
            Text = "WinformsFigues";
            Load += WinformsFigues_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checked3;
        private CheckBox checked2;
        private CheckBox checked1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListView listView1;
        private ColumnHeader colutime;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
    }
}