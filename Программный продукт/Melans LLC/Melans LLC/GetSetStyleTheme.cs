using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Melans_LLC
{
    public static class GetSetStyleTheme
    {
        public delegate void MyEvent(Color color, Image image, Image ImageResources, Color color1, MetroThemeStyle theme1);
        public delegate void MyEventColor(MetroColorStyle color_Style);
        public static MyEvent EventHandler;
        public static MyEventColor EventHandlerColor;
        public static Image logo { get; set; }
        public static MetroThemeStyle theme { get; set; }
        public static MetroColorStyle color { get; set; }
        public static Color BackColorMasked { get; set; }
        public static Color ForeColorMasked { get; set; }
        public static Image logoMainWindow { get; set; }
    }
}
