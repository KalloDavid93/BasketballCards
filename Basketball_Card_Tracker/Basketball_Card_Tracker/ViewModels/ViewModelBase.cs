using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Basketball_Card_Tracker.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private ObservableCollection<Card> _cards;
        public ObservableCollection<Card> Cards
        {
            get { return _cards; }
            set
            {
                _cards = value;
                OnPropertyChanged();
            }
        }
        public IList SelectedCards { get; set; }
        private string _searchStr;
        public string SearchStr
        {
            get { return _searchStr; }
            set
            {
                _searchStr = value;
                LoadTable();
            }
        }
        public string Category { get; set; }

        public ViewModelBase()
        {
            LoadTable();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void DeleteCards()
        {
            using CardTrackerContext context = new CardTrackerContext();
            foreach (Card card in SelectedCards)
            {
                context.Remove(card);
                context.SaveChanges();
            }
            LoadTable();
        }

        public void UpdateCard(Card card)
        {
            using CardTrackerContext context = new CardTrackerContext();
            System.Diagnostics.Debug.WriteLine(card.Seller + " viewmodel");
            context.Update(card);
            context.SaveChanges();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        virtual public void LoadTable() { }
    }
}
