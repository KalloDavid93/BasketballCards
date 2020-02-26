using Basketball_Card_Tracker.Models;
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
using System.Windows.Shapes;

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
            AddCardWindow addCardWindow = new AddCardWindow();
            addCardWindow.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Card card = (Card)checkBox.DataContext;
            numberedWindowViewModel.CheckCard(card);
            System.Diagnostics.Debug.WriteLine(card.Player);
            
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Card card = (Card)checkBox.DataContext;
            numberedWindowViewModel.UnCheckCard(card);
        }

        private void RemoveSelected(object sender, RoutedEventArgs e)
        {
            numberedWindowViewModel.DeleteCards();
        }
    }
}
