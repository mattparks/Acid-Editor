using System;
using System.Drawing;

namespace Acid.Forms.Config
{
	public interface IColours
	{
		Color GetGreyBackground();
		Color GetHeaderBackground();
		Color GetBlueBackground();
		Color GetDarkBlueBackground();
		Color GetDarkBackground();
		Color GetMediumBackground();
		Color GetLightBackground();
		Color GetLighterBackground();
		Color GetLightestBackground();
		Color GetLightBorder();
		Color GetDarkBorder();
		Color GetLightText();
		Color GetDisabledText();
		Color GetBlueHighlight();
		Color GetBlueSelection();
		Color GetGreyHighlight();
		Color GetGreySelection();
		Color GetDarkGreySelection();
		Color GetDarkBlueBorder();
		Color GetLightBlueBorder();
		Color GetActiveControl();
		Color GetMenuItemToggledOnFill();
		Color GetMenuItemToggledOnBorder();
	}

	public class ColoursDark : IColours
	{
		public Color GetGreyBackground() => Color.FromArgb(60, 63, 65);
		public Color GetHeaderBackground() => Color.FromArgb(57, 60, 62);
		public Color GetBlueBackground() => Color.FromArgb(66, 77, 95);
		public Color GetDarkBlueBackground() => Color.FromArgb(52, 57, 66);
		public Color GetDarkBackground() => Color.FromArgb(43, 43, 43);
		public Color GetMediumBackground() => Color.FromArgb(49, 51, 53);
		public Color GetLightBackground() => Color.FromArgb(69, 73, 74);
		public Color GetLighterBackground() => Color.FromArgb(95, 101, 102);
		public Color GetLightestBackground() => Color.FromArgb(178, 178, 178);
		public Color GetLightBorder() => Color.FromArgb(81, 81, 81);
		public Color GetDarkBorder() => Color.FromArgb(51, 51, 51);
		public Color GetLightText() => Color.FromArgb(220, 220, 220);
		public Color GetDisabledText() => Color.FromArgb(153, 153, 153);
		public Color GetBlueHighlight() => Color.FromArgb(104, 151, 187);
		public Color GetBlueSelection() => Color.FromArgb(75, 110, 175);
		public Color GetGreyHighlight() => Color.FromArgb(122, 128, 132);
		public Color GetGreySelection() => Color.FromArgb(92, 92, 92);
		public Color GetDarkGreySelection() => Color.FromArgb(82, 82, 82);
		public Color GetDarkBlueBorder() => Color.FromArgb(51, 61, 78);
		public Color GetLightBlueBorder() => Color.FromArgb(86, 97, 114);
		public Color GetActiveControl() => Color.FromArgb(159, 178, 196);
		public Color GetMenuItemToggledOnFill() => Color.FromArgb(105, 84, 69);
		public Color GetMenuItemToggledOnBorder() => Color.FromArgb(225, 128, 68);
	}

	public class ColoursLight : IColours
	{
		public Color GetGreyBackground() => Color.FromArgb(255, 255, 255);
		public Color GetHeaderBackground() => Color.FromArgb(230, 229, 231);
		public Color GetBlueBackground() => Color.FromArgb(51, 119, 185); 
		public Color GetDarkBlueBackground() => Color.FromArgb(51, 119, 185);
		public Color GetDarkBackground() => Color.FromArgb(212, 212, 212);
		public Color GetMediumBackground() => Color.FromArgb(236, 232, 233);
		public Color GetLightBackground() => Color.FromArgb(236, 232, 233);
		public Color GetLighterBackground() => Color.FromArgb(160, 154, 152);
		public Color GetLightestBackground() => Color.FromArgb(77, 77, 77);
		public Color GetLightBorder() => Color.FromArgb(174, 174, 174);
		public Color GetDarkBorder() => Color.FromArgb(204, 204, 204);
		public Color GetLightText() => Color.FromArgb(35, 35, 35);
		public Color GetDisabledText() => Color.FromArgb(102, 102, 102);
		public Color GetBlueHighlight() => Color.FromArgb(104, 151, 187);
		public Color GetBlueSelection() => Color.FromArgb(51, 119, 185);
		public Color GetGreyHighlight() => Color.FromArgb(203, 203, 203);//
		public Color GetGreySelection() => Color.FromArgb(223, 223, 223);
		public Color GetDarkGreySelection() => Color.FromArgb(173, 173, 173);
		public Color GetDarkBlueBorder() => Color.FromArgb(204, 194, 177);
		public Color GetLightBlueBorder() => Color.FromArgb(169, 158, 141);
		public Color GetActiveControl() => Color.FromArgb(96, 77, 59);
		public Color GetMenuItemToggledOnFill() => Color.FromArgb(150, 171, 186);
		public Color GetMenuItemToggledOnBorder() => Color.FromArgb(0, 127, 187);
	}

	public static class Colours
	{
		public static event EventHandler ColourChanged = delegate { };
		private static IColours _colourConfig = new ColoursDark();
		public static IColours ColourConfig
		{
			get { return _colourConfig; }
			set
			{
				_colourConfig = value;
				ColourChanged(_colourConfig, EventArgs.Empty);
			}
		}

		public static Color GreyBackground
		{
			get { return ColourConfig.GetGreyBackground(); }
		}
		public static Color HeaderBackground
		{
			get { return ColourConfig.GetHeaderBackground(); }
		}
		public static Color BlueBackground
		{
			get { return ColourConfig.GetBlueBackground(); }
		}
		public static Color DarkBlueBackground
		{
			get { return ColourConfig.GetDarkBlueBackground(); }
		}
		public static Color DarkBackground
		{
			get { return ColourConfig.GetDarkBackground(); }
		}
		public static Color MediumBackground
		{
			get { return ColourConfig.GetMediumBackground(); }
		}
		public static Color LightBackground
		{
			get { return ColourConfig.GetLightBackground(); }
		}
		public static Color LighterBackground
		{
			get { return ColourConfig.GetLighterBackground(); }
		}
		public static Color LightestBackground
		{
			get { return ColourConfig.GetLightestBackground(); }
		}
		public static Color LightBorder
		{
			get { return ColourConfig.GetLightBorder(); }
		}
		public static Color DarkBorder
		{
			get { return ColourConfig.GetDarkBorder(); }
		}
		public static Color LightText
		{
			get { return ColourConfig.GetLightText(); }
		}
		public static Color DisabledText
		{
			get { return ColourConfig.GetDisabledText(); }
		}
		public static Color BlueHighlight
		{
			get { return ColourConfig.GetBlueHighlight(); }
		}
		public static Color BlueSelection
		{
			get { return ColourConfig.GetBlueSelection(); }
		}
		public static Color GreyHighlight
		{
			get { return ColourConfig.GetGreyHighlight(); }
		}
		public static Color GreySelection
		{
			get { return ColourConfig.GetGreySelection(); }
		}
		public static Color DarkGreySelection
		{
			get { return ColourConfig.GetDarkGreySelection(); }
		}
		public static Color DarkBlueBorder
		{
			get { return ColourConfig.GetDarkBlueBorder(); }
		}
		public static Color LightBlueBorder
		{
			get { return ColourConfig.GetLightBlueBorder(); }
		}
		public static Color ActiveControl
		{
			get { return ColourConfig.GetActiveControl(); }
		}
		public static Color MenuItemToggledOnFill
		{
			get { return ColourConfig.GetMenuItemToggledOnFill(); }
		}
		public static Color MenuItemToggledOnBorder
		{
			get { return ColourConfig.GetMenuItemToggledOnBorder(); }
		}
	}
}
