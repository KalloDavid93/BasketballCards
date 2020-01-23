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
