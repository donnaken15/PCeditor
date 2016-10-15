using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.Win32;
namespace PCeditor
{
	public partial class editor : Form
	{
		public editor()
		{
			InitializeComponent();
			
		}
		
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
			RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\");
            
            if (myKey.SubKeyCount > 0)
            {
                foreach (string subKey in myKey.GetSubKeyNames())
                {
					lbKeys.Items.Add(subKey);
				}
			}
        }
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			using (WebClient client = new WebClient()){
    string htmlCode = client.DownloadString(magicbrowser.Url);
    viewsource.Text=htmlCode;}
		}
		
		void MagicbrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			using (WebClient client = new WebClient()){
    string htmlCode = client.DownloadString(magicbrowser.Url);
    viewsource.Text=htmlCode;
			if (viewsource.Text.Length>32767)
			{MessageBox.Show("HTML file is too big to view source code.","Overload!!");
			viewsource.Text="";}}
		}
		
		void BrowserClick(object sender, EventArgs e)
		{
			
		}
		
		void UrltextboxTextChanged(object sender, EventArgs e)
		{
			magicbrowser.Navigate(urltextbox.Text);
		}
	}
}