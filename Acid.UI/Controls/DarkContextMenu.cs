using System.Windows.Forms;
using Acid.UI.Renderers;

namespace Acid.UI.Controls
{
	public class DarkContextMenu : ContextMenuStrip
	{
		#region Constructor Region

		public DarkContextMenu()
		{
			Renderer = new DarkMenuRenderer();
		}

		#endregion
	}
}
