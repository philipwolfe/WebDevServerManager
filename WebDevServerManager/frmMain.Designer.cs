namespace WebDevServerManager
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.listView1 = new System.Windows.Forms.ListView();
			this.colIcon = new System.Windows.Forms.ColumnHeader();
			this.colPort = new System.Windows.Forms.ColumnHeader();
			this.colVdir = new System.Windows.Forms.ColumnHeader();
			this.colFolder = new System.Windows.Forms.ColumnHeader();
			this.siteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.siteCTXMNUView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.siteCTXMNUStart = new System.Windows.Forms.ToolStripMenuItem();
			this.siteCTXMNURestart = new System.Windows.Forms.ToolStripMenuItem();
			this.siteCTXMNUStop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.siteCTXMNUDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.foldersDataSet = new WebDevServerManager.Folders();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtVirtualPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhysicalPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.physicalPathFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.iconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.iconCTXMNUExit = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.foldersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider1 = new WebDevServerManager.SmartErrorProvider(this.components);
			this.siteContextMenu.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foldersDataSet)).BeginInit();
			this.iconContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foldersDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIcon,
            this.colPort,
            this.colVdir,
            this.colFolder});
			this.listView1.ContextMenuStrip = this.siteContextMenu;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.LabelEdit = true;
			this.listView1.Location = new System.Drawing.Point(0, 24);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(752, 172);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// colIcon
			// 
			this.colIcon.Text = "";
			this.colIcon.Width = 20;
			// 
			// colPort
			// 
			this.colPort.Text = "Port";
			this.colPort.Width = 42;
			// 
			// colVdir
			// 
			this.colVdir.Text = "Virtual Path";
			this.colVdir.Width = 153;
			// 
			// colFolder
			// 
			this.colFolder.Text = "Physical Path";
			this.colFolder.Width = 519;
			// 
			// siteContextMenu
			// 
			this.siteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteCTXMNUView,
            this.toolStripMenuItem2,
            this.siteCTXMNUStart,
            this.siteCTXMNURestart,
            this.siteCTXMNUStop,
            this.toolStripMenuItem1,
            this.siteCTXMNUDelete});
			this.siteContextMenu.Name = "siteContextMenu";
			this.siteContextMenu.Size = new System.Drawing.Size(161, 126);
			this.siteContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.siteContextMenu_Opening);
			// 
			// siteCTXMNUView
			// 
			this.siteCTXMNUView.Image = ((System.Drawing.Image)(resources.GetObject("siteCTXMNUView.Image")));
			this.siteCTXMNUView.Name = "siteCTXMNUView";
			this.siteCTXMNUView.Size = new System.Drawing.Size(160, 22);
			this.siteCTXMNUView.Text = "View in Browser";
			this.siteCTXMNUView.Click += new System.EventHandler(this.siteCTXMNUView_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
			// 
			// siteCTXMNUStart
			// 
			this.siteCTXMNUStart.Image = global::WebDevServerManager.Properties.Resources.green_light;
			this.siteCTXMNUStart.Name = "siteCTXMNUStart";
			this.siteCTXMNUStart.Size = new System.Drawing.Size(160, 22);
			this.siteCTXMNUStart.Text = "Start";
			this.siteCTXMNUStart.Click += new System.EventHandler(this.siteCTXMNUStart_Click);
			// 
			// siteCTXMNURestart
			// 
			this.siteCTXMNURestart.Image = global::WebDevServerManager.Properties.Resources.yellow_light;
			this.siteCTXMNURestart.Name = "siteCTXMNURestart";
			this.siteCTXMNURestart.Size = new System.Drawing.Size(160, 22);
			this.siteCTXMNURestart.Text = "Restart";
			this.siteCTXMNURestart.Click += new System.EventHandler(this.siteCTXMNURestart_Click);
			// 
			// siteCTXMNUStop
			// 
			this.siteCTXMNUStop.Image = global::WebDevServerManager.Properties.Resources.red_light;
			this.siteCTXMNUStop.Name = "siteCTXMNUStop";
			this.siteCTXMNUStop.Size = new System.Drawing.Size(160, 22);
			this.siteCTXMNUStop.Text = "Stop";
			this.siteCTXMNUStop.Click += new System.EventHandler(this.siteCTXMNUStop_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
			// 
			// siteCTXMNUDelete
			// 
			this.siteCTXMNUDelete.Image = ((System.Drawing.Image)(resources.GetObject("siteCTXMNUDelete.Image")));
			this.siteCTXMNUDelete.Name = "siteCTXMNUDelete";
			this.siteCTXMNUDelete.Size = new System.Drawing.Size(160, 22);
			this.siteCTXMNUDelete.Text = "Delete";
			this.siteCTXMNUDelete.Click += new System.EventHandler(this.siteCTXMNUDelete_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "red_light.gif");
			this.imageList1.Images.SetKeyName(1, "green_light.gif");
			this.imageList1.Images.SetKeyName(2, "yellow_light.gif");
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(752, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileImport,
            this.mnuFileExport,
            this.toolStripMenuItem3,
            this.mnuFileExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(35, 20);
			this.mnuFile.Text = "&File";
			// 
			// mnuFileImport
			// 
			this.mnuFileImport.Name = "mnuFileImport";
			this.mnuFileImport.Size = new System.Drawing.Size(129, 22);
			this.mnuFileImport.Text = "&Import...";
			this.mnuFileImport.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// mnuFileExport
			// 
			this.mnuFileExport.Name = "mnuFileExport";
			this.mnuFileExport.Size = new System.Drawing.Size(129, 22);
			this.mnuFileExport.Text = "&Export...";
			this.mnuFileExport.Click += new System.EventHandler(this.mnuFileExport_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new System.Drawing.Size(129, 22);
			this.mnuFileExit.Text = "E&xit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(40, 20);
			this.mnuHelp.Text = "&Help";
			// 
			// mnuHelpAbout
			// 
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(126, 22);
			this.mnuHelpAbout.Text = "&About...";
			this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 237);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(752, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(38, 17);
			this.lblStatus.Text = "Ready";
			// 
			// foldersDataSet
			// 
			this.foldersDataSet.DataSetName = "Folders";
			this.foldersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPort.Location = new System.Drawing.Point(12, 214);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(86, 20);
			this.txtPort.TabIndex = 4;
			this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtPort_Validating);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(115, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Virtual Path:";
			// 
			// txtVirtualPath
			// 
			this.txtVirtualPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtVirtualPath.Location = new System.Drawing.Point(118, 214);
			this.txtVirtualPath.Name = "txtVirtualPath";
			this.txtVirtualPath.Size = new System.Drawing.Size(85, 20);
			this.txtVirtualPath.TabIndex = 6;
			this.txtVirtualPath.Text = "/";
			this.txtVirtualPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtVirtualPath_Validating);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(221, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Physical Path:";
			// 
			// txtPhysicalPath
			// 
			this.txtPhysicalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPhysicalPath.Location = new System.Drawing.Point(224, 214);
			this.txtPhysicalPath.Name = "txtPhysicalPath";
			this.txtPhysicalPath.Size = new System.Drawing.Size(341, 20);
			this.txtPhysicalPath.TabIndex = 8;
			this.txtPhysicalPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhysicalPath_Validating);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBrowse.Location = new System.Drawing.Point(590, 212);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 9;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(671, 211);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// physicalPathFolderDlg
			// 
			this.physicalPathFolderDlg.ShowNewFolderButton = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.iconContextMenu;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "WebDev Server Manager";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// iconContextMenu
			// 
			this.iconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconCTXMNUExit});
			this.iconContextMenu.Name = "iconContextMenu";
			this.iconContextMenu.Size = new System.Drawing.Size(104, 26);
			// 
			// iconCTXMNUExit
			// 
			this.iconCTXMNUExit.Name = "iconCTXMNUExit";
			this.iconCTXMNUExit.Size = new System.Drawing.Size(103, 22);
			this.iconCTXMNUExit.Text = "Exit";
			this.iconCTXMNUExit.Click += new System.EventHandler(this.iconCTXMNUExit_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "folders.xml";
			this.openFileDialog1.Filter = "Xml Files|*.xml|All Files|*.*";
			this.openFileDialog1.Title = "Import Folders file";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "xml";
			this.saveFileDialog1.FileName = "WebSites.xml";
			this.saveFileDialog1.Filter = "Xml Files|*.xml|All Files|*.*";
			this.saveFileDialog1.Title = "Export Folders";
			// 
			// foldersDataSetBindingSource
			// 
			this.foldersDataSetBindingSource.DataMember = "WebSite";
			this.foldersDataSetBindingSource.DataSource = this.foldersDataSet;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 259);
			this.Controls.Add(this.txtPhysicalPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtVirtualPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(760, 286);
			this.Name = "frmMain";
			this.Text = "WebDev Server Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.siteContextMenu.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.foldersDataSet)).EndInit();
			this.iconContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.foldersDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader colIcon;
		private System.Windows.Forms.ColumnHeader colPort;
		private System.Windows.Forms.ColumnHeader colFolder;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
		private Folders foldersDataSet;
		private System.Windows.Forms.ColumnHeader colVdir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtVirtualPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhysicalPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ContextMenuStrip siteContextMenu;
		private System.Windows.Forms.FolderBrowserDialog physicalPathFolderDlg;
		private System.Windows.Forms.ToolStripMenuItem siteCTXMNUStart;
		private System.Windows.Forms.ToolStripMenuItem siteCTXMNUStop;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem siteCTXMNUDelete;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem siteCTXMNUView;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private SmartErrorProvider errorProvider1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem siteCTXMNURestart;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
		private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ContextMenuStrip iconContextMenu;
		private System.Windows.Forms.ToolStripMenuItem iconCTXMNUExit;
		private System.Windows.Forms.BindingSource foldersDataSetBindingSource;
	}
}

