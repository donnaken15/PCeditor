/*
 * Created by SharpDevelop.
 * User: Wesley
 * Date: 9/21/2016
 * Time: 9:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PCeditor
{
	partial class editor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
			this.regedit = new System.Windows.Forms.Button();
			this.create = new System.Windows.Forms.Button();
			this.bsod = new System.Windows.Forms.Button();
			this.menu2 = new System.Windows.Forms.TabControl();
			this.startupmanager = new System.Windows.Forms.TabPage();
			this.lbKeys = new System.Windows.Forms.ListBox();
			this.browser = new System.Windows.Forms.TabPage();
			this.secondcontainer = new System.Windows.Forms.SplitContainer();
			this.magicbrowser = new System.Windows.Forms.WebBrowser();
			this.viewsource = new System.Windows.Forms.TextBox();
			this.container = new System.Windows.Forms.SplitContainer();
			this.urltextbox = new System.Windows.Forms.TextBox();
			this.menu2.SuspendLayout();
			this.startupmanager.SuspendLayout();
			this.browser.SuspendLayout();
			this.secondcontainer.Panel1.SuspendLayout();
			this.secondcontainer.Panel2.SuspendLayout();
			this.secondcontainer.SuspendLayout();
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
			this.regedit.Size = new System.Drawing.Size(89, 17);
			this.regedit.TabIndex = 0;
			this.regedit.Text = "Registry Editor";
			this.regedit.UseVisualStyleBackColor = true;
			this.regedit.Click += new System.EventHandler(this.RegeditClick);
			// 
			// create
			// 
			this.create.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.create.Location = new System.Drawing.Point(3, 54);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(89, 14);
			this.create.TabIndex = 1;
			this.create.Text = "Create file";
			this.create.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.create.UseVisualStyleBackColor = true;
			// 
			// bsod
			// 
			this.bsod.Location = new System.Drawing.Point(3, 26);
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
			this.menu2.Controls.Add(this.browser);
			this.menu2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menu2.Location = new System.Drawing.Point(0, 0);
			this.menu2.Name = "menu2";
			this.menu2.SelectedIndex = 0;
			this.menu2.Size = new System.Drawing.Size(372, 446);
			this.menu2.TabIndex = 0;
			// 
			// startupmanager
			// 
			this.startupmanager.Controls.Add(this.lbKeys);
			this.startupmanager.Location = new System.Drawing.Point(4, 25);
			this.startupmanager.Name = "startupmanager";
			this.startupmanager.Padding = new System.Windows.Forms.Padding(3);
			this.startupmanager.Size = new System.Drawing.Size(364, 417);
			this.startupmanager.TabIndex = 1;
			this.startupmanager.Text = "Startup Manager";
			this.startupmanager.UseVisualStyleBackColor = true;
			// 
			// lbKeys
			// 
			this.lbKeys.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbKeys.FormattingEnabled = true;
			this.lbKeys.Location = new System.Drawing.Point(3, 3);
			this.lbKeys.Name = "lbKeys";
			this.lbKeys.Size = new System.Drawing.Size(358, 411);
			this.lbKeys.TabIndex = 0;
			// 
			// browser
			// 
			this.browser.AllowDrop = true;
			this.browser.Controls.Add(this.secondcontainer);
			this.browser.Location = new System.Drawing.Point(4, 25);
			this.browser.Name = "browser";
			this.browser.Padding = new System.Windows.Forms.Padding(3);
			this.browser.Size = new System.Drawing.Size(364, 417);
			this.browser.TabIndex = 0;
			this.browser.Text = "Magic Browser";
			this.browser.UseVisualStyleBackColor = true;
			this.browser.Click += new System.EventHandler(this.BrowserClick);
			// 
			// secondcontainer
			// 
			this.secondcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.secondcontainer.Location = new System.Drawing.Point(3, 3);
			this.secondcontainer.Name = "secondcontainer";
			this.secondcontainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// secondcontainer.Panel1
			// 
			this.secondcontainer.Panel1.Controls.Add(this.urltextbox);
			this.secondcontainer.Panel1.Controls.Add(this.magicbrowser);
			// 
			// secondcontainer.Panel2
			// 
			this.secondcontainer.Panel2.Controls.Add(this.viewsource);
			this.secondcontainer.Size = new System.Drawing.Size(358, 411);
			this.secondcontainer.SplitterDistance = 277;
			this.secondcontainer.TabIndex = 0;
			// 
			// magicbrowser
			// 
			this.magicbrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.magicbrowser.Location = new System.Drawing.Point(0, 16);
			this.magicbrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.magicbrowser.Name = "magicbrowser";
			this.magicbrowser.ScriptErrorsSuppressed = true;
			this.magicbrowser.Size = new System.Drawing.Size(358, 261);
			this.magicbrowser.TabIndex = 0;
			this.magicbrowser.Url = new System.Uri("about:blank", System.UriKind.Absolute);
			this.magicbrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MagicbrowserDocumentCompleted);
			// 
			// viewsource
			// 
			this.viewsource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewsource.Location = new System.Drawing.Point(0, 0);
			this.viewsource.MaxLength = 1073741824;
			this.viewsource.Multiline = true;
			this.viewsource.Name = "viewsource";
			this.viewsource.Size = new System.Drawing.Size(358, 130);
			this.viewsource.TabIndex = 1;
			this.viewsource.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// container
			// 
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(0, 0);
			this.container.Name = "container";
			// 
			// container.Panel1
			// 
			this.container.Panel1.Controls.Add(this.regedit);
			this.container.Panel1.Controls.Add(this.create);
			this.container.Panel1.Controls.Add(this.bsod);
			// 
			// container.Panel2
			// 
			this.container.Panel2.Controls.Add(this.menu2);
			this.container.Size = new System.Drawing.Size(472, 446);
			this.container.SplitterDistance = 96;
			this.container.TabIndex = 4;
			// 
			// urltextbox
			// 
			this.urltextbox.Dock = System.Windows.Forms.DockStyle.Top;
			this.urltextbox.Location = new System.Drawing.Point(0, 0);
			this.urltextbox.Name = "urltextbox";
			this.urltextbox.Size = new System.Drawing.Size(358, 20);
			this.urltextbox.TabIndex = 1;
			this.urltextbox.TextChanged += new System.EventHandler(this.UrltextboxTextChanged);
			// 
			// editor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(472, 446);
			this.Controls.Add(this.container);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "editor";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "PCeditor";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.Load += new System.EventHandler(this.EditorLoad);
			this.menu2.ResumeLayout(false);
			this.startupmanager.ResumeLayout(false);
			this.browser.ResumeLayout(false);
			this.secondcontainer.Panel1.ResumeLayout(false);
			this.secondcontainer.Panel1.PerformLayout();
			this.secondcontainer.Panel2.ResumeLayout(false);
			this.secondcontainer.Panel2.PerformLayout();
			this.secondcontainer.ResumeLayout(false);
			this.container.Panel1.ResumeLayout(false);
			this.container.Panel2.ResumeLayout(false);
			this.container.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox urltextbox;
		private System.Windows.Forms.SplitContainer secondcontainer;
		private System.Windows.Forms.TextBox viewsource;
		private System.Windows.Forms.SplitContainer container;
		private System.Windows.Forms.ListBox lbKeys;
		private System.Windows.Forms.TabPage startupmanager;
		private System.Windows.Forms.WebBrowser magicbrowser;
		private System.Windows.Forms.TabPage browser;
		private System.Windows.Forms.TabControl menu2;
		private System.Windows.Forms.Button bsod;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button regedit;
	}
}
