using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Drawing.Text;

namespace CmdConfigure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FontsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExampleTextBox == null)
                return;

            var selectedFont = e.AddedItems[0] as FontFamily;
            ExampleTextBox.FontFamily = selectedFont;

        }

        private void SizeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExampleTextBox == null)
                return;

            var selectedSize = e.AddedItems[0] as int?;
            ExampleTextBox.FontSize = selectedSize.Value;
        }

        private void BackgroundColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExampleTextBox == null)
                return;

            var backColor = e.AddedItems[0] as ConsoleColorEntry;
            ExampleTextBox.Background = backColor.Brush;
        }

        private void ForegroundColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExampleTextBox == null)
                return;

            var foreColor = e.AddedItems[0] as ConsoleColorEntry;
            ExampleTextBox.Foreground = foreColor.Brush;
        }
    }
}
