using Basketball_Card_Tracker.ViewModels;
using MahApps.Metro.Controls;
using System.Windows;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for AddCardWindow.xaml
    /// </summary>
    public partial class AddCardWindow : MetroWindow
    {
        private readonly AddCardViewModel addCardViewModel;

        public AddCardWindow(ViewModelBase viewModel)
        {
            InitializeComponent();
            addCardViewModel = new AddCardViewModel(viewModel);
            this.DataContext = addCardViewModel;
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            addCardViewModel.GenerateCard();
            this.Close();
        }
    }
}
