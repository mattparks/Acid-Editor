using Acid.UI.Controls;
using Acid.UI.Docking;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockHierarchy : DarkToolWindow
    {
        #region Constructor Region

        public DockHierarchy()
        {
            InitializeComponent();

	        for (var i = 0; i < 12; i++)
			{
				var entityNode = new DarkTreeNode($"Entity #{i}")
				{
					Icon = Icons.document_16xLG
				};

				treeHierarchy.Nodes.Add(entityNode);
			}
        }

        #endregion
    }
}
