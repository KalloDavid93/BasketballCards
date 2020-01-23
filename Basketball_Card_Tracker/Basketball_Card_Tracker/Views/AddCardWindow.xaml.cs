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
    /// Interaction logic for AddCardWindow.xaml
    /// </summary>
    public partial class AddCardWindow : Window
    {
        public AddCardWindow()
        {
            InitializeComponent();
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
