using System;
using System.Windows.Forms;
using Acid.Editor.Forms;
using Acid.Sharp;

namespace Acid.Editor
{
    static class Program
    {
        [STAThread]
        static void Main()
		{
			var engine = new Engine(false);
			Display.Get().Iconified = true;
			Display.Get().Borderless = true;
			Display.Get().Floating = true;

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
			var exitCode = engine.Run();
		}
    }
}
