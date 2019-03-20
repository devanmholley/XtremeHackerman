namespace XtremeHackerman
{
    partial class Form_NotificationPopup
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
            this.testNotificationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testNotificationButton
            // 
            this.testNotificationButton.Location = new System.Drawing.Point(345, 104);
            this.testNotificationButton.Name = "testNotificationButton";
            this.testNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.testNotificationButton.TabIndex = 0;
            this.testNotificationButton.Text = "Test Package";
            this.testNotificationButton.UseVisualStyleBackColor = true;
            this.testNotificationButton.Click += new System.EventHandler(this.testNotificationButton_Click);
            // 
            // Form_NotificationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testNotificationButton);
            this.Name = "Form_NotificationPopup";
            this.Text = "Form_NotificationPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testNotificationButton;
    }
}