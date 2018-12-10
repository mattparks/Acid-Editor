using Acid.Forms.Forms;
using System.Windows.Forms;

namespace Acid.Editor.Forms.Dialogs
{
    public partial class DialogAbout : DarkDialog
    {
        #region Constructor Region

        public DialogAbout()
        {
            InitializeComponent();

            lblVersion.Text = $"Version: {Application.ProductVersion}";
            btnOk.Text = "Close";
        }

        #endregion
    }
}
