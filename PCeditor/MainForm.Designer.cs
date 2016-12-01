namespace PCeditor
{
	partial class editor
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
			this.regedit = new System.Windows.Forms.Button();
			this.create = new System.Windows.Forms.Button();
			this.bsod = new System.Windows.Forms.Button();
			this.menu2 = new System.Windows.Forms.TabControl();
			this.startupmanager = new System.Windows.Forms.TabPage();
			this.sm_bar = new System.Windows.Forms.ToolStrip();
			this.sm_add = new System.Windows.Forms.ToolStripButton();
			this.sm_rem = new System.Windows.Forms.ToolStripButton();
			this.sm_mod = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.startuptype = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.lbKeys = new System.Windows.Forms.ListBox();
			this.contextitems = new System.Windows.Forms.TabPage();
			this.processcloak = new System.Windows.Forms.TabPage();
			this.browseprocess = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dir = new System.Windows.Forms.TextBox();
			this.proc = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.container = new System.Windows.Forms.SplitContainer();
			this.button2 = new System.Windows.Forms.Button();
			this.createfile = new System.Windows.Forms.SaveFileDialog();
			this.startindir = new System.Windows.Forms.FolderBrowserDialog();
			this.menu2.SuspendLayout();
			this.startupmanager.SuspendLayout();
			this.sm_bar.SuspendLayout();
			this.processcloak.SuspendLayout();
			this.container.Panel1.SuspendLayout();
			this.container.Panel2.SuspendLayout();
			this.container.SuspendLayout();
			this.SuspendLayout();
			// 
			// regedit
			// 
			this.regedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.regedit.Location = new System.Drawing.Point(3, 3);
			this.regedit.Name = "regedit";
			this.regedit.Size = new System.Drawing.Size(89, 19);
			this.regedit.TabIndex = 0;
			this.regedit.Text = "Registry Editor";
			this.regedit.UseVisualStyleBackColor = true;
			this.regedit.Click += new System.EventHandler(this.RegeditClick);
			// 
			// create
			// 
			this.create.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.create.Location = new System.Drawing.Point(4, 56);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(89, 20);
			this.create.TabIndex = 1;
			this.create.Text = "Create file";
			this.create.UseVisualStyleBackColor = true;
			this.create.Click += new System.EventHandler(this.CreateClick);
			// 
			// bsod
			// 
			this.bsod.Location = new System.Drawing.Point(3, 28);
			this.bsod.Name = "bsod";
			this.bsod.Size = new System.Drawing.Size(89, 22);
			this.bsod.TabIndex = 2;
			this.bsod.Text = "Crash computer";
			this.bsod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bsod.UseVisualStyleBackColor = true;
			this.bsod.Click += new System.EventHandler(this.BsodClick);
			// 
			// menu2
			// 
			this.menu2.AllowDrop = true;
			this.menu2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.menu2.Controls.Add(this.startupmanager);
			this.menu2.Controls.Add(this.contextitems);
			this.menu2.Controls.Add(this.processcloak);
			this.menu2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menu2.Location = new System.Drawing.Point(0, 0);
			this.menu2.Name = "menu2";
			this.menu2.SelectedIndex = 0;
			this.menu2.Size = new System.Drawing.Size(369, 446);
			this.menu2.TabIndex = 0;
			// 
			// startupmanager
			// 
			this.startupmanager.Controls.Add(this.sm_bar);
			this.startupmanager.Controls.Add(this.lbKeys);
			this.startupmanager.Location = new System.Drawing.Point(4, 25);
			this.startupmanager.Name = "startupmanager";
			this.startupmanager.Padding = new System.Windows.Forms.Padding(3);
			this.startupmanager.Size = new System.Drawing.Size(361, 417);
			this.startupmanager.TabIndex = 1;
			this.startupmanager.Text = "Startup Manager";
			this.startupmanager.UseVisualStyleBackColor = true;
			// 
			// sm_bar
			// 
			this.sm_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sm_add,
									this.sm_rem,
									this.sm_mod,
									this.toolStripSeparator2,
									this.toolStripLabel1,
									this.startuptype,
									this.toolStripSeparator1,
									this.toolStripButton1});
			this.sm_bar.Location = new System.Drawing.Point(3, 384);
			this.sm_bar.Name = "sm_bar";
			this.sm_bar.Size = new System.Drawing.Size(355, 27);
			this.sm_bar.TabIndex = 1;
			this.sm_bar.Text = "Startup manager toolbar";
			// 
			// sm_add
			// 
			this.sm_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sm_add.Image = ((System.Drawing.Image)(resources.GetObject("sm_add.Image")));
			this.sm_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sm_add.Name = "sm_add";
			this.sm_add.Size = new System.Drawing.Size(23, 24);
			this.sm_add.Text = "Add";
			this.sm_add.Click += new System.EventHandler(this.Sm_addClick);
			// 
			// sm_rem
			// 
			this.sm_rem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sm_rem.Image = ((System.Drawing.Image)(resources.GetObject("sm_rem.Image")));
			this.sm_rem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sm_rem.Name = "sm_rem";
			this.sm_rem.Size = new System.Drawing.Size(23, 24);
			this.sm_rem.Text = "Remove";
			this.sm_rem.Click += new System.EventHandler(this.Sm_remClick);
			// 
			// sm_mod
			// 
			this.sm_mod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sm_mod.Image = ((System.Drawing.Image)(resources.GetObject("sm_mod.Image")));
			this.sm_mod.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.sm_mod.Name = "sm_mod";
			this.sm_mod.Size = new System.Drawing.Size(23, 24);
			this.sm_mod.Text = "Modify";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(86, 24);
			this.toolStripLabel1.Text = "Startup type:";
			// 
			// startuptype
			// 
			this.startuptype.AutoCompleteCustomSource.AddRange(new string[] {
									"Boot",
									"Logon",
									"Services",
									"(Scheduled Tasks)"});
			this.startuptype.AutoSize = false;
			this.startuptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.startuptype.DropDownWidth = 120;
			this.startuptype.Items.AddRange(new object[] {
									"Boot",
									"Logon",
									"Services",
									"(Scheduled Tasks)"});
			this.startuptype.MaxDropDownItems = 4;
			this.startuptype.Name = "startuptype";
			this.startuptype.Size = new System.Drawing.Size(75, 27);
			this.startuptype.Click += new System.EventHandler(this.StartuptypeClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
			this.toolStripButton1.Text = "Test";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// lbKeys
			// 
			this.lbKeys.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbKeys.FormattingEnabled = true;
			this.lbKeys.Location = new System.Drawing.Point(3, 3);
			this.lbKeys.Name = "lbKeys";
			this.lbKeys.Size = new System.Drawing.Size(355, 381);
			this.lbKeys.TabIndex = 0;
			this.lbKeys.SelectedIndexChanged += new System.EventHandler(this.LbKeysSelectedIndexChanged);
			// 
			// contextitems
			// 
			this.contextitems.Location = new System.Drawing.Point(4, 25);
			this.contextitems.Name = "contextitems";
			this.contextitems.Padding = new System.Windows.Forms.Padding(3);
			this.contextitems.Size = new System.Drawing.Size(361, 417);
			this.contextitems.TabIndex = 2;
			this.contextitems.Text = "Context items";
			this.contextitems.UseVisualStyleBackColor = true;
			// 
			// processcloak
			// 
			this.processcloak.Controls.Add(this.browseprocess);
			this.processcloak.Controls.Add(this.label2);
			this.processcloak.Controls.Add(this.label1);
			this.processcloak.Controls.Add(this.dir);
			this.processcloak.Controls.Add(this.proc);
			this.processcloak.Controls.Add(this.button1);
			this.processcloak.Location = new System.Drawing.Point(4, 25);
			this.processcloak.Name = "processcloak";
			this.processcloak.Padding = new System.Windows.Forms.Padding(3);
			this.processcloak.Size = new System.Drawing.Size(361, 417);
			this.processcloak.TabIndex = 3;
			this.processcloak.Text = "Process Cloaker";
			this.processcloak.UseVisualStyleBackColor = true;
			// 
			// browseprocess
			// 
			this.browseprocess.Location = new System.Drawing.Point(225, 28);
			this.browseprocess.Name = "browseprocess";
			this.browseprocess.Size = new System.Drawing.Size(53, 22);
			this.browseprocess.TabIndex = 5;
			this.browseprocess.Text = "Browse";
			this.browseprocess.UseVisualStyleBackColor = true;
			this.browseprocess.Click += new System.EventHandler(this.BrowseprocessClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Start in";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Process name";
			// 
			// dir
			// 
			this.dir.Location = new System.Drawing.Point(93, 29);
			this.dir.Name = "dir";
			this.dir.ReadOnly = true;
			this.dir.Size = new System.Drawing.Size(126, 20);
			this.dir.TabIndex = 2;
			// 
			// proc
			// 
			this.proc.Location = new System.Drawing.Point(93, 3);
			this.proc.Name = "proc";
			this.proc.Size = new System.Drawing.Size(184, 20);
			this.proc.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(278, 386);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "CLOAK!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// container
			// 
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(0, 0);
			this.container.Name = "container";
			// 
			// container.Panel1
			// 
			this.container.Panel1.Controls.Add(this.button2);
			this.container.Panel1.Controls.Add(this.regedit);
			this.container.Panel1.Controls.Add(this.create);
			this.container.Panel1.Controls.Add(this.bsod);
			this.container.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// container.Panel2
			// 
			this.container.Panel2.Controls.Add(this.menu2);
			this.container.Size = new System.Drawing.Size(472, 446);
			this.container.SplitterDistance = 99;
			this.container.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(4, 81);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Character map";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// createfile
			// 
			this.createfile.AddExtension = false;
			this.createfile.CheckPathExists = false;
			this.createfile.CreatePrompt = true;
			this.createfile.DefaultExt = "*.*";
			this.createfile.RestoreDirectory = true;
			this.createfile.Title = "Create custom file";
			this.createfile.FileOk += new System.ComponentModel.CancelEventHandler(this.CreatefileFileOk);
			// 
			// startindir
			// 
			this.startindir.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.startindir.SelectedPath = "C:\\";
			// 
			// editor
			// 
			this.ClientSize = new System.Drawing.Size(472, 446);
			this.Controls.Add(this.container);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "editor";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PCeditor";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.Load += new System.EventHandler(this.EditorLoad);
			this.menu2.ResumeLayout(false);
			this.startupmanager.ResumeLayout(false);
			this.startupmanager.PerformLayout();
			this.sm_bar.ResumeLayout(false);
			this.sm_bar.PerformLayout();
			this.processcloak.ResumeLayout(false);
			this.processcloak.PerformLayout();
			this.container.Panel1.ResumeLayout(false);
			this.container.Panel2.ResumeLayout(false);
			this.container.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.FolderBrowserDialog startindir;
		private System.Windows.Forms.Button browseprocess;
		private System.Windows.Forms.TextBox proc;
		private System.Windows.Forms.TextBox dir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage processcloak;
		private System.Windows.Forms.SaveFileDialog createfile;
		private System.Windows.Forms.TabPage contextitems;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripComboBox startuptype;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton sm_mod;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton sm_rem;
		private System.Windows.Forms.ToolStripButton sm_add;
		private System.Windows.Forms.ToolStrip sm_bar;
		private System.Windows.Forms.SplitContainer container;
		private System.Windows.Forms.ListBox lbKeys;
		private System.Windows.Forms.TabPage startupmanager;
		private System.Windows.Forms.TabControl menu2;
		private System.Windows.Forms.Button bsod;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button regedit;
		
	}
}