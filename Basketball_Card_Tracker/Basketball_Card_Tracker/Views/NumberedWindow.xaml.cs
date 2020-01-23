using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for NumberedWindow.xaml
    /// </summary>
    public partial class NumberedWindow : Window
    {
        MainWindow mainWindow;

        public NumberedWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Close(object sender, EventArgs e)
        {
            mainWindow.numberedWindow = null;
        }

        private void OpenAddCard(object sender, RoutedEventArgs e)
        {
            AddCardWindow addCardWindow = new AddCardWindow();
            addCardWindow.Show();
        }
    }
}
