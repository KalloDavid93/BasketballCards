using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void DeleteCards()
        {
            using CardTrackerContext context = new CardTrackerContext();
            foreach (Card card in SelectedCards)
            {
                context.Remove(card);
            }
            context.SaveChanges();
            LoadTable();
        }

        public void UpdateCard(Card card)
        {
            using CardTrackerContext context = new CardTrackerContext();
            context.Update(card);
            context.SaveChanges();
        }

        public void LoadTable()
        {
            using CardTrackerContext context = new CardTrackerContext();
            if (String.IsNullOrEmpty(SearchStr))
            {
                var cardsToLoad = context.Cards
                .Where(card => card.Category == this.Category);
                Cards = new ObservableCollection<Card>(cardsToLoad);
            }
            else
            {
                var cardsToLoad = context.Cards
                .Where(card => card.Category == this.Category && card.Player.Contains(SearchStr));
                Cards = new ObservableCollection<Card>(cardsToLoad);
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
