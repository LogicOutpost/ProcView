namespace ProcView
{
    partial class Monitoring
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuTimer = new System.Windows.Forms.Timer(this.components);
            this.processBox = new System.Windows.Forms.ListBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.notice2Label = new System.Windows.Forms.Label();
            this.notice3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuChart
            // 
            this.cpuChart.BackColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Title = "CPU Usage %";
            chartArea2.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cpuChart.Legends.Add(legend2);
            this.cpuChart.Location = new System.Drawing.Point(314, 12);
            this.cpuChart.Name = "cpuChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            series2.XValueMember = "tets";
            this.cpuChart.Series.Add(series2);
            this.cpuChart.Size = new System.Drawing.Size(474, 414);
            this.cpuChart.TabIndex = 0;
            this.cpuChart.Text = "chart1";
            title2.Name = "test";
            this.cpuChart.Titles.Add(title2);
            // 
            // cpuTimer
            // 
            this.cpuTimer.Interval = 1000;
            this.cpuTimer.Tick += new System.EventHandler(this.cpuTimer_Tick);
            // 
            // processBox
            // 
            this.processBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.processBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBox.FormattingEnabled = true;
            this.processBox.ItemHeight = 24;
            this.processBox.Location = new System.Drawing.Point(12, 12);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(287, 240);
            this.processBox.TabIndex = 1;
            this.processBox.SelectedIndexChanged += new System.EventHandler(this.processBox_SelectedIndexChanged);
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.ForeColor = System.Drawing.Color.White;
            this.noticeLabel.Location = new System.Drawing.Point(62, 324);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(168, 24);
            this.noticeLabel.TabIndex = 2;
            this.noticeLabel.Text = "Time is in seconds";
            // 
            // notice2Label
            // 
            this.notice2Label.AutoSize = true;
            this.notice2Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice2Label.ForeColor = System.Drawing.Color.White;
            this.notice2Label.Location = new System.Drawing.Point(36, 300);
            this.notice2Label.Name = "notice2Label";
            this.notice2Label.Size = new System.Drawing.Size(229, 24);
            this.notice2Label.TabIndex = 3;
            this.notice2Label.Text = "Select a process from list";
            // 
            // notice3Label
            // 
            this.notice3Label.AutoSize = true;
            this.notice3Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice3Label.ForeColor = System.Drawing.Color.White;
            this.notice3Label.Location = new System.Drawing.Point(22, 348);
            this.notice3Label.Name = "notice3Label";
            this.notice3Label.Size = new System.Drawing.Size(264, 24);
            this.notice3Label.TabIndex = 4;
            this.notice3Label.Text = "Graph tracks last 30 seconds";
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notice3Label);
            this.Controls.Add(this.notice2Label);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.processBox);
            this.Controls.Add(this.cpuChart);
            this.Name = "Monitoring";
            this.Text = "ProcView";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Timer cpuTimer;
        private System.Windows.Forms.ListBox processBox;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Label notice2Label;
        private System.Windows.Forms.Label notice3Label;
    }
}