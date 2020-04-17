using System;
using System.Windows;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for MissingWindow.xaml
    /// </summary>
    public partial class MissingWindow : Window
    {
        MainWindow mainWindow;

        public MissingWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Close(object sender, EventArgs e)
        {
            mainWindow.missingWindow = null;
        }
    }
}
