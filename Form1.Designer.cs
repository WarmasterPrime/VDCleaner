namespace VDCleaner
{
	partial class Window
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.StorageTab = new System.Windows.Forms.TabPage();
			this.StorageControl = new System.Windows.Forms.TreeView();
			this.DriveTabControl = new System.Windows.Forms.TabPage();
			this.DriveRefreshBtn = new System.Windows.Forms.Button();
			this.NetworkTab = new System.Windows.Forms.TabPage();
			this.NetworkControl = new System.Windows.Forms.TreeView();
			this.FCTab = new System.Windows.Forms.TabPage();
			this.OrganizerLabelStatus = new System.Windows.Forms.Label();
			this.DirItemListControl = new System.Windows.Forms.ListBox();
			this.DirectorySelectorBtn = new System.Windows.Forms.Button();
			this.OrganizerTargetPathInput = new System.Windows.Forms.TextBox();
			this.OrganizerRunBtn = new System.Windows.Forms.Button();
			this.AboutTab = new System.Windows.Forms.TabPage();
			this.DoftPic = new System.Windows.Forms.PictureBox();
			this.VirtmaPic = new System.Windows.Forms.PictureBox();
			this.AutoRefreshCheckbox = new System.Windows.Forms.CheckBox();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SortingMethodControl = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.OrgInfoControl = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.OrgPanelControl = new System.Windows.Forms.Panel();
			this.OrgInfoTextControl = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.StorageTab.SuspendLayout();
			this.DriveTabControl.SuspendLayout();
			this.NetworkTab.SuspendLayout();
			this.FCTab.SuspendLayout();
			this.AboutTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DoftPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VirtmaPic)).BeginInit();
			this.MenuStrip.SuspendLayout();
			this.OrgInfoControl.SuspendLayout();
			this.OrgPanelControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.StorageTab);
			this.tabControl1.Controls.Add(this.DriveTabControl);
			this.tabControl1.Controls.Add(this.NetworkTab);
			this.tabControl1.Controls.Add(this.FCTab);
			this.tabControl1.Controls.Add(this.AboutTab);
			this.tabControl1.Location = new System.Drawing.Point(11, 47);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1320, 568);
			this.tabControl1.TabIndex = 0;
			// 
			// StorageTab
			// 
			this.StorageTab.BackColor = System.Drawing.Color.DimGray;
			this.StorageTab.Controls.Add(this.StorageControl);
			this.StorageTab.Location = new System.Drawing.Point(4, 22);
			this.StorageTab.Name = "StorageTab";
			this.StorageTab.Padding = new System.Windows.Forms.Padding(3);
			this.StorageTab.Size = new System.Drawing.Size(1312, 542);
			this.StorageTab.TabIndex = 0;
			this.StorageTab.Text = "Storage";
			// 
			// StorageControl
			// 
			this.StorageControl.BackColor = System.Drawing.Color.DimGray;
			this.StorageControl.ForeColor = System.Drawing.Color.White;
			this.StorageControl.Location = new System.Drawing.Point(6, 6);
			this.StorageControl.Name = "StorageControl";
			this.StorageControl.Size = new System.Drawing.Size(1299, 530);
			this.StorageControl.TabIndex = 0;
			// 
			// DriveTabControl
			// 
			this.DriveTabControl.BackColor = System.Drawing.Color.DimGray;
			this.DriveTabControl.Controls.Add(this.DriveRefreshBtn);
			this.DriveTabControl.Location = new System.Drawing.Point(4, 22);
			this.DriveTabControl.Name = "DriveTabControl";
			this.DriveTabControl.Padding = new System.Windows.Forms.Padding(3);
			this.DriveTabControl.Size = new System.Drawing.Size(1312, 542);
			this.DriveTabControl.TabIndex = 1;
			this.DriveTabControl.Text = "Drives";
			// 
			// DriveRefreshBtn
			// 
			this.DriveRefreshBtn.BackColor = System.Drawing.Color.Black;
			this.DriveRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DriveRefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DriveRefreshBtn.Location = new System.Drawing.Point(1270, 6);
			this.DriveRefreshBtn.Name = "DriveRefreshBtn";
			this.DriveRefreshBtn.Size = new System.Drawing.Size(35, 35);
			this.DriveRefreshBtn.TabIndex = 0;
			this.DriveRefreshBtn.Text = "↺";
			this.DriveRefreshBtn.UseVisualStyleBackColor = false;
			this.DriveRefreshBtn.Click += new System.EventHandler(this.DriveRefresh_Click);
			// 
			// NetworkTab
			// 
			this.NetworkTab.BackColor = System.Drawing.Color.DimGray;
			this.NetworkTab.Controls.Add(this.NetworkControl);
			this.NetworkTab.Location = new System.Drawing.Point(4, 22);
			this.NetworkTab.Name = "NetworkTab";
			this.NetworkTab.Padding = new System.Windows.Forms.Padding(3);
			this.NetworkTab.Size = new System.Drawing.Size(1312, 542);
			this.NetworkTab.TabIndex = 2;
			this.NetworkTab.Text = "Network";
			// 
			// NetworkControl
			// 
			this.NetworkControl.BackColor = System.Drawing.Color.DimGray;
			this.NetworkControl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NetworkControl.ForeColor = System.Drawing.Color.White;
			this.NetworkControl.Location = new System.Drawing.Point(6, 6);
			this.NetworkControl.Name = "NetworkControl";
			this.NetworkControl.Size = new System.Drawing.Size(1299, 530);
			this.NetworkControl.TabIndex = 0;
			// 
			// FCTab
			// 
			this.FCTab.BackColor = System.Drawing.Color.DimGray;
			this.FCTab.Controls.Add(this.OrgPanelControl);
			this.FCTab.Controls.Add(this.OrgInfoControl);
			this.FCTab.Controls.Add(this.label1);
			this.FCTab.Controls.Add(this.SortingMethodControl);
			this.FCTab.ForeColor = System.Drawing.Color.White;
			this.FCTab.Location = new System.Drawing.Point(4, 22);
			this.FCTab.Name = "FCTab";
			this.FCTab.Padding = new System.Windows.Forms.Padding(3);
			this.FCTab.Size = new System.Drawing.Size(1312, 542);
			this.FCTab.TabIndex = 3;
			this.FCTab.Text = "File Organization";
			// 
			// OrganizerLabelStatus
			// 
			this.OrganizerLabelStatus.AutoSize = true;
			this.OrganizerLabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrganizerLabelStatus.ForeColor = System.Drawing.Color.Orange;
			this.OrganizerLabelStatus.Location = new System.Drawing.Point(170, 304);
			this.OrganizerLabelStatus.Name = "OrganizerLabelStatus";
			this.OrganizerLabelStatus.Size = new System.Drawing.Size(127, 17);
			this.OrganizerLabelStatus.TabIndex = 5;
			this.OrganizerLabelStatus.Text = "Ready To Run...";
			this.OrganizerLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DirItemListControl
			// 
			this.DirItemListControl.FormattingEnabled = true;
			this.DirItemListControl.Location = new System.Drawing.Point(112, 97);
			this.DirItemListControl.Name = "DirItemListControl";
			this.DirItemListControl.Size = new System.Drawing.Size(265, 186);
			this.DirItemListControl.TabIndex = 4;
			this.DirItemListControl.Leave += new System.EventHandler(this.UpdateItemList);
			// 
			// DirectorySelectorBtn
			// 
			this.DirectorySelectorBtn.BackColor = System.Drawing.Color.Black;
			this.DirectorySelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DirectorySelectorBtn.ForeColor = System.Drawing.Color.White;
			this.DirectorySelectorBtn.Location = new System.Drawing.Point(330, 53);
			this.DirectorySelectorBtn.Name = "DirectorySelectorBtn";
			this.DirectorySelectorBtn.Size = new System.Drawing.Size(47, 23);
			this.DirectorySelectorBtn.TabIndex = 3;
			this.DirectorySelectorBtn.Text = "● ● ●";
			this.DirectorySelectorBtn.UseVisualStyleBackColor = false;
			this.DirectorySelectorBtn.Click += new System.EventHandler(this.OpenFolderBrowserDialog_Click);
			// 
			// OrganizerTargetPathInput
			// 
			this.OrganizerTargetPathInput.Location = new System.Drawing.Point(112, 55);
			this.OrganizerTargetPathInput.Name = "OrganizerTargetPathInput";
			this.OrganizerTargetPathInput.Size = new System.Drawing.Size(212, 20);
			this.OrganizerTargetPathInput.TabIndex = 2;
			this.OrganizerTargetPathInput.Leave += new System.EventHandler(this.UpdateItemList);
			// 
			// OrganizerRunBtn
			// 
			this.OrganizerRunBtn.BackColor = System.Drawing.Color.Black;
			this.OrganizerRunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OrganizerRunBtn.ForeColor = System.Drawing.Color.White;
			this.OrganizerRunBtn.Location = new System.Drawing.Point(196, 375);
			this.OrganizerRunBtn.Name = "OrganizerRunBtn";
			this.OrganizerRunBtn.Size = new System.Drawing.Size(75, 23);
			this.OrganizerRunBtn.TabIndex = 1;
			this.OrganizerRunBtn.Text = "Organize";
			this.OrganizerRunBtn.UseVisualStyleBackColor = false;
			this.OrganizerRunBtn.Click += new System.EventHandler(this.OrganizeBtn_Click);
			// 
			// AboutTab
			// 
			this.AboutTab.BackColor = System.Drawing.Color.DimGray;
			this.AboutTab.Controls.Add(this.DoftPic);
			this.AboutTab.Controls.Add(this.VirtmaPic);
			this.AboutTab.Location = new System.Drawing.Point(4, 22);
			this.AboutTab.Name = "AboutTab";
			this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
			this.AboutTab.Size = new System.Drawing.Size(1312, 542);
			this.AboutTab.TabIndex = 4;
			this.AboutTab.Text = "About";
			// 
			// DoftPic
			// 
			this.DoftPic.Image = ((System.Drawing.Image)(resources.GetObject("DoftPic.Image")));
			this.DoftPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("DoftPic.InitialImage")));
			this.DoftPic.Location = new System.Drawing.Point(659, 6);
			this.DoftPic.Name = "DoftPic";
			this.DoftPic.Size = new System.Drawing.Size(650, 530);
			this.DoftPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DoftPic.TabIndex = 1;
			this.DoftPic.TabStop = false;
			// 
			// VirtmaPic
			// 
			this.VirtmaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.VirtmaPic.Image = ((System.Drawing.Image)(resources.GetObject("VirtmaPic.Image")));
			this.VirtmaPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("VirtmaPic.InitialImage")));
			this.VirtmaPic.Location = new System.Drawing.Point(6, 6);
			this.VirtmaPic.Name = "VirtmaPic";
			this.VirtmaPic.Size = new System.Drawing.Size(650, 530);
			this.VirtmaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.VirtmaPic.TabIndex = 0;
			this.VirtmaPic.TabStop = false;
			// 
			// AutoRefreshCheckbox
			// 
			this.AutoRefreshCheckbox.AutoSize = true;
			this.AutoRefreshCheckbox.Location = new System.Drawing.Point(1243, 27);
			this.AutoRefreshCheckbox.Name = "AutoRefreshCheckbox";
			this.AutoRefreshCheckbox.Size = new System.Drawing.Size(88, 17);
			this.AutoRefreshCheckbox.TabIndex = 1;
			this.AutoRefreshCheckbox.Text = "Auto Refresh";
			this.AutoRefreshCheckbox.UseVisualStyleBackColor = true;
			this.AutoRefreshCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(1343, 24);
			this.MenuStrip.TabIndex = 2;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionValueToolStripMenuItem});
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.versionToolStripMenuItem.Text = "Version";
			// 
			// versionValueToolStripMenuItem
			// 
			this.versionValueToolStripMenuItem.Name = "versionValueToolStripMenuItem";
			this.versionValueToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.versionValueToolStripMenuItem.Text = "VersionValue";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "DOFT Logo.ico");
			this.imageList1.Images.SetKeyName(1, "Virtma Logo.ico");
			this.imageList1.Images.SetKeyName(2, "Virtma Logo.png");
			this.imageList1.Images.SetKeyName(3, "DOFT Logo.png");
			this.imageList1.Images.SetKeyName(4, "KING SANTA.PNG");
			// 
			// SortingMethodControl
			// 
			this.SortingMethodControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SortingMethodControl.FormattingEnabled = true;
			this.SortingMethodControl.Location = new System.Drawing.Point(173, 17);
			this.SortingMethodControl.Name = "SortingMethodControl";
			this.SortingMethodControl.Size = new System.Drawing.Size(156, 21);
			this.SortingMethodControl.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Organization Method:";
			// 
			// OrgInfoControl
			// 
			this.OrgInfoControl.Controls.Add(this.OrgInfoTextControl);
			this.OrgInfoControl.ForeColor = System.Drawing.Color.White;
			this.OrgInfoControl.Location = new System.Drawing.Point(10, 49);
			this.OrgInfoControl.Name = "OrgInfoControl";
			this.OrgInfoControl.Size = new System.Drawing.Size(319, 259);
			this.OrgInfoControl.TabIndex = 8;
			this.OrgInfoControl.TabStop = false;
			this.OrgInfoControl.Text = "Information";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Path:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// OrgPanelControl
			// 
			this.OrgPanelControl.Controls.Add(this.DirItemListControl);
			this.OrgPanelControl.Controls.Add(this.label2);
			this.OrgPanelControl.Controls.Add(this.OrganizerRunBtn);
			this.OrgPanelControl.Controls.Add(this.OrganizerTargetPathInput);
			this.OrgPanelControl.Controls.Add(this.DirectorySelectorBtn);
			this.OrgPanelControl.Controls.Add(this.OrganizerLabelStatus);
			this.OrgPanelControl.Location = new System.Drawing.Point(409, 6);
			this.OrgPanelControl.Name = "OrgPanelControl";
			this.OrgPanelControl.Size = new System.Drawing.Size(484, 530);
			this.OrgPanelControl.TabIndex = 10;
			// 
			// OrgInfoTextControl
			// 
			this.OrgInfoTextControl.AutoSize = true;
			this.OrgInfoTextControl.Location = new System.Drawing.Point(7, 20);
			this.OrgInfoTextControl.Name = "OrgInfoTextControl";
			this.OrgInfoTextControl.Size = new System.Drawing.Size(42, 13);
			this.OrgInfoTextControl.TabIndex = 0;
			this.OrgInfoTextControl.Text = "No Info";
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1343, 627);
			this.Controls.Add(this.AutoRefreshCheckbox);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.MenuStrip);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "Window";
			this.Text = "VDC Tools";
			this.Load += new System.EventHandler(this.Window_Load);
			this.tabControl1.ResumeLayout(false);
			this.StorageTab.ResumeLayout(false);
			this.DriveTabControl.ResumeLayout(false);
			this.NetworkTab.ResumeLayout(false);
			this.FCTab.ResumeLayout(false);
			this.FCTab.PerformLayout();
			this.AboutTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DoftPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VirtmaPic)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.OrgInfoControl.ResumeLayout(false);
			this.OrgInfoControl.PerformLayout();
			this.OrgPanelControl.ResumeLayout(false);
			this.OrgPanelControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage StorageTab;
		public System.Windows.Forms.TreeView StorageControl;
		public System.Windows.Forms.TabPage DriveTabControl;
		private System.Windows.Forms.Button DriveRefreshBtn;
		public System.Windows.Forms.CheckBox AutoRefreshCheckbox;
		private System.Windows.Forms.TabPage NetworkTab;
		private System.Windows.Forms.TreeView NetworkControl;
		private System.Windows.Forms.TabPage FCTab;
		private System.Windows.Forms.Button OrganizerRunBtn;
		public System.Windows.Forms.Button DirectorySelectorBtn;
		public System.Windows.Forms.TextBox OrganizerTargetPathInput;
		public System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
		public System.Windows.Forms.ListBox DirItemListControl;
		public System.Windows.Forms.Label OrganizerLabelStatus;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionValueToolStripMenuItem;
		public System.Windows.Forms.PictureBox VirtmaPic;
		public System.Windows.Forms.PictureBox DoftPic;
		public System.Windows.Forms.TabPage AboutTab;
		private System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.GroupBox OrgInfoControl;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox SortingMethodControl;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Panel OrgPanelControl;
		public System.Windows.Forms.Label OrgInfoTextControl;
	}
}

