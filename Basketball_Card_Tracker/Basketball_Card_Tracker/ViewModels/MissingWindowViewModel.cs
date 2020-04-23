using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Basketball_Card_Tracker.ViewModels
{
    public class MissingWindowViewModel : ViewModelBase
    {
        public MissingWindowViewModel()
        {
            Category = "Missing";
            LoadTable();
        }

        public override void LoadTable()
        {
            using CardTrackerContext context = new CardTrackerContext();
            if (String.IsNullOrEmpty(SearchStr))
            {
                var missingCards = context.Cards
                .Where(card => card.Category == this.Category);
                Cards = new ObservableCollection<Card>(missingCards);
            }
            else
            {
                var numberedCards = context.Cards
                .Where(card => card.Category == this.Category && card.Player.Contains(SearchStr));
                Cards = new ObservableCollection<Card>(numberedCards);
            }
        }

        public void MoveCardsToNumbered()
        {
            using CardTrackerContext context = new CardTrackerContext();
            foreach (Card card in SelectedCards)
            {
                card.Category = "Numbered";
                context.Update(card);
            }
            context.SaveChanges();
            LoadTable();
        }
    }
}
