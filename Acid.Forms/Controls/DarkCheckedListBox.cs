using Acid.Forms.Config;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Acid.Forms.Controls
{
    public class DarkCheckedListBox : CheckedListBox
    {
        public DarkCheckedListBox()
        {
            BackColor = Colours.LightBackground;
            ForeColor = Colours.LightText;
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 18;
        }

        public DarkCheckedListBox(IContainer container)
        {
            container.Add(this);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            if (index > Items.Count - 1) return;

            Rectangle bounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

            // Background
            var odd = e.Index % 2 != 0;
            var bgColor = !odd ? Colours.HeaderBackground : Colours.GreyBackground;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                bgColor = Focused ? Colours.BlueSelection : Colours.GreySelection;

            using (var b = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(b, bounds);

            e.Graphics.DrawString(Items[index].ToString(), e.Font, Brushes.White, bounds, StringFormat.GenericDefault);
        }
    }
}
