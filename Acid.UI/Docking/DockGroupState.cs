using System.Collections.Generic;

namespace Acid.UI.Docking
{
	public class DockGroupState
	{
		#region Property Region

		public List<string> Contents { get; set; }

		#endregion

		#region Constructor Region

		public DockGroupState()
		{
			Contents = new List<string>();
		}

		#endregion
	}
}
