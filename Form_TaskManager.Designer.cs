namespace XtremeHackerman
{
    partial class TaskManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TasksTab = new System.Windows.Forms.TabPage();
            this.TaskView = new System.Windows.Forms.ListView();
            this.TaskProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskRuntime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.HistoryView = new System.Windows.Forms.ListView();
            this.HistoryProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HistoryRuntime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEndTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TasksTab.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TasksTab);
            this.tabControl1.Controls.Add(this.HistoryTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // TasksTab
            // 
            this.TasksTab.Controls.Add(this.TaskView);
            this.TasksTab.Location = new System.Drawing.Point(4, 22);
            this.TasksTab.Name = "TasksTab";
            this.TasksTab.Padding = new System.Windows.Forms.Padding(3);
            this.TasksTab.Size = new System.Drawing.Size(626, 578);
            this.TasksTab.TabIndex = 0;
            this.TasksTab.Text = "Tasks";
            this.TasksTab.UseVisualStyleBackColor = true;
            // 
            // TaskView
            // 
            this.TaskView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskProcessName,
            this.TaskRuntime});
            this.TaskView.Location = new System.Drawing.Point(0, 0);
            this.TaskView.Name = "TaskView";
            this.TaskView.Size = new System.Drawing.Size(626, 578);
            this.TaskView.TabIndex = 0;
            this.TaskView.UseCompatibleStateImageBehavior = false;
            this.TaskView.View = System.Windows.Forms.View.Details;
            // 
            // TaskProcessName
            // 
            this.TaskProcessName.Text = "Process Name";
            this.TaskProcessName.Width = 120;
            // 
            // TaskRuntime
            // 
            this.TaskRuntime.Text = "Runtime";
            this.TaskRuntime.Width = 80;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.HistoryView);
            this.HistoryTab.Location = new System.Drawing.Point(4, 22);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(626, 578);
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
            this.HistoryView.Size = new System.Drawing.Size(626, 578);
            this.HistoryView.TabIndex = 0;
            this.HistoryView.UseCompatibleStateImageBehavior = false;
            this.HistoryView.View = System.Windows.Forms.View.Details;
            // 
            // HistoryProcessName
            // 
            this.HistoryProcessName.Text = "Process Name";
            this.HistoryProcessName.Width = 120;
            // 
            // HistoryRuntime
            // 
            this.HistoryRuntime.Text = "Runtime";
            this.HistoryRuntime.Width = 80;
            // 
            // BtnEndTask
            // 
            this.BtnEndTask.Location = new System.Drawing.Point(522, 636);
            this.BtnEndTask.Name = "BtnEndTask";
            this.BtnEndTask.Size = new System.Drawing.Size(120, 38);
            this.BtnEndTask.TabIndex = 1;
            this.BtnEndTask.Text = "EndTask";
            this.BtnEndTask.UseVisualStyleBackColor = true;
            this.BtnEndTask.Click += new System.EventHandler(this.BtnEndTask_Click_1);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 686);
            this.Controls.Add(this.BtnEndTask);
            this.Controls.Add(this.tabControl1);
            this.Name = "TaskManager";
            this.Text = "Form_TaskManager";
            this.tabControl1.ResumeLayout(false);
            this.TasksTab.ResumeLayout(false);
            this.HistoryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TasksTab;
        private System.Windows.Forms.ListView TaskView;
        private System.Windows.Forms.TabPage HistoryTab;
        private System.Windows.Forms.Button BtnEndTask;
        private System.Windows.Forms.ColumnHeader TaskProcessName;
        private System.Windows.Forms.ColumnHeader TaskRuntime;
        private System.Windows.Forms.ListView HistoryView;
        private System.Windows.Forms.ColumnHeader HistoryProcessName;
        private System.Windows.Forms.ColumnHeader HistoryRuntime;
    }
}