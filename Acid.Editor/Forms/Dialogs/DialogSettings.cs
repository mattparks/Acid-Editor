using Acid.UI.Controls;
using Acid.UI.Forms;
using System;
using Acid.UI.Config;
using System.Windows.Forms;

namespace Acid.Editor.Forms.Dialogs
{
    public partial class DialogSettings : DarkDialog
    {
        public DialogSettings()
        {
            InitializeComponent();
            
            darkRadioButton1.CheckedChanged += delegate
            {
                if (darkRadioButton1.Checked)
                {
                //    Colours.ColourConfig = new ColoursLight();
                    Console.WriteLine("Theme changed to Light");
                }
            };

            darkRadioButton2.CheckedChanged += delegate
            {
                if (darkRadioButton2.Checked)
                {
                    Colours.ColourConfig = new ColoursDark();
                    Console.WriteLine("Theme changed to Dark");
                }
            };

            darkRadioButton3.CheckedChanged += delegate
            {
                if (darkRadioButton2.Checked)
                {
                //    Colours.ColourConfig = new ColoursBlue();
                    Console.WriteLine("Theme changed to Blue");
                }
            };
        }
    }
}
