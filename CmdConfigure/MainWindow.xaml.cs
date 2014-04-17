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
            LoadCurrentCmdSettings();
        }

        private void LoadCurrentCmdSettings()
        {
            var settings = CmdRegistry.ReadCmdSettings();
            var font = FontsListView.Items.Cast<FontFamily>().FirstOrDefault(x => x.ToString() == settings.FontName);
            FontsListView.SelectedItem = font;

            var fontSize = SizeListView.Items.Cast<string>().FirstOrDefault(x => x == settings.FontSize.ToString());
            SizeListView.SelectedItem = fontSize;

            var foreColor = ForegroundColorComboBox.Items.Cast<ConsoleColorEntry>().FirstOrDefault(x => x.Color == settings.ForegroundColor);
            ForegroundColorComboBox.SelectedItem = foreColor;

            var backColor = BackgroundColorComboBox.Items.Cast<ConsoleColorEntry>().FirstOrDefault(x => x.Color == settings.BackgroundColor);
            BackgroundColorComboBox.SelectedItem = backColor;
        }
    }
}
