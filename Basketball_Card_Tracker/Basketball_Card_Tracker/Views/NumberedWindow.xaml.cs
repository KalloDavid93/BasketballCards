using Basketball_Card_Tracker.Models;
using Basketball_Card_Tracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for NumberedWindow.xaml
    /// </summary>
    public partial class NumberedWindow : Window
    {
        MainWindow mainWindow;
        private readonly NumberedWindowViewModel numberedWindowViewModel;

        public NumberedWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            numberedWindowViewModel = new NumberedWindowViewModel();
            this.DataContext = numberedWindowViewModel;
        }

        private void Close(object sender, EventArgs e)
        {
            mainWindow.numberedWindow = null;
        }

        private void OpenAddCard(object sender, RoutedEventArgs e)
        {
            AddCardWindow addCardWindow = new AddCardWindow(numberedWindowViewModel);
            addCardWindow.Show();
        }

        private void RemoveSelected(object sender, RoutedEventArgs e)
        {
            numberedWindowViewModel.DeleteCards();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            numberedWindowViewModel.SelectedCards = (sender as DataGrid).SelectedItems;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numberedWindowViewModel.SearchStr = (sender as TextBox).Text;
        }
    }
}
