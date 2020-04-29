using Basketball_Card_Tracker.Models;
using Basketball_Card_Tracker.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for MissingWindow.xaml
    /// </summary>
    public partial class MissingWindow : Window
    {
        private readonly MainWindow mainWindow;
        private readonly MissingWindowViewModel viewModel;

        public MissingWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            viewModel = new MissingWindowViewModel();
            this.DataContext = viewModel;
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

        private void MoveSelectedToNumbered(object sender, RoutedEventArgs e)
        {
            viewModel.MoveCardsToNumbered();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedCards = (sender as DataGrid).SelectedItems;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.SearchStr = (sender as TextBox).Text;
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Card card = e.EditingElement.DataContext as Card;
            string newSeller = ((TextBox)e.EditingElement).Text;
            card.Seller = newSeller;
            viewModel.UpdateCard(card);
        }
    }
}
