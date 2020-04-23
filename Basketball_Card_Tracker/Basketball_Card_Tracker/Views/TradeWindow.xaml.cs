using Basketball_Card_Tracker.Models;
using Basketball_Card_Tracker.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for ForTradeWindow.xaml
    /// </summary>
    public partial class TradeWindow : Window
    {
        private readonly MainWindow mainWindow;
        private readonly TradeWindowViewModel tradeWindowViewModel;
        public TradeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            tradeWindowViewModel = new TradeWindowViewModel();
            this.DataContext = tradeWindowViewModel;
        }

        private void Close(object sender, EventArgs e)
        {
            mainWindow.tradeWindow = null;
        }

        private void OpenAddCard(object sender, RoutedEventArgs e)
        {
            AddCardWindow addCardWindow = new AddCardWindow(tradeWindowViewModel);
            addCardWindow.Show();
        }

        private void Decrease_Button_Click(object sender, RoutedEventArgs e)
        {
            Card card = ((Button)sender).DataContext as Card;
            tradeWindowViewModel.SelectedCard = card;
            tradeWindowViewModel.DecreaseQuantity();
        }

        private void Increase_Button_Click(object sender, RoutedEventArgs e)
        {
            Card card = ((Button)sender).DataContext as Card;
            tradeWindowViewModel.SelectedCard = card;
            tradeWindowViewModel.IncreaseQuantity();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tradeWindowViewModel.SearchStr = (sender as TextBox).Text;
        }
    }
}
