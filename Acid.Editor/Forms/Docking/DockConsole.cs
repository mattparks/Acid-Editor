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
                    item.TextColor = Color.Red;
                else if (i < 6)
                    item.TextColor = Color.Orange;

                lstConsole.Items.Add(item);
            }
        }

        #endregion
    }
}
