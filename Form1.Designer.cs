namespace ProcView
{
    partial class Form1
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
            this.processesLabel = new System.Windows.Forms.Panel();
            this.numOfProcessesLabel = new System.Windows.Forms.Label();
            this.totalProcessesLabel = new System.Windows.Forms.Label();
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.memoryUsedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pidPanel = new System.Windows.Forms.Panel();
            this.pidLabel = new System.Windows.Forms.Label();
            this.selectedPidLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.processesList = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.listPIDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MonitorButton = new System.Windows.Forms.Button();
            this.processesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuListTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.processesLabel.SuspendLayout();
            this.memoryPanel.SuspendLayout();
            this.pidPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processesLabel
            // 
            this.processesLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.processesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processesLabel.Controls.Add(this.numOfProcessesLabel);
            this.processesLabel.Controls.Add(this.totalProcessesLabel);
            this.processesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesLabel.ForeColor = System.Drawing.Color.White;
            this.processesLabel.Location = new System.Drawing.Point(12, 12);
            this.processesLabel.Name = "processesLabel";
            this.processesLabel.Size = new System.Drawing.Size(195, 83);
            this.processesLabel.TabIndex = 1;
            // 
            // numOfProcessesLabel
            // 
            this.numOfProcessesLabel.AutoSize = true;
            this.numOfProcessesLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numOfProcessesLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfProcessesLabel.ForeColor = System.Drawing.Color.White;
            this.numOfProcessesLabel.Location = new System.Drawing.Point(68, 33);
            this.numOfProcessesLabel.Name = "numOfProcessesLabel";
            this.numOfProcessesLabel.Size = new System.Drawing.Size(24, 26);
            this.numOfProcessesLabel.TabIndex = 3;
            this.numOfProcessesLabel.Text = "0";
            // 
            // totalProcessesLabel
            // 
            this.totalProcessesLabel.AutoSize = true;
            this.totalProcessesLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.totalProcessesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProcessesLabel.ForeColor = System.Drawing.Color.White;
            this.totalProcessesLabel.Location = new System.Drawing.Point(17, 9);
            this.totalProcessesLabel.Name = "totalProcessesLabel";
            this.totalProcessesLabel.Size = new System.Drawing.Size(154, 24);
            this.totalProcessesLabel.TabIndex = 2;
            this.totalProcessesLabel.Text = "Total Processes:";
            // 
            // memoryPanel
            // 
            this.memoryPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.memoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoryPanel.Controls.Add(this.memoryUsedLabel);
            this.memoryPanel.Controls.Add(this.label2);
            this.memoryPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryPanel.ForeColor = System.Drawing.Color.White;
            this.memoryPanel.Location = new System.Drawing.Point(244, 12);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(195, 83);
            this.memoryPanel.TabIndex = 4;
            // 
            // memoryUsedLabel
            // 
            this.memoryUsedLabel.AutoSize = true;
            this.memoryUsedLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.memoryUsedLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryUsedLabel.ForeColor = System.Drawing.Color.White;
            this.memoryUsedLabel.Location = new System.Drawing.Point(40, 33);
            this.memoryUsedLabel.Name = "memoryUsedLabel";
            this.memoryUsedLabel.Size = new System.Drawing.Size(0, 26);
            this.memoryUsedLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memory Used:";
            // 
            // pidPanel
            // 
            this.pidPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pidPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pidPanel.Controls.Add(this.pidLabel);
            this.pidPanel.Controls.Add(this.selectedPidLabel);
            this.pidPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidPanel.ForeColor = System.Drawing.Color.White;
            this.pidPanel.Location = new System.Drawing.Point(474, 12);
            this.pidPanel.Name = "pidPanel";
            this.pidPanel.Size = new System.Drawing.Size(195, 83);
            this.pidPanel.TabIndex = 5;
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pidLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidLabel.ForeColor = System.Drawing.Color.White;
            this.pidLabel.Location = new System.Drawing.Point(51, 33);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(0, 26);
            this.pidLabel.TabIndex = 3;
            // 
            // selectedPidLabel
            // 
            this.selectedPidLabel.AutoSize = true;
            this.selectedPidLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.selectedPidLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPidLabel.ForeColor = System.Drawing.Color.White;
            this.selectedPidLabel.Location = new System.Drawing.Point(17, 9);
            this.selectedPidLabel.Name = "selectedPidLabel";
            this.selectedPidLabel.Size = new System.Drawing.Size(133, 24);
            this.selectedPidLabel.TabIndex = 2;
            this.selectedPidLabel.Text = "Selected PID:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.VersionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(13, 435);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(103, 19);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "ProcView v1.1";
            // 
            // processesList
            // 
            this.processesList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.processesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processesList.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesList.ForeColor = System.Drawing.Color.White;
            this.processesList.FormattingEnabled = true;
            this.processesList.ItemHeight = 24;
            this.processesList.Location = new System.Drawing.Point(148, 127);
            this.processesList.Name = "processesList";
            this.processesList.Size = new System.Drawing.Size(520, 312);
            this.processesList.TabIndex = 9;
            this.processesList.SelectedIndexChanged += new System.EventHandler(this.processesList_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(147, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 22);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.memoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.ForeColor = System.Drawing.Color.White;
            this.memoryLabel.Location = new System.Drawing.Point(343, 102);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(79, 22);
            this.memoryLabel.TabIndex = 10;
            this.memoryLabel.Text = "Memory";
            // 
            // listPIDLabel
            // 
            this.listPIDLabel.AutoSize = true;
            this.listPIDLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.listPIDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPIDLabel.ForeColor = System.Drawing.Color.White;
            this.listPIDLabel.Location = new System.Drawing.Point(592, 102);
            this.listPIDLabel.Name = "listPIDLabel";
            this.listPIDLabel.Size = new System.Drawing.Size(43, 22);
            this.listPIDLabel.TabIndex = 11;
            this.listPIDLabel.Text = "PID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MonitorButton);
            this.panel1.Controls.Add(this.processesButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuListTitle);
            this.panel1.Location = new System.Drawing.Point(6, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 180);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "_______________";
            // 
            // MonitorButton
            // 
            this.MonitorButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.MonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonitorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorButton.ForeColor = System.Drawing.Color.White;
            this.MonitorButton.Location = new System.Drawing.Point(27, 105);
            this.MonitorButton.Name = "MonitorButton";
            this.MonitorButton.Size = new System.Drawing.Size(77, 29);
            this.MonitorButton.TabIndex = 8;
            this.MonitorButton.Text = "Monitor";
            this.MonitorButton.UseVisualStyleBackColor = false;
            this.MonitorButton.Click += new System.EventHandler(this.MonitorButton_Click);
            // 
            // processesButton
            // 
            this.processesButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.processesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesButton.ForeColor = System.Drawing.Color.White;
            this.processesButton.Location = new System.Drawing.Point(27, 70);
            this.processesButton.Name = "processesButton";
            this.processesButton.Size = new System.Drawing.Size(77, 29);
            this.processesButton.TabIndex = 7;
            this.processesButton.Text = "Search";
            this.processesButton.UseVisualStyleBackColor = false;
            this.processesButton.Click += new System.EventHandler(this.processesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monitoring";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "_______________";
            // 
            // menuListTitle
            // 
            this.menuListTitle.AutoSize = true;
            this.menuListTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuListTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuListTitle.ForeColor = System.Drawing.Color.White;
            this.menuListTitle.Location = new System.Drawing.Point(28, 10);
            this.menuListTitle.Name = "menuListTitle";
            this.menuListTitle.Size = new System.Drawing.Size(71, 19);
            this.menuListTitle.TabIndex = 4;
            this.menuListTitle.Text = "ProcView";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Some processes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "could have more ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "than one PID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(681, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listPIDLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.processesList);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.pidPanel);
            this.Controls.Add(this.memoryPanel);
            this.Controls.Add(this.processesLabel);
            this.Name = "Form1";
            this.Text = "ProcView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.processesLabel.ResumeLayout(false);
            this.processesLabel.PerformLayout();
            this.memoryPanel.ResumeLayout(false);
            this.memoryPanel.PerformLayout();
            this.pidPanel.ResumeLayout(false);
            this.pidPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel processesLabel;
        private System.Windows.Forms.Label numOfProcessesLabel;
        private System.Windows.Forms.Label totalProcessesLabel;
        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.Label memoryUsedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pidPanel;
        private System.Windows.Forms.Label pidLabel;
        private System.Windows.Forms.Label selectedPidLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ListBox processesList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label listPIDLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label menuListTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processesButton;
        private System.Windows.Forms.Button MonitorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

