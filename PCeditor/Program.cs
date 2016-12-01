#pragma warning disable 0169, 0414
using System;
using System.Windows.Forms;
namespace PCeditor
{
internal sealed class Program
{
[STAThread]
private static void Main(string[] args)
{
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new editor());}}}