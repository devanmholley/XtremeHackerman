namespace StartMenu
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
            this.Start = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.AdminFileManager = new System.Windows.Forms.Button();
            this.TaskManager = new System.Windows.Forms.Button();
            this.InternetBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(12, 401);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(122, 37);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(165, 401);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(134, 37);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shutdown.Location = new System.Drawing.Point(323, 401);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(124, 37);
            this.Shutdown.TabIndex = 2;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Visible = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // AdminFileManager
            // 
            this.AdminFileManager.AutoSize = true;
            this.AdminFileManager.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFileManager.Location = new System.Drawing.Point(12, 334);
            this.AdminFileManager.Name = "AdminFileManager";
            this.AdminFileManager.Size = new System.Drawing.Size(122, 45);
            this.AdminFileManager.TabIndex = 3;
            this.AdminFileManager.Text = "File Manager";
            this.AdminFileManager.UseVisualStyleBackColor = true;
            this.AdminFileManager.Visible = false;
            this.AdminFileManager.Click += new System.EventHandler(this.AdminFileManager_Click);
            // 
            // TaskManager
            // 
            this.TaskManager.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskManager.Location = new System.Drawing.Point(12, 271);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(122, 37);
            this.TaskManager.TabIndex = 4;
            this.TaskManager.Text = "Task Manager";
            this.TaskManager.UseVisualStyleBackColor = true;
            this.TaskManager.Visible = false;
            this.TaskManager.Click += new System.EventHandler(this.TaskManager_Click);
            // 
            // InternetBrowser
            // 
            this.InternetBrowser.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternetBrowser.Location = new System.Drawing.Point(12, 200);
            this.InternetBrowser.Name = "InternetBrowser";
            this.InternetBrowser.Size = new System.Drawing.Size(122, 43);
            this.InternetBrowser.TabIndex = 5;
            this.InternetBrowser.Text = "Internet";
            this.InternetBrowser.UseVisualStyleBackColor = true;
            this.InternetBrowser.Visible = false;
            this.InternetBrowser.Click += new System.EventHandler(this.InternetBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InternetBrowser);
            this.Controls.Add(this.TaskManager);
            this.Controls.Add(this.AdminFileManager);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button AdminFileManager;
        private System.Windows.Forms.Button TaskManager;
        private System.Windows.Forms.Button InternetBrowser;
    }
}

