using System;
using Acid.UI.Controls;
using Acid.UI.Docking;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockInspector : DarkToolWindow
    {
        #region Constructor Region

        public DockInspector()
        {
            InitializeComponent();

	        darkDropdownList1.Items.Add(new DarkDropdownItem("Collider", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("KinematicCharacter", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("Rigidbody", Icons.NewFile_6276));
			darkDropdownList1.Items.Add(new DarkDropdownItem("Light", Icons.NewFile_6276));
			darkDropdownList1.Items.Add(new DarkDropdownItem("Mesh", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MeshRenderer", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MaterialDefault", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MaterialSkybox", Icons.NewFile_6276));
			darkDropdownList1.Items.Add(new DarkDropdownItem("ParticleSystem", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ShadowRenderer", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("Sound", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCapsule", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCone", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderConvexHull", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCube", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCylinder", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderHeightfield", Icons.NewFile_6276));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderSphere", Icons.NewFile_6276));
	        darkDropdownList1.SelectedItemChanged += delegate
	        {
		    //    darkDropdownList1.SelectedItem.Text;
	        };
		}

		#endregion
	}
}
