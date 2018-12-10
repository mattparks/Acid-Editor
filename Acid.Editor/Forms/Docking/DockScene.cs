using Acid.Forms.Controls;
using Acid.Forms.Docking;
using Acid.Sharp;
using System;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockScene : DarkToolWindow
    {
        #region Constructor Region

        public DockScene()
        {
            InitializeComponent();
	        txtDocument.Resize += delegate
	        {
		        RefreshDisplay();
	        };
	        txtDocument.LocationChanged += delegate
	        {
		        RefreshDisplay();
	        };
        }

		#endregion

	    public bool DisplayOpen = false;

	    private void DockScene_Load(object sender, EventArgs e)
	    {
		    DisplayOpen = true;
			RefreshDisplay();
	    }

		public void RefreshDisplay()
		{
			if (!DisplayOpen)
			{
				return;
			}

			var screenLocation = txtDocument.Parent.PointToScreen(txtDocument.Location);
			Display.Get().Iconified = false;
			Display.Get().Floating = true;
			Display.Get().Position = new Vector2(screenLocation.X, screenLocation.Y);
			Display.Get().Dimensions = new Vector2(txtDocument.Size.Width, txtDocument.Size.Height);
		}
	}
}
