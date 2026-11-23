using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcView
{
    public partial class Monitoring : Form
    {

        private Process selectedProcess;
        private TimeSpan previousCPUTime;
        private DateTime previousCheckTime;
        public Monitoring()
        {
            InitializeComponent();
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            // add each process to the number
            foreach (Process process in processes)
                processBox.Items.Add($"{process.ProcessName}");
            cpuChart.Series.Clear();
            cpuChart.Series.Add("CPU Usage");
            cpuChart.Series["CPU Usage"].ChartType = SeriesChartType.Line;
        }
        

        private void processBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processBox.SelectedIndex == -1)
            {
                return;
            }
            string processName = processBox.SelectedItem.ToString();

            selectedProcess = Process.GetProcessesByName(processName).FirstOrDefault();
            if (selectedProcess == null)
                return;

            previousCPUTime = selectedProcess.TotalProcessorTime;
            previousCheckTime = DateTime.Now;

            cpuChart.Series["CPU Usage"].Points.Clear();

            cpuTimer.Start();
        }

        private void cpuTimer_Tick(object sender, EventArgs e)
        {
            if (selectedProcess == null || selectedProcess.HasExited)
            {
                cpuTimer.Stop();
                return;
            }

            TimeSpan currentCPUTime = selectedProcess.TotalProcessorTime;
            DateTime currentCheckTime = DateTime.Now;

            double elapsedCPU = (currentCPUTime - previousCPUTime).TotalMilliseconds;
            double elapsedTime = (currentCheckTime - previousCheckTime).TotalMilliseconds;

            double cpuUsage = (elapsedCPU / (elapsedTime * Environment.ProcessorCount)) * 100;
            cpuUsage = Math.Max(0, Math.Min(cpuUsage, 100));

            previousCPUTime = currentCPUTime;
            previousCheckTime = currentCheckTime;
            cpuChart.ChartAreas[0].AxisY.Maximum = 10;
            cpuChart.ChartAreas[0].AxisY.Interval = 1;
            cpuChart.ChartAreas[0].RecalculateAxesScale();

            cpuChart.Series["CPU Usage"].Points.AddY(cpuUsage);

            if (cpuChart.Series["CPU Usage"].Points.Count > 30)
            {
                cpuChart.Series["CPU Usage"].Points.RemoveAt(0);
            }
        }
    }
}
