using Basketball_Card_Tracker.ViewModels;
using Basketball_Card_Tracker.Views;
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

namespace Basketball_Card_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MissingWindow missingWindow;
        public NumberedWindow numberedWindow;
        public TradeWindow tradeWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenMissingWindow(object sender, RoutedEventArgs e)
        {
            if (missingWindow == null)
            {
                missingWindow = new MissingWindow(this);
                missingWindow.Show();
            }
            else
            {
                missingWindow.Activate();
            }
        }

        private void OpenNumberedWindow(object sender, RoutedEventArgs e)
        {
            if (numberedWindow == null)
            {
                numberedWindow = new NumberedWindow(this);
                numberedWindow.Show();
            }
            else
            {
                numberedWindow.Activate();
            }
        }

        private void OpenTradeWindow(object sender, RoutedEventArgs e)
        {
            if (tradeWindow == null)
            {
                tradeWindow = new TradeWindow(this);
                tradeWindow.Show();
            }
            else
            {
                tradeWindow.Activate();
            }
        }
    }
}
