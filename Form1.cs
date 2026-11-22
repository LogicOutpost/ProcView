using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            // add each process to the number
            int totalProcesses = 0;
            long totalMemory = 0;
            int count = 0;
            foreach (Process process in processes)
            {
                count++;
                totalProcesses++;
                totalMemory += process.WorkingSet;
                processesList.Items.Add($"{count}. {process.ProcessName} | {process.WorkingSet64 / (1024.0 * 1024 * 1024):F2} GB | {process.Id}");
            }
            double totalMemoryGB = totalMemory / (1024.0 * 1024 * 1024);
            numOfProcessesLabel.Text = $"{totalProcesses}";
            toolTip2.SetToolTip(searchButton, "Search for a process");
            memoryUsedLabel.Text = $"{totalMemoryGB:F2} GB";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Process[] searchProcesses = Process.GetProcesses();
            foreach (Process process in searchProcesses)
            {
                if (process.ProcessName.ToLower() == searchBar.Text)
                {
                    processesList.Items.Clear();
                    processesList.Items.Add($"{process.ProcessName} | {process.WorkingSet64 / (1024.0 * 1024 * 1024):F2} GB | {process.Id}");
                }
            }
        }

        private void processesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process[] searchProcesses = Process.GetProcesses();
            if (processesList.SelectedIndex != -1)
            {
                pidLabel.Text = searchProcesses[processesList.SelectedIndex].Id.ToString();
            }
        }
    }
}
