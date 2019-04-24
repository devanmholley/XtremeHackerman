namespace XtremeHackerman
{
    partial class Form_Wireshark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Wireshark));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.telephonyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wirelessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wirelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.DisplayFilterText = new System.Windows.Forms.RichTextBox();
            this.EthernetConnectionBTN = new System.Windows.Forms.Button();
            this.WiFIConnectionBTN = new System.Windows.Forms.Button();
            this.BluetoothConnectionBTN = new System.Windows.Forms.Button();
            this.CaptureLBL = new System.Windows.Forms.Label();
            this.ProfileStatusLabel = new System.Windows.Forms.Label();
            this.ReadyState = new System.Windows.Forms.Label();
            this.EthernetConnectionDisplay = new System.Windows.Forms.PictureBox();
            this.BluetoothConnectionTrack = new System.Windows.Forms.PictureBox();
            this.WiFIConnectionTrack = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ConnectionDisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.NoTableLabel = new System.Windows.Forms.Label();
            this.TimeTableLabel = new System.Windows.Forms.Label();
            this.SourceTableLabel = new System.Windows.Forms.Label();
            this.DestinationTableLabel = new System.Windows.Forms.Label();
            this.ProtocolTableLabel = new System.Windows.Forms.Label();
            this.LengthTableLabel = new System.Windows.Forms.Label();
            this.InfoTableLabel = new System.Windows.Forms.Label();
            this.NumberFieldEntry = new System.Windows.Forms.Label();
            this.TimeFieldEntry = new System.Windows.Forms.Label();
            this.SourceFieldEntry = new System.Windows.Forms.Label();
            this.DestinationFieldEntry = new System.Windows.Forms.Label();
            this.ProtocolFieldEntry = new System.Windows.Forms.Label();
            this.LengthFieldEntry = new System.Windows.Forms.Label();
            this.InfoFieldEntry = new System.Windows.Forms.Label();
            this.wiresharkEthernetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EthernetConnectionDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluetoothConnectionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WiFIConnectionTrack)).BeginInit();
            this.ConnectionDisplayTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiresharkEthernetDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem1,
            this.goToolStripMenuItem1,
            this.captureToolStripMenuItem1,
            this.analyzeToolStripMenuItem1,
            this.statisticsToolStripMenuItem1,
            this.telephonyToolStripMenuItem1,
            this.wirelessToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            resources.ApplyResources(this.editToolStripMenuItem1, "editToolStripMenuItem1");
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            resources.ApplyResources(this.viewToolStripMenuItem1, "viewToolStripMenuItem1");
            // 
            // goToolStripMenuItem1
            // 
            this.goToolStripMenuItem1.Name = "goToolStripMenuItem1";
            resources.ApplyResources(this.goToolStripMenuItem1, "goToolStripMenuItem1");
            // 
            // captureToolStripMenuItem1
            // 
            this.captureToolStripMenuItem1.Name = "captureToolStripMenuItem1";
            resources.ApplyResources(this.captureToolStripMenuItem1, "captureToolStripMenuItem1");
            // 
            // analyzeToolStripMenuItem1
            // 
            this.analyzeToolStripMenuItem1.Name = "analyzeToolStripMenuItem1";
            resources.ApplyResources(this.analyzeToolStripMenuItem1, "analyzeToolStripMenuItem1");
            // 
            // statisticsToolStripMenuItem1
            // 
            this.statisticsToolStripMenuItem1.Name = "statisticsToolStripMenuItem1";
            resources.ApplyResources(this.statisticsToolStripMenuItem1, "statisticsToolStripMenuItem1");
            // 
            // telephonyToolStripMenuItem1
            // 
            this.telephonyToolStripMenuItem1.Name = "telephonyToolStripMenuItem1";
            resources.ApplyResources(this.telephonyToolStripMenuItem1, "telephonyToolStripMenuItem1");
            // 
            // wirelessToolStripMenuItem1
            // 
            this.wirelessToolStripMenuItem1.Name = "wirelessToolStripMenuItem1";
            resources.ApplyResources(this.wirelessToolStripMenuItem1, "wirelessToolStripMenuItem1");
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            resources.ApplyResources(this.toolsToolStripMenuItem1, "toolsToolStripMenuItem1");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.mergeToolStripMenuItem,
            this.importToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.fileSetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            resources.ApplyResources(this.mergeToolStripMenuItem, "mergeToolStripMenuItem");
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            // 
            // fileSetToolStripMenuItem
            // 
            this.fileSetToolStripMenuItem.Name = "fileSetToolStripMenuItem";
            resources.ApplyResources(this.fileSetToolStripMenuItem, "fileSetToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            resources.ApplyResources(this.goToolStripMenuItem, "goToolStripMenuItem");
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            resources.ApplyResources(this.captureToolStripMenuItem, "captureToolStripMenuItem");
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            resources.ApplyResources(this.analyzeToolStripMenuItem, "analyzeToolStripMenuItem");
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            resources.ApplyResources(this.statisticsToolStripMenuItem, "statisticsToolStripMenuItem");
            // 
            // telephonyToolStripMenuItem
            // 
            this.telephonyToolStripMenuItem.Name = "telephonyToolStripMenuItem";
            resources.ApplyResources(this.telephonyToolStripMenuItem, "telephonyToolStripMenuItem");
            // 
            // wirelessToolStripMenuItem
            // 
            this.wirelessToolStripMenuItem.Name = "wirelessToolStripMenuItem";
            resources.ApplyResources(this.wirelessToolStripMenuItem, "wirelessToolStripMenuItem");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::XtremeHackerman.Properties.Resources.Icon_Wireshark;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::XtremeHackerman.Properties.Resources.Icon_Wireshark;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // DisplayFilterText
            // 
            resources.ApplyResources(this.DisplayFilterText, "DisplayFilterText");
            this.DisplayFilterText.Name = "DisplayFilterText";
            // 
            // EthernetConnectionBTN
            // 
            this.EthernetConnectionBTN.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.EthernetConnectionBTN, "EthernetConnectionBTN");
            this.EthernetConnectionBTN.Name = "EthernetConnectionBTN";
            this.EthernetConnectionBTN.UseVisualStyleBackColor = false;
            this.EthernetConnectionBTN.Click += new System.EventHandler(this.EthernetConnectionBTN_Click);
            // 
            // WiFIConnectionBTN
            // 
            this.WiFIConnectionBTN.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.WiFIConnectionBTN, "WiFIConnectionBTN");
            this.WiFIConnectionBTN.Name = "WiFIConnectionBTN";
            this.WiFIConnectionBTN.UseVisualStyleBackColor = false;
            this.WiFIConnectionBTN.Click += new System.EventHandler(this.WiFIConnectionBTN_Click);
            // 
            // BluetoothConnectionBTN
            // 
            this.BluetoothConnectionBTN.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BluetoothConnectionBTN, "BluetoothConnectionBTN");
            this.BluetoothConnectionBTN.Name = "BluetoothConnectionBTN";
            this.BluetoothConnectionBTN.UseVisualStyleBackColor = false;
            // 
            // CaptureLBL
            // 
            resources.ApplyResources(this.CaptureLBL, "CaptureLBL");
            this.CaptureLBL.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CaptureLBL.Name = "CaptureLBL";
            this.CaptureLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProfileStatusLabel
            // 
            resources.ApplyResources(this.ProfileStatusLabel, "ProfileStatusLabel");
            this.ProfileStatusLabel.Name = "ProfileStatusLabel";
            // 
            // ReadyState
            // 
            resources.ApplyResources(this.ReadyState, "ReadyState");
            this.ReadyState.Name = "ReadyState";
            // 
            // EthernetConnectionDisplay
            // 
            this.EthernetConnectionDisplay.Image = global::XtremeHackerman.Properties.Resources.EthernetConnectionTrack2;
            resources.ApplyResources(this.EthernetConnectionDisplay, "EthernetConnectionDisplay");
            this.EthernetConnectionDisplay.Name = "EthernetConnectionDisplay";
            this.EthernetConnectionDisplay.TabStop = false;
            this.EthernetConnectionDisplay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BluetoothConnectionTrack
            // 
            this.BluetoothConnectionTrack.Image = global::XtremeHackerman.Properties.Resources.WiFiConnectionTrack;
            resources.ApplyResources(this.BluetoothConnectionTrack, "BluetoothConnectionTrack");
            this.BluetoothConnectionTrack.Name = "BluetoothConnectionTrack";
            this.BluetoothConnectionTrack.TabStop = false;
            // 
            // WiFIConnectionTrack
            // 
            this.WiFIConnectionTrack.Image = global::XtremeHackerman.Properties.Resources.WiFiConnectionTrack;
            resources.ApplyResources(this.WiFIConnectionTrack, "WiFIConnectionTrack");
            this.WiFIConnectionTrack.Name = "WiFIConnectionTrack";
            this.WiFIConnectionTrack.TabStop = false;
            // 
            // ConnectionDisplayTable
            // 
            resources.ApplyResources(this.ConnectionDisplayTable, "ConnectionDisplayTable");
            this.ConnectionDisplayTable.Controls.Add(this.InfoFieldEntry, 6, 1);
            this.ConnectionDisplayTable.Controls.Add(this.LengthFieldEntry, 5, 1);
            this.ConnectionDisplayTable.Controls.Add(this.ProtocolFieldEntry, 4, 1);
            this.ConnectionDisplayTable.Controls.Add(this.DestinationFieldEntry, 3, 1);
            this.ConnectionDisplayTable.Controls.Add(this.NoTableLabel, 0, 0);
            this.ConnectionDisplayTable.Controls.Add(this.TimeTableLabel, 1, 0);
            this.ConnectionDisplayTable.Controls.Add(this.SourceTableLabel, 2, 0);
            this.ConnectionDisplayTable.Controls.Add(this.DestinationTableLabel, 3, 0);
            this.ConnectionDisplayTable.Controls.Add(this.ProtocolTableLabel, 4, 0);
            this.ConnectionDisplayTable.Controls.Add(this.LengthTableLabel, 5, 0);
            this.ConnectionDisplayTable.Controls.Add(this.InfoTableLabel, 6, 0);
            this.ConnectionDisplayTable.Controls.Add(this.NumberFieldEntry, 0, 1);
            this.ConnectionDisplayTable.Controls.Add(this.TimeFieldEntry, 1, 1);
            this.ConnectionDisplayTable.Controls.Add(this.SourceFieldEntry, 2, 1);
            this.ConnectionDisplayTable.Name = "ConnectionDisplayTable";
            // 
            // NoTableLabel
            // 
            resources.ApplyResources(this.NoTableLabel, "NoTableLabel");
            this.NoTableLabel.Name = "NoTableLabel";
            // 
            // TimeTableLabel
            // 
            resources.ApplyResources(this.TimeTableLabel, "TimeTableLabel");
            this.TimeTableLabel.Name = "TimeTableLabel";
            // 
            // SourceTableLabel
            // 
            resources.ApplyResources(this.SourceTableLabel, "SourceTableLabel");
            this.SourceTableLabel.Name = "SourceTableLabel";
            // 
            // DestinationTableLabel
            // 
            resources.ApplyResources(this.DestinationTableLabel, "DestinationTableLabel");
            this.DestinationTableLabel.Name = "DestinationTableLabel";
            // 
            // ProtocolTableLabel
            // 
            resources.ApplyResources(this.ProtocolTableLabel, "ProtocolTableLabel");
            this.ProtocolTableLabel.Name = "ProtocolTableLabel";
            // 
            // LengthTableLabel
            // 
            resources.ApplyResources(this.LengthTableLabel, "LengthTableLabel");
            this.LengthTableLabel.Name = "LengthTableLabel";
            // 
            // InfoTableLabel
            // 
            resources.ApplyResources(this.InfoTableLabel, "InfoTableLabel");
            this.InfoTableLabel.Name = "InfoTableLabel";
            // 
            // NumberFieldEntry
            // 
            resources.ApplyResources(this.NumberFieldEntry, "NumberFieldEntry");
            this.NumberFieldEntry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wiresharkEthernetDataBindingSource, "No", true));
            this.NumberFieldEntry.Name = "NumberFieldEntry";
            // 
            // TimeFieldEntry
            // 
            resources.ApplyResources(this.TimeFieldEntry, "TimeFieldEntry");
            this.TimeFieldEntry.Name = "TimeFieldEntry";
            // 
            // SourceFieldEntry
            // 
            resources.ApplyResources(this.SourceFieldEntry, "SourceFieldEntry");
            this.SourceFieldEntry.Name = "SourceFieldEntry";
            // 
            // DestinationFieldEntry
            // 
            resources.ApplyResources(this.DestinationFieldEntry, "DestinationFieldEntry");
            this.DestinationFieldEntry.Name = "DestinationFieldEntry";
            // 
            // ProtocolFieldEntry
            // 
            resources.ApplyResources(this.ProtocolFieldEntry, "ProtocolFieldEntry");
            this.ProtocolFieldEntry.Name = "ProtocolFieldEntry";
            // 
            // LengthFieldEntry
            // 
            resources.ApplyResources(this.LengthFieldEntry, "LengthFieldEntry");
            this.LengthFieldEntry.Name = "LengthFieldEntry";
            // 
            // InfoFieldEntry
            // 
            resources.ApplyResources(this.InfoFieldEntry, "InfoFieldEntry");
            this.InfoFieldEntry.Name = "InfoFieldEntry";
            // 
            // wiresharkEthernetDataBindingSource
            // 
            this.wiresharkEthernetDataBindingSource.DataSource = typeof(XtremeHackerman.Classes.WiresharkEthernetData);
            // 
            // Form_Wireshark
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectionDisplayTable);
            this.Controls.Add(this.WiFIConnectionTrack);
            this.Controls.Add(this.BluetoothConnectionTrack);
            this.Controls.Add(this.EthernetConnectionDisplay);
            this.Controls.Add(this.ReadyState);
            this.Controls.Add(this.ProfileStatusLabel);
            this.Controls.Add(this.CaptureLBL);
            this.Controls.Add(this.BluetoothConnectionBTN);
            this.Controls.Add(this.WiFIConnectionBTN);
            this.Controls.Add(this.EthernetConnectionBTN);
            this.Controls.Add(this.DisplayFilterText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Wireshark";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Wireshark_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EthernetConnectionDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluetoothConnectionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WiFIConnectionTrack)).EndInit();
            this.ConnectionDisplayTable.ResumeLayout(false);
            this.ConnectionDisplayTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiresharkEthernetDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telephonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wirelessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem telephonyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wirelessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.RichTextBox DisplayFilterText;
        private System.Windows.Forms.Button EthernetConnectionBTN;
        private System.Windows.Forms.Button WiFIConnectionBTN;
        private System.Windows.Forms.Button BluetoothConnectionBTN;
        private System.Windows.Forms.Label CaptureLBL;
        private System.Windows.Forms.Label ProfileStatusLabel;
        private System.Windows.Forms.Label ReadyState;
        private System.Windows.Forms.PictureBox EthernetConnectionDisplay;
        private System.Windows.Forms.PictureBox BluetoothConnectionTrack;
        private System.Windows.Forms.PictureBox WiFIConnectionTrack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel ConnectionDisplayTable;
        private System.Windows.Forms.Label NoTableLabel;
        private System.Windows.Forms.Label TimeTableLabel;
        private System.Windows.Forms.Label SourceTableLabel;
        private System.Windows.Forms.Label DestinationTableLabel;
        private System.Windows.Forms.Label ProtocolTableLabel;
        private System.Windows.Forms.Label LengthTableLabel;
        private System.Windows.Forms.Label InfoTableLabel;
        private System.Windows.Forms.Label InfoFieldEntry;
        private System.Windows.Forms.Label LengthFieldEntry;
        private System.Windows.Forms.Label ProtocolFieldEntry;
        private System.Windows.Forms.Label DestinationFieldEntry;
        private System.Windows.Forms.Label NumberFieldEntry;
        private System.Windows.Forms.Label TimeFieldEntry;
        private System.Windows.Forms.Label SourceFieldEntry;
        private System.Windows.Forms.BindingSource wiresharkEthernetDataBindingSource;
    }
}