namespace XtremeHackerman
{
    partial class Email_UI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.email_inbox = new System.Windows.Forms.ListBox();
            this.email_composeBTN = new System.Windows.Forms.Button();
            this.inbox_header = new System.Windows.Forms.TextBox();
            this.email_header = new System.Windows.Forms.Panel();
            this.email_sourceTXT = new System.Windows.Forms.TextBox();
            this.email_destTXT = new System.Windows.Forms.TextBox();
            this.email_dateTXT = new System.Windows.Forms.TextBox();
            this.email_fromSTXT = new System.Windows.Forms.TextBox();
            this.email_toSTXT = new System.Windows.Forms.TextBox();
            this.email_dateSTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.email_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.inbox_header);
            this.splitContainer1.Panel1.Controls.Add(this.email_composeBTN);
            this.splitContainer1.Panel1.Controls.Add(this.email_inbox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.email_header);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // email_inbox
            // 
            this.email_inbox.FormattingEnabled = true;
            this.email_inbox.Location = new System.Drawing.Point(0, 104);
            this.email_inbox.Name = "email_inbox";
            this.email_inbox.Size = new System.Drawing.Size(263, 342);
            this.email_inbox.TabIndex = 0;
            this.email_inbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // email_composeBTN
            // 
            this.email_composeBTN.BackColor = System.Drawing.Color.Azure;
            this.email_composeBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.email_composeBTN.FlatAppearance.BorderSize = 2;
            this.email_composeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.email_composeBTN.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_composeBTN.Location = new System.Drawing.Point(137, 64);
            this.email_composeBTN.Name = "email_composeBTN";
            this.email_composeBTN.Size = new System.Drawing.Size(116, 34);
            this.email_composeBTN.TabIndex = 1;
            this.email_composeBTN.Text = "Compose";
            this.email_composeBTN.UseVisualStyleBackColor = false;
            // 
            // inbox_header
            // 
            this.inbox_header.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbox_header.Location = new System.Drawing.Point(3, 3);
            this.inbox_header.Name = "inbox_header";
            this.inbox_header.Size = new System.Drawing.Size(130, 25);
            this.inbox_header.TabIndex = 2;
            // 
            // email_header
            // 
            this.email_header.Controls.Add(this.email_dateSTXT);
            this.email_header.Controls.Add(this.email_toSTXT);
            this.email_header.Controls.Add(this.email_fromSTXT);
            this.email_header.Controls.Add(this.email_dateTXT);
            this.email_header.Controls.Add(this.email_destTXT);
            this.email_header.Controls.Add(this.email_sourceTXT);
            this.email_header.Location = new System.Drawing.Point(3, 3);
            this.email_header.Name = "email_header";
            this.email_header.Size = new System.Drawing.Size(524, 147);
            this.email_header.TabIndex = 0;
            // 
            // email_sourceTXT
            // 
            this.email_sourceTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_sourceTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_sourceTXT.Location = new System.Drawing.Point(65, 9);
            this.email_sourceTXT.Name = "email_sourceTXT";
            this.email_sourceTXT.Size = new System.Drawing.Size(437, 18);
            this.email_sourceTXT.TabIndex = 0;
            // 
            // email_destTXT
            // 
            this.email_destTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_destTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_destTXT.Location = new System.Drawing.Point(65, 43);
            this.email_destTXT.Name = "email_destTXT";
            this.email_destTXT.Size = new System.Drawing.Size(437, 18);
            this.email_destTXT.TabIndex = 1;
            // 
            // email_dateTXT
            // 
            this.email_dateTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_dateTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_dateTXT.Location = new System.Drawing.Point(65, 77);
            this.email_dateTXT.Name = "email_dateTXT";
            this.email_dateTXT.Size = new System.Drawing.Size(437, 18);
            this.email_dateTXT.TabIndex = 2;
            // 
            // email_fromSTXT
            // 
            this.email_fromSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_fromSTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_fromSTXT.Location = new System.Drawing.Point(4, 9);
            this.email_fromSTXT.Name = "email_fromSTXT";
            this.email_fromSTXT.Size = new System.Drawing.Size(55, 18);
            this.email_fromSTXT.TabIndex = 3;
            this.email_fromSTXT.Text = "From:";
            this.email_fromSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.email_fromSTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_toSTXT
            // 
            this.email_toSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_toSTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_toSTXT.Location = new System.Drawing.Point(4, 43);
            this.email_toSTXT.Name = "email_toSTXT";
            this.email_toSTXT.Size = new System.Drawing.Size(55, 18);
            this.email_toSTXT.TabIndex = 4;
            this.email_toSTXT.Text = "To:";
            this.email_toSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // email_dateSTXT
            // 
            this.email_dateSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_dateSTXT.Font = new System.Drawing.Font("Linux Libertine G", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_dateSTXT.Location = new System.Drawing.Point(4, 77);
            this.email_dateSTXT.Name = "email_dateSTXT";
            this.email_dateSTXT.Size = new System.Drawing.Size(55, 18);
            this.email_dateSTXT.TabIndex = 5;
            this.email_dateSTXT.Text = "Date:";
            this.email_dateSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Email_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Email_UI";
            this.Text = "Email_Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.email_header.ResumeLayout(false);
            this.email_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox email_inbox;
        private System.Windows.Forms.TextBox inbox_header;
        private System.Windows.Forms.Button email_composeBTN;
        private System.Windows.Forms.Panel email_header;
        private System.Windows.Forms.TextBox email_fromSTXT;
        private System.Windows.Forms.TextBox email_dateTXT;
        private System.Windows.Forms.TextBox email_destTXT;
        private System.Windows.Forms.TextBox email_sourceTXT;
        private System.Windows.Forms.TextBox email_dateSTXT;
        private System.Windows.Forms.TextBox email_toSTXT;
    }
}