using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Basketball_Card_Tracker.ViewModels
{
    class NumberedWindowViewModel
    {
        public ObservableCollection<Card> Cards { get; set; }
        private List<Card> CheckedCards { get; set; }

        public NumberedWindowViewModel()
        {
            using CardTrackerContext context = new CardTrackerContext();
            Cards = new ObservableCollection<Card>(context.Cards);
            CheckedCards = new List<Card>();
        }

        public void CheckCard(Card card)
        {
            CheckedCards.Add(card);
        }

        public void UnCheckCard(Card card)
        {
            CheckedCards.Remove(card);
        }

        public void DeleteCards()
        {
            using CardTrackerContext context = new CardTrackerContext();
            foreach (Card card in CheckedCards)
            {
                context.Remove(card);
                context.SaveChanges();
            }
        }
    }
}
