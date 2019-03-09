namespace XtremeHackerman
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_Internet = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 694);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_Internet
            // 
            this.btn_Internet.Location = new System.Drawing.Point(12, 665);
            this.btn_Internet.Name = "btn_Internet";
            this.btn_Internet.Size = new System.Drawing.Size(75, 23);
            this.btn_Internet.TabIndex = 1;
            this.btn_Internet.Text = "Internet";
            this.btn_Internet.UseVisualStyleBackColor = true;
            this.btn_Internet.Click += new System.EventHandler(this.btn_Internet_Click);
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(12, 636);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(75, 23);
            this.btn_email.TabIndex = 2;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(93, 694);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 4;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            // 
            // Shutdown
            // 
            this.Shutdown.Location = new System.Drawing.Point(174, 694);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(75, 23);
            this.Shutdown.TabIndex = 5;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 79);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_Internet);
            this.Controls.Add(this.btn_start);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Xtreme Hackerman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_Internet;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button button1;
    }
}