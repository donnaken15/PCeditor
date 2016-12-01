using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.Win32;
using Microsoft.VisualBasic;
namespace PCeditor
{
	public partial class editor : Form
	{
		public editor()
		{
			string line;
			InitializeComponent();
			string sm_output = System.IO.File.ReadAllText("C:/PCeditor/data/startupmanager.list");
			System.IO.StreamReader file = new System.IO.StreamReader("C:/PCeditor/data/startupmanager.list");
			while ((line = file.ReadLine()) != null)
			{lbKeys.Items.Add(line);}
			file.Close();
			container.IsSplitterFixed=true;
		}
		
		public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 192;
            prompt.Height = 128;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 24, Top=10, Text=text, Width=256};
            TextBox inputBox = new TextBox () { Left = 8, Top=36, Width=160 };
            Button confirmation = new Button() { Text = "Add", Left=8, Width=36, Top=64 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowIcon=false;
            prompt.FormBorderStyle=FormBorderStyle.Fixed3D;
            prompt.MaximizeBox=false;
            prompt.StartPosition=FormStartPosition.CenterParent;
            prompt.ShowDialog();
            return (string)inputBox.Text;
        }
    }
		
		public static class MyGlobals {
    	public const string addtolistbox = "";
		}
		
		public const int ready=0;
		
		void BsodClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("By clicking yes, you will get a real Blue Screen of Death. Continue?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
			{
				System.IO.File.WriteAllText(@"C:\tempfile_donotrun.bat",@"@echo off
CLS
:init
setlocal DisableDelayedExpansion
set 'batchPath=%~0'
for %%k in (%0) do set batchName=%%~nk
set 'vbsGetPrivileges=%temp%\OEgetPriv_%batchName%.vbs'
setlocal EnableDelayedExpansion
:checkPrivileges
NET FILE 1>NUL 2>NUL
if '%errorlevel%' == '0' ( goto gotPrivileges ) else ( goto getPrivileges )
:getPrivileges
if '%1'=='ELEV' (echo ELEV & shift /1 & goto gotPrivileges)
ECHO Set UAC = CreateObject^('Shell.Application'^) > '%vbsGetPrivileges%'
ECHO args = 'ELEV ' >> '%vbsGetPrivileges%'
ECHO For Each strArg in WScript.Arguments >> '%vbsGetPrivileges%'
ECHO args = args ^& strArg ^& ' '  >> '%vbsGetPrivileges%'
ECHO Next >> '%vbsGetPrivileges%'
ECHO UAC.ShellExecute '!batchPath!', args, '', 'runas', 1 >> '%vbsGetPrivileges%'
'%SystemRoot%\System32\WScript.exe' '%vbsGetPrivileges%' %*
exit /B
:gotPrivileges
setlocal & pushd .
cd /d %~dp0
if '%1'=='ELEV' (del '%vbsGetPrivileges%' 1>nul 2>nul  &  shift /1)
taskkill /f /im svchost.exe");
				System.Diagnostics.Process.Start("C:\tempfile_donotrun.bat");
			}
		else
			{
    			
			}
		}
		
		void RegeditClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("C:/Windows/regedit.exe");
		}
		
		void EditorLoad(object sender, EventArgs e)
		{
			
			try
{
    using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE/Microsoft/Windows/CurrentVersion"))
    {
        if (key != null)
        {
            Object o = key.GetValue("Run");
            if (o != null)
            {
                Version version = new Version(o as String);
                lbKeys.BeginUpdate();
   for (int x = 1; x <= 50; x++)
   {
   	lbKeys.Items.Add(lbKeys);
   }
   lbKeys.EndUpdate();
            }
        }
    }
}
			catch (Exception ex){}}
		void TextBox1TextChanged(object sender, EventArgs e){}
		void MagicbrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e){}
		void BrowserClick(object sender, EventArgs e){}
		void UrltextboxTextChanged(object sender, EventArgs e){}
		
		void Sm_addClick(object sender, EventArgs e)
		{
			string add = Prompt.ShowDialog("Enter executable (filename):","PCeditor");
			if (add!=""){lbKeys.Items.Add(add);
            string sm_output = System.IO.File.ReadAllText("C:/PCeditor/data/startupmanager.list");
            System.IO.File.WriteAllText("C:/PCeditor/data/startupmanager.list",sm_output+@"
"+add);}
		}
		
		void LbKeysSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Sm_remClick(object sender, EventArgs e)
		{
			if (lbKeys.SelectedIndex!=null){
			lbKeys.Items.Remove(lbKeys.SelectedItem);
			}
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			if (lbKeys.SelectedItem!=null)
			{System.Diagnostics.Process.Start(lbKeys.SelectedItem.ToString(),"");}
		}
		
		void CreatefileFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (createfile.FileName!=null)
			{File.WriteAllText(createfile.FileName,"");}
		}
		
		void CreateClick(object sender, EventArgs e)
		{
			createfile.ShowDialog();
		}
		
		void StartuptypeClick(object sender, EventArgs e)
		{
			
		}
		
		void BrowseprocessClick(object sender, EventArgs e)
		{
			startindir.ShowDialog();
			dir.Text=startindir.SelectedPath;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("C:/Windows/System32/charmap.exe","");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			memorystresstest mem = new memorystresstest();
			mem.Show();
		}
	}
}