namespace XtremeHackerman
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TaskTab = new System.Windows.Forms.TabPage();
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.BtnEndTask = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.TaskTab.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TaskTab);
            this.tabControl1.Controls.Add(this.HistoryTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // TaskTab
            // 
            this.TaskTab.Controls.Add(this.listBox1);
            this.TaskTab.Location = new System.Drawing.Point(4, 22);
            this.TaskTab.Name = "TaskTab";
            this.TaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaskTab.Size = new System.Drawing.Size(480, 502);
            this.TaskTab.TabIndex = 0;
            this.TaskTab.Text = "Tasks";
            this.TaskTab.UseVisualStyleBackColor = true;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.listBox2);
            this.HistoryTab.Location = new System.Drawing.Point(4, 22);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(480, 502);
            this.HistoryTab.TabIndex = 1;
            this.HistoryTab.Text = "History";
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // BtnEndTask
            // 
            this.BtnEndTask.Location = new System.Drawing.Point(408, 546);
            this.BtnEndTask.Name = "BtnEndTask";
            this.BtnEndTask.Size = new System.Drawing.Size(92, 23);
            this.BtnEndTask.TabIndex = 1;
            this.BtnEndTask.Text = "End Task";
            this.BtnEndTask.UseVisualStyleBackColor = true;
            this.BtnEndTask.Click += new System.EventHandler(this.BtnEndTask_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(480, 498);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(480, 498);
            this.listBox2.TabIndex = 0;
            // 
            // Form_TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 578);
            this.Controls.Add(this.BtnEndTask);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_TaskManager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form_TaskManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.TaskTab.ResumeLayout(false);
            this.HistoryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TaskTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage HistoryTab;
        private System.Windows.Forms.Button BtnEndTask;
        private System.Windows.Forms.ListBox listBox2;
    }
}