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
        public static int[] FontSizes = new[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

        public const string ExampleText = "Microsoft Windows [Version 6.1.7601]\n" +
                                           "Copyright (c) 2009 Microsoft Corporation. All rights reserved.\n\n" +
                                           "C:\\Users\\Admin>";

        public static List<ConsoleColorEntry> ColorList = new List<ConsoleColorEntry> {
            new ConsoleColorEntry {Name = "Black", Color = ConsoleColor.Black, Brush = Brushes.Black},
            new ConsoleColorEntry {Name = "Dark Blue", Color = ConsoleColor.DarkBlue, Brush = Brushes.DarkBlue},
            new ConsoleColorEntry {Name = "Dark Green", Color = ConsoleColor.DarkGreen, Brush = Brushes.DarkGreen},
            new ConsoleColorEntry {Name = "Dark Cyan", Color = ConsoleColor.DarkCyan, Brush = Brushes.DarkCyan},
            new ConsoleColorEntry {Name = "Dark Red", Color = ConsoleColor.DarkRed, Brush = Brushes.DarkRed},
            new ConsoleColorEntry {Name = "Dark Magenta", Color = ConsoleColor.DarkMagenta, Brush = Brushes.DarkMagenta},
            new ConsoleColorEntry {Name = "Dark Yellow", Color = ConsoleColor.DarkYellow, Brush = new SolidColorBrush(Color.FromArgb(255,128,128,0))},
            new ConsoleColorEntry {Name = "Gray", Color = ConsoleColor.Gray, Brush = Brushes.Gray},
            new ConsoleColorEntry {Name = "Dark Gray", Color = ConsoleColor.DarkGray, Brush = Brushes.DarkGray},
            new ConsoleColorEntry {Name = "Blue", Color = ConsoleColor.Blue, Brush = Brushes.Blue},
            new ConsoleColorEntry {Name = "Green", Color = ConsoleColor.Green, Brush = Brushes.LightGreen},
            new ConsoleColorEntry {Name = "Cyan", Color = ConsoleColor.Cyan, Brush = Brushes.Cyan},
            new ConsoleColorEntry {Name = "Red", Color = ConsoleColor.Red, Brush = Brushes.Red},
            new ConsoleColorEntry {Name = "Magenta", Color = ConsoleColor.Magenta, Brush = Brushes.Magenta},
            new ConsoleColorEntry {Name = "Yellow", Color = ConsoleColor.Yellow, Brush = Brushes.Yellow},
            new ConsoleColorEntry {Name = "White", Color = ConsoleColor.White, Brush = Brushes.White},
        };
    }

    public class ConsoleColorEntry
    {
        public string Name { get; set; }
        public ConsoleColor Color { get; set; }
        public SolidColorBrush Brush { get; set; }
    }
}
