using System.Windows.Forms;
using Acid.UI.Renderers;

namespace Acid.UI.Controls
{
	public class DarkMenuStrip : MenuStrip
	{
		#region Constructor Region

		public DarkMenuStrip()
		{
			Renderer = new DarkMenuRenderer();
			Padding = new Padding(3, 2, 0, 2);
		}

		#endregion
	}
}
