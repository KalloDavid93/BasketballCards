using Basketball_Card_Tracker.Views;
using System.Windows;

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
