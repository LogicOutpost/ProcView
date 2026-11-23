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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProcView
{
    public partial class SearchProcesses : Form
    {
        public SearchProcesses()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Process[] searchProcesses = Process.GetProcesses();
            foreach (Process process in searchProcesses)
            {
                if (process.ProcessName.ToLower() == searchBar.Text.ToLower())
                {
                    processesList.Items.Clear();
                    processesList.Items.Add($"{process.ProcessName} | {process.WorkingSet64 / (1024.0 * 1024 * 1024):F2} GB | {process.Id}");
                }
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchProcesses_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            int count = 0;
            foreach (Process process in processes)
            {
                count++;
                processesList.Items.Add($"{count}. {process.ProcessName}");
            }
        }
    }
}
