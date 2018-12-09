using System.Drawing;
using Acid.UI.Controls;
using Acid.UI.Docking;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockConsole : DarkToolWindow
    {
        #region Constructor Region

        public DockConsole()
        {
            InitializeComponent();

            // Build dummy list data
            for (var i = 0; i < 100; i++)
            {
                var item = new DarkListItem($"List item #{i}");
	            if (i < 2)
		            item.Icon = Icons.error_16x;
	            else if (i < 7)
		            item.Icon = Icons.warning_16x;
				else
		            item.Icon = Icons.info_16x;
				lstConsole.Items.Add(item);
            }
        }

        #endregion
    }
}
