namespace XtremeHackerman
{
    partial class Form_Email
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
	    this.components = new System.ComponentModel.Container();
	    this.splitContainer1 = new System.Windows.Forms.SplitContainer();
	    this.email_trashBTN = new System.Windows.Forms.Button();
	    this.email_composeBTN = new System.Windows.Forms.Button();
	    this.email_spamBTN = new System.Windows.Forms.Button();
	    this.email_flaggedBTN = new System.Windows.Forms.Button();
	    this.email_inboxBTN = new System.Windows.Forms.Button();
	    this.email_inbox = new System.Windows.Forms.ListBox();
	    this.emailInboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.email_mvtrashBTN = new System.Windows.Forms.Button();
	    this.email_mvspamBTN = new System.Windows.Forms.Button();
	    this.email_rplyallBTN = new System.Windows.Forms.Button();
	    this.email_forwardBTN = new System.Windows.Forms.Button();
	    this.email_replyBTN = new System.Windows.Forms.Button();
	    this.email_subjectTXT = new System.Windows.Forms.TextBox();
	    this.email_bodyTXT = new System.Windows.Forms.TextBox();
	    this.email_header = new System.Windows.Forms.Panel();
	    this.email_dateSTXT = new System.Windows.Forms.TextBox();
	    this.email_toSTXT = new System.Windows.Forms.TextBox();
	    this.email_fromSTXT = new System.Windows.Forms.TextBox();
	    this.email_dateTXT = new System.Windows.Forms.TextBox();
	    this.email_destTXT = new System.Windows.Forms.TextBox();
	    this.email_sourceTXT = new System.Windows.Forms.TextBox();
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
	    this.splitContainer1.Panel1.SuspendLayout();
	    this.splitContainer1.Panel2.SuspendLayout();
	    this.splitContainer1.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.emailInboxBindingSource)).BeginInit();
	    this.panel1.SuspendLayout();
	    this.email_header.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // splitContainer1
	    // 
	    this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.splitContainer1.Location = new System.Drawing.Point(0, 0);
	    this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.splitContainer1.Name = "splitContainer1";
	    // 
	    // splitContainer1.Panel1
	    // 
	    this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
	    this.splitContainer1.Panel1.AutoScroll = true;
	    this.splitContainer1.Panel1.Controls.Add(this.email_trashBTN);
	    this.splitContainer1.Panel1.Controls.Add(this.email_composeBTN);
	    this.splitContainer1.Panel1.Controls.Add(this.email_spamBTN);
	    this.splitContainer1.Panel1.Controls.Add(this.email_flaggedBTN);
	    this.splitContainer1.Panel1.Controls.Add(this.email_inboxBTN);
	    this.splitContainer1.Panel1.Controls.Add(this.email_inbox);
	    this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    // 
	    // splitContainer1.Panel2
	    // 
	    this.splitContainer1.Panel2.Controls.Add(this.panel1);
	    this.splitContainer1.Panel2.Controls.Add(this.email_bodyTXT);
	    this.splitContainer1.Panel2.Controls.Add(this.email_header);
	    this.splitContainer1.Size = new System.Drawing.Size(2133, 1073);
	    this.splitContainer1.SplitterDistance = 706;
	    this.splitContainer1.SplitterWidth = 11;
	    this.splitContainer1.TabIndex = 0;
	    // 
	    // email_trashBTN
	    // 
	    this.email_trashBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_trashBTN.FlatAppearance.BorderSize = 0;
	    this.email_trashBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
	    this.email_trashBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.email_trashBTN.Location = new System.Drawing.Point(8, 167);
	    this.email_trashBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_trashBTN.Name = "email_trashBTN";
	    this.email_trashBTN.Size = new System.Drawing.Size(141, 55);
	    this.email_trashBTN.TabIndex = 5;
	    this.email_trashBTN.Text = "Trash";
	    this.email_trashBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	    this.email_trashBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_composeBTN
	    // 
	    this.email_composeBTN.BackColor = System.Drawing.Color.Azure;
	    this.email_composeBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
	    this.email_composeBTN.FlatAppearance.BorderSize = 2;
	    this.email_composeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
	    this.email_composeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_composeBTN.Location = new System.Drawing.Point(405, 150);
	    this.email_composeBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_composeBTN.Name = "email_composeBTN";
	    this.email_composeBTN.Size = new System.Drawing.Size(248, 72);
	    this.email_composeBTN.TabIndex = 1;
	    this.email_composeBTN.Text = "Compose";
	    this.email_composeBTN.UseVisualStyleBackColor = false;
	    // 
	    // email_spamBTN
	    // 
	    this.email_spamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_spamBTN.FlatAppearance.BorderSize = 0;
	    this.email_spamBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
	    this.email_spamBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.email_spamBTN.Location = new System.Drawing.Point(8, 119);
	    this.email_spamBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_spamBTN.Name = "email_spamBTN";
	    this.email_spamBTN.Size = new System.Drawing.Size(141, 50);
	    this.email_spamBTN.TabIndex = 4;
	    this.email_spamBTN.Text = "Spam";
	    this.email_spamBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	    this.email_spamBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_flaggedBTN
	    // 
	    this.email_flaggedBTN.BackColor = System.Drawing.Color.Transparent;
	    this.email_flaggedBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_flaggedBTN.FlatAppearance.BorderSize = 0;
	    this.email_flaggedBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
	    this.email_flaggedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.email_flaggedBTN.Location = new System.Drawing.Point(8, 64);
	    this.email_flaggedBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_flaggedBTN.Name = "email_flaggedBTN";
	    this.email_flaggedBTN.Size = new System.Drawing.Size(160, 57);
	    this.email_flaggedBTN.TabIndex = 3;
	    this.email_flaggedBTN.Text = "Flagged";
	    this.email_flaggedBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	    this.email_flaggedBTN.UseVisualStyleBackColor = false;
	    // 
	    // email_inboxBTN
	    // 
	    this.email_inboxBTN.BackColor = System.Drawing.Color.Transparent;
	    this.email_inboxBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_inboxBTN.FlatAppearance.BorderSize = 0;
	    this.email_inboxBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
	    this.email_inboxBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.email_inboxBTN.Location = new System.Drawing.Point(8, 12);
	    this.email_inboxBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_inboxBTN.Name = "email_inboxBTN";
	    this.email_inboxBTN.Size = new System.Drawing.Size(141, 57);
	    this.email_inboxBTN.TabIndex = 2;
	    this.email_inboxBTN.Text = "Inbox";
	    this.email_inboxBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	    this.email_inboxBTN.UseVisualStyleBackColor = false;
	    // 
	    // email_inbox
	    // 
	    this.email_inbox.DataSource = this.emailInboxBindingSource;
	    this.email_inbox.FormattingEnabled = true;
	    this.email_inbox.ItemHeight = 31;
	    this.email_inbox.Location = new System.Drawing.Point(0, 248);
	    this.email_inbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_inbox.Name = "email_inbox";
	    this.email_inbox.Size = new System.Drawing.Size(695, 779);
	    this.email_inbox.TabIndex = 0;
	    // 
	    // emailInboxBindingSource
	    // 
	    this.emailInboxBindingSource.DataSource = typeof(XtremeHackerman.Classes.Class_Email);
	    // 
	    // panel1
	    // 
	    this.panel1.Controls.Add(this.email_mvtrashBTN);
	    this.panel1.Controls.Add(this.email_mvspamBTN);
	    this.panel1.Controls.Add(this.email_rplyallBTN);
	    this.panel1.Controls.Add(this.email_forwardBTN);
	    this.panel1.Controls.Add(this.email_replyBTN);
	    this.panel1.Controls.Add(this.email_subjectTXT);
	    this.panel1.Location = new System.Drawing.Point(19, 274);
	    this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(1363, 162);
	    this.panel1.TabIndex = 2;
	    // 
	    // email_mvtrashBTN
	    // 
	    this.email_mvtrashBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_mvtrashBTN.Location = new System.Drawing.Point(883, 10);
	    this.email_mvtrashBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_mvtrashBTN.Name = "email_mvtrashBTN";
	    this.email_mvtrashBTN.Size = new System.Drawing.Size(200, 55);
	    this.email_mvtrashBTN.TabIndex = 5;
	    this.email_mvtrashBTN.Text = "Trash";
	    this.email_mvtrashBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_mvspamBTN
	    // 
	    this.email_mvspamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_mvspamBTN.Location = new System.Drawing.Point(664, 10);
	    this.email_mvspamBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_mvspamBTN.Name = "email_mvspamBTN";
	    this.email_mvspamBTN.Size = new System.Drawing.Size(200, 55);
	    this.email_mvspamBTN.TabIndex = 4;
	    this.email_mvspamBTN.Text = "Spam";
	    this.email_mvspamBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_rplyallBTN
	    // 
	    this.email_rplyallBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_rplyallBTN.Location = new System.Drawing.Point(229, 10);
	    this.email_rplyallBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_rplyallBTN.Name = "email_rplyallBTN";
	    this.email_rplyallBTN.Size = new System.Drawing.Size(200, 55);
	    this.email_rplyallBTN.TabIndex = 3;
	    this.email_rplyallBTN.Text = "Reply All";
	    this.email_rplyallBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_forwardBTN
	    // 
	    this.email_forwardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_forwardBTN.Location = new System.Drawing.Point(445, 7);
	    this.email_forwardBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_forwardBTN.Name = "email_forwardBTN";
	    this.email_forwardBTN.Size = new System.Drawing.Size(200, 55);
	    this.email_forwardBTN.TabIndex = 2;
	    this.email_forwardBTN.Text = "Forward";
	    this.email_forwardBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_replyBTN
	    // 
	    this.email_replyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.email_replyBTN.Location = new System.Drawing.Point(11, 10);
	    this.email_replyBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_replyBTN.Name = "email_replyBTN";
	    this.email_replyBTN.Size = new System.Drawing.Size(200, 55);
	    this.email_replyBTN.TabIndex = 1;
	    this.email_replyBTN.Text = "Reply";
	    this.email_replyBTN.UseVisualStyleBackColor = true;
	    // 
	    // email_subjectTXT
	    // 
	    this.email_subjectTXT.BackColor = System.Drawing.Color.White;
	    this.email_subjectTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_subjectTXT.Location = new System.Drawing.Point(8, 86);
	    this.email_subjectTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_subjectTXT.Name = "email_subjectTXT";
	    this.email_subjectTXT.ReadOnly = true;
	    this.email_subjectTXT.Size = new System.Drawing.Size(1337, 61);
	    this.email_subjectTXT.TabIndex = 0;
	    // 
	    // email_bodyTXT
	    // 
	    this.email_bodyTXT.BackColor = System.Drawing.Color.White;
	    this.email_bodyTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_bodyTXT.Location = new System.Drawing.Point(19, 451);
	    this.email_bodyTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_bodyTXT.Multiline = true;
	    this.email_bodyTXT.Name = "email_bodyTXT";
	    this.email_bodyTXT.ReadOnly = true;
	    this.email_bodyTXT.Size = new System.Drawing.Size(1356, 607);
	    this.email_bodyTXT.TabIndex = 1;
	    // 
	    // email_header
	    // 
	    this.email_header.Controls.Add(this.email_dateSTXT);
	    this.email_header.Controls.Add(this.email_toSTXT);
	    this.email_header.Controls.Add(this.email_fromSTXT);
	    this.email_header.Controls.Add(this.email_dateTXT);
	    this.email_header.Controls.Add(this.email_destTXT);
	    this.email_header.Controls.Add(this.email_sourceTXT);
	    this.email_header.Location = new System.Drawing.Point(8, 7);
	    this.email_header.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_header.Name = "email_header";
	    this.email_header.Size = new System.Drawing.Size(1373, 250);
	    this.email_header.TabIndex = 0;
	    // 
	    // email_dateSTXT
	    // 
	    this.email_dateSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_dateSTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_dateSTXT.Location = new System.Drawing.Point(11, 184);
	    this.email_dateSTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_dateSTXT.Name = "email_dateSTXT";
	    this.email_dateSTXT.ReadOnly = true;
	    this.email_dateSTXT.Size = new System.Drawing.Size(147, 43);
	    this.email_dateSTXT.TabIndex = 5;
	    this.email_dateSTXT.Text = "Date:";
	    this.email_dateSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
	    // 
	    // email_toSTXT
	    // 
	    this.email_toSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_toSTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_toSTXT.Location = new System.Drawing.Point(11, 103);
	    this.email_toSTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_toSTXT.Name = "email_toSTXT";
	    this.email_toSTXT.ReadOnly = true;
	    this.email_toSTXT.Size = new System.Drawing.Size(147, 43);
	    this.email_toSTXT.TabIndex = 4;
	    this.email_toSTXT.Text = "To:";
	    this.email_toSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
	    // 
	    // email_fromSTXT
	    // 
	    this.email_fromSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_fromSTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_fromSTXT.Location = new System.Drawing.Point(11, 21);
	    this.email_fromSTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_fromSTXT.Name = "email_fromSTXT";
	    this.email_fromSTXT.ReadOnly = true;
	    this.email_fromSTXT.Size = new System.Drawing.Size(147, 43);
	    this.email_fromSTXT.TabIndex = 3;
	    this.email_fromSTXT.Text = "From:";
	    this.email_fromSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
	    // 
	    // email_dateTXT
	    // 
	    this.email_dateTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_dateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_dateTXT.Location = new System.Drawing.Point(173, 184);
	    this.email_dateTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_dateTXT.Name = "email_dateTXT";
	    this.email_dateTXT.ReadOnly = true;
	    this.email_dateTXT.Size = new System.Drawing.Size(1165, 43);
	    this.email_dateTXT.TabIndex = 2;
	    // 
	    // email_destTXT
	    // 
	    this.email_destTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_destTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_destTXT.Location = new System.Drawing.Point(173, 103);
	    this.email_destTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_destTXT.Name = "email_destTXT";
	    this.email_destTXT.ReadOnly = true;
	    this.email_destTXT.Size = new System.Drawing.Size(1165, 43);
	    this.email_destTXT.TabIndex = 1;
	    // 
	    // email_sourceTXT
	    // 
	    this.email_sourceTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.email_sourceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.email_sourceTXT.Location = new System.Drawing.Point(173, 21);
	    this.email_sourceTXT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.email_sourceTXT.Name = "email_sourceTXT";
	    this.email_sourceTXT.ReadOnly = true;
	    this.email_sourceTXT.Size = new System.Drawing.Size(1165, 43);
	    this.email_sourceTXT.TabIndex = 0;
	    // 
	    // Form_Email
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(2133, 1073);
	    this.Controls.Add(this.splitContainer1);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Email";
	    this.Text = "Email Manager";
	    this.Load += new System.EventHandler(this.FormEmail_Load);
	    this.splitContainer1.Panel1.ResumeLayout(false);
	    this.splitContainer1.Panel2.ResumeLayout(false);
	    this.splitContainer1.Panel2.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
	    this.splitContainer1.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.emailInboxBindingSource)).EndInit();
	    this.panel1.ResumeLayout(false);
	    this.panel1.PerformLayout();
	    this.email_header.ResumeLayout(false);
	    this.email_header.PerformLayout();
	    this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox email_inbox;
        private System.Windows.Forms.Button email_composeBTN;
        private System.Windows.Forms.Panel email_header;
        private System.Windows.Forms.TextBox email_fromSTXT;
        private System.Windows.Forms.TextBox email_dateSTXT;
        private System.Windows.Forms.TextBox email_toSTXT;
        private System.Windows.Forms.Button email_inboxBTN;
        private System.Windows.Forms.Button email_spamBTN;
        private System.Windows.Forms.Button email_flaggedBTN;
        private System.Windows.Forms.Button email_trashBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button email_mvtrashBTN;
        private System.Windows.Forms.Button email_mvspamBTN;
        private System.Windows.Forms.Button email_rplyallBTN;
        private System.Windows.Forms.Button email_forwardBTN;
        private System.Windows.Forms.Button email_replyBTN;
        public System.Windows.Forms.TextBox email_dateTXT;
        public System.Windows.Forms.TextBox email_destTXT;
        public System.Windows.Forms.TextBox email_sourceTXT;
        public System.Windows.Forms.TextBox email_bodyTXT;
        public System.Windows.Forms.TextBox email_subjectTXT;
        private System.Windows.Forms.BindingSource emailInboxBindingSource;
    }
}