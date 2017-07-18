using DesignPatterns.Proxy.Exemplo;
using System;
using System.Windows.Forms;

namespace CSharp.DesignPatterns.Proxy
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmImage());
		}
	}
}
