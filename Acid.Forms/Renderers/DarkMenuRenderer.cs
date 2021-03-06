﻿using Acid.Forms.Config;
using System;
using System.Drawing;
using System.Windows.Forms;
using Acid.Forms.Icons;

namespace Acid.Forms.Renderers
{
    public class DarkMenuRenderer : ToolStripRenderer
    {
        #region Initialisation Region

        protected override void Initialize(ToolStrip toolStrip)
        {
            base.Initialize(toolStrip);

            toolStrip.BackColor = Colours.GreyBackground;
            toolStrip.ForeColor = Colours.LightText;
        }

        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);

            item.BackColor = Colours.GreyBackground;
            item.ForeColor = Colours.LightText;

            if (item.GetType() == typeof(ToolStripSeparator))
            {
                item.Margin = new Padding(0, 0, 0, 1);
            }
        }

        #endregion

        #region Render Region

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            var g = e.Graphics;
            using (var b = new SolidBrush(Colours.GreyBackground))
            {
                g.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);

            using (var p = new Pen(Colours.LightBorder))
            {
                g.DrawRectangle(p, rect);
            }
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(e.ImageRectangle.Left - 2, e.ImageRectangle.Top - 2,
                                         e.ImageRectangle.Width + 4, e.ImageRectangle.Height + 4);

            using (var b = new SolidBrush(Colours.MenuItemToggledOnFill))
            {
                g.FillRectangle(b, rect);
            }

            using (var p = new Pen(Colours.MenuItemToggledOnBorder))
            {
                var modRect = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
                g.DrawRectangle(p, modRect);
            }

            if (e.Item.ImageIndex == -1 && String.IsNullOrEmpty(e.Item.ImageKey) && e.Item.Image == null)
            {
                g.DrawImage(MenuIcons.tick, new Point(e.ImageRectangle.Left, e.ImageRectangle.Top));
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(1, 3, e.Item.Width, 1);

            using (var b = new SolidBrush(Colours.LightBorder))
            {
                g.FillRectangle(b, rect);
            }
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Colours.LightText;
            e.ArrowRectangle = new Rectangle(new Point(e.ArrowRectangle.Left, e.ArrowRectangle.Top - 1), e.ArrowRectangle.Size);

            base.OnRenderArrow(e);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var g = e.Graphics;

            e.Item.ForeColor = e.Item.Enabled ? Colours.LightText : Colours.DisabledText;

            if (!e.Item.Enabled)
                return;

            var bgColor = e.Item.Selected ? Colours.GreyHighlight : e.Item.BackColor;

            // Normal item
            var rect = new Rectangle(2, 0, e.Item.Width - 3, e.Item.Height);

            using (var b = new SolidBrush(bgColor))
            {
                g.FillRectangle(b, rect);
            }

            // Header item on open menu
            var menuItem = e.Item as ToolStripMenuItem;
            if (menuItem == null)
                return;

            if (!menuItem.DropDown.Visible || menuItem.IsOnDropDown)
                return;
            
            using (var b = new SolidBrush(Colours.GreySelection))
            {
                g.FillRectangle(b, rect);
            }
        }

        #endregion
    }
}
