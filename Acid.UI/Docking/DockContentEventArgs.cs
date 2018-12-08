using System;

namespace Acid.UI.Docking
{
	public class DockContentEventArgs : EventArgs
	{
		public DarkDockContent Content { get; private set; }

		public DockContentEventArgs(DarkDockContent content)
		{
			Content = content;
		}
	}
}
