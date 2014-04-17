using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdConfigure
{
    public static class CmdRegistry
    {
        public static CmdSettings ReadCmdSettings()
        {
            var currentFontKey = "0";
            var installedFonts = new Dictionary<string, string>();

            while (true)
            {
                var key = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Console\TrueTypeFont", currentFontKey, null);
                if (key == null)
                    break;

                installedFonts.Add(currentFontKey, key.ToString());
                currentFontKey += "0";

            }


            return new CmdSettings 
            { 
                FontName = "Courier New", 
                FontSize=20,
                ForegroundColor = ConsoleColor.Green,
                BackgroundColor = ConsoleColor.Black
            };
        }

    }
}
