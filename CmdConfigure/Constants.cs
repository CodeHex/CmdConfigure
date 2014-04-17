using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CmdConfigure
{
    public static class Constants
    {
        

        public const string ExampleText = "Microsoft Windows [Version 6.1.7601]\n" +
                                           "Copyright (c) 2009 Microsoft Corporation. All rights reserved.\n\n" +
                                           "C:\\Users\\Admin>";

        public static List<ConsoleColorEntry> ColorList = new List<ConsoleColorEntry> {
            new ConsoleColorEntry {Name = "Black", Color = ConsoleColor.Black,              Brush = new SolidColorBrush(Color.FromRgb(0,0,0))},
            new ConsoleColorEntry {Name = "Dark Blue", Color = ConsoleColor.DarkBlue,       Brush = new SolidColorBrush(Color.FromRgb(0,0,128))},
            new ConsoleColorEntry {Name = "Dark Green", Color = ConsoleColor.DarkGreen,     Brush = new SolidColorBrush(Color.FromRgb(0,128,0))},
            new ConsoleColorEntry {Name = "Dark Cyan", Color = ConsoleColor.DarkCyan,       Brush = new SolidColorBrush(Color.FromRgb(0,128,128))},
            new ConsoleColorEntry {Name = "Dark Red", Color = ConsoleColor.DarkRed,         Brush = new SolidColorBrush(Color.FromRgb(128,0,0))},
            new ConsoleColorEntry {Name = "Dark Magenta", Color = ConsoleColor.DarkMagenta, Brush = new SolidColorBrush(Color.FromRgb(128,0,128))},
            new ConsoleColorEntry {Name = "Dark Yellow", Color = ConsoleColor.DarkYellow,   Brush = new SolidColorBrush(Color.FromRgb(128,128,0))},
            new ConsoleColorEntry {Name = "Gray", Color = ConsoleColor.Gray,                Brush = new SolidColorBrush(Color.FromRgb(192,192,192))},
            new ConsoleColorEntry {Name = "Dark Gray", Color = ConsoleColor.DarkGray,       Brush = new SolidColorBrush(Color.FromRgb(128,128,128))},
            new ConsoleColorEntry {Name = "Blue", Color = ConsoleColor.Blue,                Brush = new SolidColorBrush(Color.FromRgb(0,0,255))},
            new ConsoleColorEntry {Name = "Green", Color = ConsoleColor.Green,              Brush = new SolidColorBrush(Color.FromRgb(0,255,0))},
            new ConsoleColorEntry {Name = "Cyan", Color = ConsoleColor.Cyan,                Brush = new SolidColorBrush(Color.FromRgb(0,255,255))},
            new ConsoleColorEntry {Name = "Red", Color = ConsoleColor.Red,                  Brush = new SolidColorBrush(Color.FromRgb(255,0,0))},
            new ConsoleColorEntry {Name = "Magenta", Color = ConsoleColor.Magenta,          Brush = new SolidColorBrush(Color.FromRgb(255,0,255))},
            new ConsoleColorEntry {Name = "Yellow", Color = ConsoleColor.Yellow,            Brush = new SolidColorBrush(Color.FromRgb(255,255,0))},
            new ConsoleColorEntry {Name = "White", Color = ConsoleColor.White,              Brush = new SolidColorBrush(Color.FromRgb(255,255,255))},
        };
    }

    public class ConsoleColorEntry
    {
        public string Name { get; set; }
        public ConsoleColor Color { get; set; }
        public SolidColorBrush Brush { get; set; }
    }
}
