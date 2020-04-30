using Basketball_Card_Tracker.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : UserControl
    {
        private readonly MainWindow mainWindow;
        private readonly MissingWindowViewModel viewModel;

        public BaseWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            mainWindow.missingWindow = null;
        }

        private void OpenAddCard(object sender, RoutedEventArgs e)
        {
            AddCardWindow addCardWindow = new AddCardWindow(viewModel);
            addCardWindow.Show();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.SearchStr = (sender as TextBox).Text;
        }
    }
}
