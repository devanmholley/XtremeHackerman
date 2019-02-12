namespace XtremeHackerman
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.btn_internet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_internet
            // 
            this.btn_internet.BackColor = System.Drawing.Color.Transparent;
            this.btn_internet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_internet.BackgroundImage")));
            this.btn_internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_internet.Location = new System.Drawing.Point(12, 12);
            this.btn_internet.Name = "btn_internet";
            this.btn_internet.Size = new System.Drawing.Size(75, 76);
            this.btn_internet.TabIndex = 0;
            this.btn_internet.UseVisualStyleBackColor = false;
            this.btn_internet.Click += new System.EventHandler(this.btn_internet_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_internet);
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Xtreme Hackerman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_internet;
    }
}