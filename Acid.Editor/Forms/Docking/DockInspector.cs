using System;
using Acid.Forms.Controls;
using Acid.Forms.Docking;

namespace Acid.Editor.Forms.Docking
{
    public partial class DockInspector : DarkToolWindow
    {
        #region Constructor Region

        public DockInspector()
        {
            InitializeComponent();
			
			darkDropdownList1.Items.Add(new DarkDropdownItem("Collider"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("KinematicCharacter"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("Rigidbody"));
			darkDropdownList1.Items.Add(new DarkDropdownItem("Light"));
			darkDropdownList1.Items.Add(new DarkDropdownItem("Mesh"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MeshRenderer"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MaterialDefault"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("MaterialSkybox"));
			darkDropdownList1.Items.Add(new DarkDropdownItem("ParticleSystem"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ShadowRenderer"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("Sound"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCapsule"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCone"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderConvexHull"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCube"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderCylinder"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderHeightfield"));
	        darkDropdownList1.Items.Add(new DarkDropdownItem("ColliderSphere"));
	        darkButton1.KeyPress += delegate
	        {
		    //    darkDropdownList1.SelectedItem.Text;
	        };
		}

		#endregion
	}
}
