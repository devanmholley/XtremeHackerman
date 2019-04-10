namespace XtremeHackerman
{
    partial class Form_TitleScreen
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
	    this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
	    this.button_Admin = new System.Windows.Forms.Button();
	    this.button_Hacker = new System.Windows.Forms.Button();
	    this.button_Quit = new System.Windows.Forms.Button();
	    this.button_About = new System.Windows.Forms.Button();
	    this.pictureBox_Title = new System.Windows.Forms.PictureBox();
	    this.tableLayoutPanel_Buttons.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // tableLayoutPanel_Buttons
	    // 
	    this.tableLayoutPanel_Buttons.BackColor = System.Drawing.Color.Transparent;
	    this.tableLayoutPanel_Buttons.ColumnCount = 6;
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Admin, 1, 0);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Hacker, 3, 0);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Quit, 2, 2);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_About, 2, 1);
	    this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.tableLayoutPanel_Buttons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
	    this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 1302);
	    this.tableLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
	    this.tableLayoutPanel_Buttons.RowCount = 4;
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
	    this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(2688, 436);
	    this.tableLayoutPanel_Buttons.TabIndex = 1;
	    // 
	    // button_Admin
	    // 
	    this.button_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Admin, 2);
	    this.button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Admin.ForeColor = System.Drawing.Color.White;
	    this.button_Admin.Location = new System.Drawing.Point(545, 7);
	    this.button_Admin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Admin.Name = "button_Admin";
	    this.button_Admin.Size = new System.Drawing.Size(790, 139);
	    this.button_Admin.TabIndex = 0;
	    this.button_Admin.Text = "ADMIN";
	    this.button_Admin.UseVisualStyleBackColor = true;
	    this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
	    // 
	    // button_Hacker
	    // 
	    this.button_Hacker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Hacker, 2);
	    this.button_Hacker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Hacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Hacker.ForeColor = System.Drawing.Color.White;
	    this.button_Hacker.Location = new System.Drawing.Point(1351, 7);
	    this.button_Hacker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Hacker.Name = "button_Hacker";
	    this.button_Hacker.Size = new System.Drawing.Size(790, 139);
	    this.button_Hacker.TabIndex = 1;
	    this.button_Hacker.Text = "HACKER";
	    this.button_Hacker.UseVisualStyleBackColor = true;
	    this.button_Hacker.Click += new System.EventHandler(this.button_Hacker_Click);
	    // 
	    // button_Quit
	    // 
	    this.button_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Quit, 2);
	    this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Quit.ForeColor = System.Drawing.Color.White;
	    this.button_Quit.Location = new System.Drawing.Point(1217, 236);
	    this.button_Quit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Quit.Name = "button_Quit";
	    this.button_Quit.Size = new System.Drawing.Size(252, 62);
	    this.button_Quit.TabIndex = 3;
	    this.button_Quit.Text = "QUIT";
	    this.button_Quit.UseVisualStyleBackColor = true;
	    this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
	    // 
	    // button_About
	    // 
	    this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_About, 2);
	    this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_About.ForeColor = System.Drawing.Color.White;
	    this.button_About.Location = new System.Drawing.Point(1217, 160);
	    this.button_About.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_About.Name = "button_About";
	    this.button_About.Size = new System.Drawing.Size(252, 62);
	    this.button_About.TabIndex = 2;
	    this.button_About.Text = "ABOUT";
	    this.button_About.UseVisualStyleBackColor = true;
	    // 
	    // pictureBox_Title
	    // 
	    this.pictureBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.pictureBox_Title.BackColor = System.Drawing.Color.Transparent;
	    this.pictureBox_Title.Image = global::XtremeHackerman.Properties.Resources.Picture_Title;
	    this.pictureBox_Title.Location = new System.Drawing.Point(1040, 305);
	    this.pictureBox_Title.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.pictureBox_Title.Name = "pictureBox_Title";
	    this.pictureBox_Title.Size = new System.Drawing.Size(725, 89);
	    this.pictureBox_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.pictureBox_Title.TabIndex = 2;
	    this.pictureBox_Title.TabStop = false;
	    // 
	    // Form_TitleScreen
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_TitleScreen;
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(2688, 1738);
	    this.Controls.Add(this.pictureBox_Title);
	    this.Controls.Add(this.tableLayoutPanel_Buttons);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.MaximizeBox = false;
	    this.Name = "Form_TitleScreen";
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Xtreme Hackerman";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.Load += new System.EventHandler(this.Form_TitleScreen_Load);
	    this.tableLayoutPanel_Buttons.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button button_Hacker;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.PictureBox pictureBox_Title;
    }
}