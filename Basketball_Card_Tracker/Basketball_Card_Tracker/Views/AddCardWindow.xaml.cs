using Basketball_Card_Tracker.ViewModels;
using System.Windows;

namespace Basketball_Card_Tracker.Views
{
    /// <summary>
    /// Interaction logic for AddCardWindow.xaml
    /// </summary>
    public partial class AddCardWindow : Window
    {
        private readonly AddCardViewModel addCardViewModel;

        //public AddCardWindow(NumberedWindowViewModel numberedWindowViewModel)
        //{
        //    InitializeComponent();
        //    addCardViewModel = new AddCardViewModel(numberedWindowViewModel);
        //    this.DataContext = addCardViewModel;
        //}

        //public AddCardWindow(TradeWindowViewModel tradeWindowViewModel)
        //{
        //    InitializeComponent();
        //    addCardViewModel = new AddCardViewModel(tradeWindowViewModel);
        //    this.DataContext = addCardViewModel;
        //}

        //public AddCardWindow(MissingWindowViewModel missingWindowViewModel)
        //{
        //    InitializeComponent();
        //    addCardViewModel = new AddCardViewModel(missingWindowViewModel);
        //    this.DataContext = addCardViewModel;
        //}

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
