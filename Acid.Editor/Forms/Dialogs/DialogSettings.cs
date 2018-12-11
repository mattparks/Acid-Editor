using Acid.Forms.Controls;
using Acid.Forms.Forms;
using System;
using Acid.Forms.Config;
using System.Windows.Forms;

namespace Acid.Editor.Forms.Dialogs
{
    public partial class DialogSettings : DarkDialog
    {
        public DialogSettings()
        {
            InitializeComponent();

	        if (Colours.ColourConfig is ColoursLight)
	        {
		        darkRadioButton1.Checked = true;

	        }
			else if (Colours.ColourConfig is ColoursDark)
	        {
		        darkRadioButton2.Checked = true;
	        }

			darkRadioButton1.CheckedChanged += delegate
            {
                if (darkRadioButton1.Checked)
                {
                    Colours.ColourConfig = new ColoursLight();
                }
            };

            darkRadioButton2.CheckedChanged += delegate
            {
                if (darkRadioButton2.Checked)
                {
                    Colours.ColourConfig = new ColoursDark();
                }
            };
        }
    }
}
