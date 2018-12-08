using Acid.UI.Controls;
using Acid.UI.Forms;
using System;
using Acid.UI.Config;

namespace Acid.Editor
{
    public partial class DialogSettings : DarkDialog
    {
        public DialogSettings()
        {
            InitializeComponent();
            
            // Hook dialog button events
            btnDialog.Click += delegate
            {
                DarkMessageBox.ShowError("This is an error", "Error");
            };

            btnMessageBox.Click += delegate
            {
                DarkMessageBox.ShowInformation("This is some information, except it is much bigger, so there we go. I wonder how this is going to go. I hope it resizes properly. It probably will.", "Message");
            };

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
