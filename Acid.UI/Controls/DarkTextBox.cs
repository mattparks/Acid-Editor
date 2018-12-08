using System.Windows.Forms;
using Acid.UI.Config;

namespace Acid.UI.Controls
{
	public class DarkTextBox : TextBox
	{
		#region Constructor Region

		public DarkTextBox()
		{
			BackColor = Colours.LightBackground;
			ForeColor = Colours.LightText;
			Padding = new Padding(2, 2, 2, 2);
			BorderStyle = BorderStyle.FixedSingle;
		}

		#endregion
	}
}
