﻿namespace XtremeHackerman
{
    partial class Form_txtEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_txtEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DDBtn_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.DDBtn_save = new System.Windows.Forms.ToolStripMenuItem();
            this.DDBtn_load = new System.Windows.Forms.ToolStripMenuItem();
            this.BodyTXT = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DDBtn_File});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DDBtn_File
            // 
            this.DDBtn_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DDBtn_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DDBtn_save,
            this.DDBtn_load});
            this.DDBtn_File.Image = ((System.Drawing.Image)(resources.GetObject("DDBtn_File.Image")));
            this.DDBtn_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DDBtn_File.Name = "DDBtn_File";
            this.DDBtn_File.Size = new System.Drawing.Size(38, 22);
            this.DDBtn_File.Text = "File";
            // 
            // DDBtn_save
            // 
            this.DDBtn_save.Name = "DDBtn_save";
            this.DDBtn_save.Size = new System.Drawing.Size(180, 22);
            this.DDBtn_save.Text = "Save";
            this.DDBtn_save.Click += new System.EventHandler(this.DDBtn_save_Click);
            // 
            // DDBtn_load
            // 
            this.DDBtn_load.Name = "DDBtn_load";
            this.DDBtn_load.Size = new System.Drawing.Size(180, 22);
            this.DDBtn_load.Text = "Load";
            this.DDBtn_load.Click += new System.EventHandler(this.DDBtn_load_Click);
            // 
            // BodyTXT
            // 
            this.BodyTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyTXT.Location = new System.Drawing.Point(0, 25);
            this.BodyTXT.Multiline = true;
            this.BodyTXT.Name = "BodyTXT";
            this.BodyTXT.Size = new System.Drawing.Size(292, 266);
            this.BodyTXT.TabIndex = 1;
            // 
            // Form_txtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 291);
            this.Controls.Add(this.BodyTXT);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_txtEditor";
            this.Text = "Form_txtEditor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DDBtn_File;
        private System.Windows.Forms.ToolStripMenuItem DDBtn_save;
        private System.Windows.Forms.ToolStripMenuItem DDBtn_load;
        private System.Windows.Forms.TextBox BodyTXT;
    }
}