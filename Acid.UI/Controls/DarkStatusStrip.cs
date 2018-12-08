using System.Drawing;
using System.Windows.Forms;
using Acid.UI.Config;

namespace Acid.UI.Controls
{
	public class DarkStatusStrip : StatusStrip
	{
		#region Constructor Region

		public DarkStatusStrip()
		{
			AutoSize = false;
			BackColor = Colours.GreyBackground;
			ForeColor = Colours.LightText;
			Padding = new Padding(0, 5, 0, 3);
			Size = new Size(Size.Width, 24);
			SizingGrip = false;
		}

		#endregion

		#region Paint Region

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			var g = e.Graphics;

			using (var b = new SolidBrush(Colours.GreyBackground))
			{
				g.FillRectangle(b, ClientRectangle);
			}

			using (var p = new Pen(Colours.DarkBorder))
			{
				g.DrawLine(p, ClientRectangle.Left, 0, ClientRectangle.Right, 0);
			}

			using (var p = new Pen(Colours.LightBorder))
			{
				g.DrawLine(p, ClientRectangle.Left, 1, ClientRectangle.Right, 1);
			}
		}

		#endregion
	}
}
