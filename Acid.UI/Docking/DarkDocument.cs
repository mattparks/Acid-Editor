using System.ComponentModel;
using Acid.UI.Config;

namespace Acid.UI.Docking
{
	[ToolboxItem(false)]
	public class DarkDocument : DarkDockContent
	{
		#region Property Region

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DarkDockArea DefaultDockArea
		{
			get { return base.DefaultDockArea; }
		}

		#endregion

		#region Constructor Region

		public DarkDocument()
		{
			BackColor = Colours.GreyBackground;
			base.DefaultDockArea = DarkDockArea.Document;
		}

		#endregion
	}
}
