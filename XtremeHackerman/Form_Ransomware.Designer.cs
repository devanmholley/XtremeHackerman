namespace XtremeHackerman
{
    partial class Form_Ransomware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ransomware));
            this.label_Warning = new System.Windows.Forms.Label();
            this.Label_Destroy_Warning = new System.Windows.Forms.Label();
            this.TB_Ransomeware_Description = new System.Windows.Forms.TextBox();
            this.PB_Ransom_Icon = new System.Windows.Forms.PictureBox();
            this.Label_Time_Left = new System.Windows.Forms.Label();
            this.Label_date = new System.Windows.Forms.Label();
            this.Label_timer = new System.Windows.Forms.Label();
            this.Btn_Next_Ransom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Warning.ForeColor = System.Drawing.Color.White;
            this.label_Warning.Location = new System.Drawing.Point(481, 9);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(712, 60);
            this.label_Warning.TabIndex = 0;
            this.label_Warning.Text = "Your personal files are encrypted!";
            this.label_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Destroy_Warning
            // 
            this.Label_Destroy_Warning.AutoSize = true;
            this.Label_Destroy_Warning.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Destroy_Warning.ForeColor = System.Drawing.Color.White;
            this.Label_Destroy_Warning.Location = new System.Drawing.Point(61, 511);
            this.Label_Destroy_Warning.Name = "Label_Destroy_Warning";
            this.Label_Destroy_Warning.Size = new System.Drawing.Size(395, 30);
            this.Label_Destroy_Warning.TabIndex = 2;
            this.Label_Destroy_Warning.Text = "The private key will be destroyed on:";
            this.Label_Destroy_Warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TB_Ransomeware_Description
            // 
            this.TB_Ransomeware_Description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TB_Ransomeware_Description.BackColor = System.Drawing.Color.White;
            this.TB_Ransomeware_Description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ransomeware_Description.HideSelection = false;
            this.TB_Ransomeware_Description.Location = new System.Drawing.Point(491, 72);
            this.TB_Ransomeware_Description.Multiline = true;
            this.TB_Ransomeware_Description.Name = "TB_Ransomeware_Description";
            this.TB_Ransomeware_Description.ReadOnly = true;
            this.TB_Ransomeware_Description.ShortcutsEnabled = false;
            this.TB_Ransomeware_Description.Size = new System.Drawing.Size(702, 564);
            this.TB_Ransomeware_Description.TabIndex = 3;
            this.TB_Ransomeware_Description.TabStop = false;
            this.TB_Ransomeware_Description.Text = resources.GetString("TB_Ransomeware_Description.Text");
            // 
            // PB_Ransom_Icon
            // 
            this.PB_Ransom_Icon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Ransomware_Icon;
            this.PB_Ransom_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Ransom_Icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Ransom_Icon.InitialImage")));
            this.PB_Ransom_Icon.Location = new System.Drawing.Point(13, 13);
            this.PB_Ransom_Icon.Name = "PB_Ransom_Icon";
            this.PB_Ransom_Icon.Size = new System.Drawing.Size(462, 468);
            this.PB_Ransom_Icon.TabIndex = 1;
            this.PB_Ransom_Icon.TabStop = false;
            // 
            // Label_Time_Left
            // 
            this.Label_Time_Left.AutoSize = true;
            this.Label_Time_Left.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time_Left.ForeColor = System.Drawing.Color.White;
            this.Label_Time_Left.Location = new System.Drawing.Point(181, 606);
            this.Label_Time_Left.Name = "Label_Time_Left";
            this.Label_Time_Left.Size = new System.Drawing.Size(120, 30);
            this.Label_Time_Left.TabIndex = 4;
            this.Label_Time_Left.Text = "Time Left!";
            this.Label_Time_Left.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_date
            // 
            this.Label_date.AutoSize = true;
            this.Label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_date.ForeColor = System.Drawing.Color.White;
            this.Label_date.Location = new System.Drawing.Point(145, 562);
            this.Label_date.Name = "Label_date";
            this.Label_date.Size = new System.Drawing.Size(200, 23);
            this.Label_date.TabIndex = 5;
            this.Label_date.Text = "4/4/2019 10:44:43 AM";
            this.Label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_timer
            // 
            this.Label_timer.AutoSize = true;
            this.Label_timer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_timer.ForeColor = System.Drawing.Color.Yellow;
            this.Label_timer.Location = new System.Drawing.Point(145, 655);
            this.Label_timer.Name = "Label_timer";
            this.Label_timer.Size = new System.Drawing.Size(200, 23);
            this.Label_timer.TabIndex = 6;
            this.Label_timer.Text = "4/4/2019 10:44:43 AM";
            this.Label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Next_Ransom
            // 
            this.Btn_Next_Ransom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next_Ransom.Location = new System.Drawing.Point(1020, 642);
            this.Btn_Next_Ransom.Name = "Btn_Next_Ransom";
            this.Btn_Next_Ransom.Size = new System.Drawing.Size(123, 49);
            this.Btn_Next_Ransom.TabIndex = 7;
            this.Btn_Next_Ransom.Text = "Next";
            this.Btn_Next_Ransom.UseVisualStyleBackColor = true;
            this.Btn_Next_Ransom.Click += new System.EventHandler(this.Btn_Next_Ransom_Click);
            // 
            // Form_Ransomware
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1205, 718);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Next_Ransom);
            this.Controls.Add(this.Label_timer);
            this.Controls.Add(this.Label_date);
            this.Controls.Add(this.Label_Time_Left);
            this.Controls.Add(this.TB_Ransomeware_Description);
            this.Controls.Add(this.Label_Destroy_Warning);
            this.Controls.Add(this.PB_Ransom_Icon);
            this.Controls.Add(this.label_Warning);
            this.Name = "Form_Ransomware";
            this.Text = "Form_Ransomware";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.PictureBox PB_Ransom_Icon;
        private System.Windows.Forms.Label Label_Destroy_Warning;
        private System.Windows.Forms.TextBox TB_Ransomeware_Description;
        private System.Windows.Forms.Label Label_Time_Left;
        private System.Windows.Forms.Label Label_date;
        private System.Windows.Forms.Label Label_timer;
        private System.Windows.Forms.Button Btn_Next_Ransom;
    }
}