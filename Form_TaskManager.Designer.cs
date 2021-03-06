﻿namespace XtremeHackerman
{
    partial class Form_TaskManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TaskTab = new System.Windows.Forms.TabPage();
            this.TaskView = new System.Windows.Forms.ListView();
            this.TaskProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskRuntime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.HistoryView = new System.Windows.Forms.ListView();
            this.HistoryProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HistoryRuntime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEndTask = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.TaskTab.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TaskTab);
            this.tabControl1.Controls.Add(this.HistoryTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // TaskTab
            // 
            this.TaskTab.Controls.Add(this.TaskView);
            this.TaskTab.Location = new System.Drawing.Point(4, 22);
            this.TaskTab.Name = "TaskTab";
            this.TaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaskTab.Size = new System.Drawing.Size(562, 515);
            this.TaskTab.TabIndex = 0;
            this.TaskTab.Text = "Tasks";
            this.TaskTab.UseVisualStyleBackColor = true;
            // 
            // TaskView
            // 
            this.TaskView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskProcessName,
            this.TaskRuntime});
            this.TaskView.Location = new System.Drawing.Point(0, 0);
            this.TaskView.Name = "TaskView";
            this.TaskView.Size = new System.Drawing.Size(562, 515);
            this.TaskView.TabIndex = 0;
            this.TaskView.UseCompatibleStateImageBehavior = false;
            this.TaskView.View = System.Windows.Forms.View.Details;
            this.TaskView.SelectedIndexChanged += new System.EventHandler(this.TaskView_SelectedIndexChanged);
            // 
            // TaskProcessName
            // 
            this.TaskProcessName.Text = "Process Name";
            this.TaskProcessName.Width = 120;
            // 
            // TaskRuntime
            // 
            this.TaskRuntime.Text = "Runtime";
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.HistoryView);
            this.HistoryTab.Location = new System.Drawing.Point(4, 22);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(562, 515);
            this.HistoryTab.TabIndex = 1;
            this.HistoryTab.Text = "History";
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // HistoryView
            // 
            this.HistoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HistoryProcessName,
            this.HistoryRuntime});
            this.HistoryView.Location = new System.Drawing.Point(0, 0);
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.Size = new System.Drawing.Size(562, 515);
            this.HistoryView.TabIndex = 0;
            this.HistoryView.UseCompatibleStateImageBehavior = false;
            this.HistoryView.View = System.Windows.Forms.View.Details;
            this.HistoryView.SelectedIndexChanged += new System.EventHandler(this.HistoryView_SelectedIndexChanged);
            // 
            // HistoryProcessName
            // 
            this.HistoryProcessName.Text = "Process Name";
            this.HistoryProcessName.Width = 120;
            // 
            // HistoryRuntime
            // 
            this.HistoryRuntime.Text = "Runtime";
            // 
            // BtnEndTask
            // 
            this.BtnEndTask.Location = new System.Drawing.Point(432, 543);
            this.BtnEndTask.Name = "BtnEndTask";
            this.BtnEndTask.Size = new System.Drawing.Size(111, 39);
            this.BtnEndTask.TabIndex = 1;
            this.BtnEndTask.Text = "End Task";
            this.BtnEndTask.UseVisualStyleBackColor = true;
            this.BtnEndTask.Click += new System.EventHandler(this.BtnEndTask_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form_TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 594);
            this.Controls.Add(this.BtnEndTask);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_TaskManager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.TaskTab.ResumeLayout(false);
            this.HistoryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TaskTab;
        private System.Windows.Forms.TabPage HistoryTab;
        private System.Windows.Forms.Button BtnEndTask;
        private System.Windows.Forms.ListView TaskView;
        private System.Windows.Forms.ListView HistoryView;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ColumnHeader TaskProcessName;
        public System.Windows.Forms.ColumnHeader TaskRuntime;
        public System.Windows.Forms.ColumnHeader HistoryProcessName;
        public System.Windows.Forms.ColumnHeader HistoryRuntime;
    }
}