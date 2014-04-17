using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

using FontFamily = System.Windows.Media.FontFamily;
using FontStyle = System.Drawing.FontStyle;

namespace CmdConfigure
{
    public static class CmdFonts
    {
        public static string[] FontSizes {get; private set;}

        public static List<System.Windows.Media.FontFamily> FontFamilies { get; private set; }

        static CmdFonts()
        {
            FontSizes = new[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };

            FontFamilies = Fonts.SystemFontFamilies.Where(IsFixedPitchFont).OrderBy(x => x.Source).ToList();

            var drawFams = System.Drawing.FontFamily.Families;

            var fontz = new List<string>();
            drawFams.ToList().ForEach(x => fontz.Add(x.Name));

        }


        public static bool IsFixedPitchFont(FontFamily font)
        {
            try
            {
                var family = new System.Drawing.FontFamily(font.Source);

                if (!family.IsStyleAvailable(FontStyle.Regular))
                    return false;

                var winHandle = new System.Windows.Interop.WindowInteropHelper(App.Current.MainWindow).Handle;

                using (Graphics gr = Graphics.FromHwnd(winHandle))
                using (Font fnt = new Font(family, 10, FontStyle.Regular))
                {
                    return gr.MeasureString("iii", fnt).Width == gr.MeasureString("WWW", fnt).Width;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(font.Source);
                Console.WriteLine(exp);
                return false;
            }
        }
    }
}
