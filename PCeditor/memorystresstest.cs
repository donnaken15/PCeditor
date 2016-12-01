using System;
using System.Drawing;
using System.Windows.Forms;

namespace PCeditor
{
	public partial class memorystresstest : Form
	{
		public memorystresstest()
		{
			InitializeComponent();
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			string memory="a";
			memory.Length.Equals(trackBar1.Value);
		}
	}
}
