using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace WindowsFormsApp1
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
		 
			if (Environment.OSVersion.Version.Major >= 6) 
			{
				SetProcessDPIAware();
			}
		   
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmForm1());
		}

		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
