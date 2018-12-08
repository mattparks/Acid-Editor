using DarkUI.Controls;
using DarkUI.Docking;

namespace AcidEditor
{
    public partial class DockHierarchy : DarkToolWindow
    {
        #region Constructor Region

        public DockHierarchy()
        {
            InitializeComponent();

            // Build dummy nodes
            var childCount = 0;
            for (var i = 0; i < 20; i++)
            {
                var node = new DarkTreeNode($"Root node #{i}");
                node.ExpandedIcon = Icons.folder_open;
                node.Icon = Icons.folder_closed;

                for (var x = 0; x < 10; x++)
                {
                    var childNode = new DarkTreeNode($"Child node #{childCount}");
                    childNode.Icon = Icons.files;
                    childCount++;
                    node.Nodes.Add(childNode);
                }

                treeProject.Nodes.Add(node);
            }
        }

        #endregion
    }
}
