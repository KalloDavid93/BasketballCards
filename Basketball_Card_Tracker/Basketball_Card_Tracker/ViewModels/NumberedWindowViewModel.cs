using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Basketball_Card_Tracker.ViewModels
{
    public class NumberedWindowViewModel : ViewModelBase
    {
        public override void LoadTable()
        {
            Category = "Numbered";
            using CardTrackerContext context = new CardTrackerContext();
            if (String.IsNullOrEmpty(SearchStr))
            {
                var numberedCards = context.Cards
                .Where(card => card.Category == "Numbered");
                Cards = new ObservableCollection<Card>(numberedCards);
            }
            else
            {
                var numberedCards = context.Cards
                .Where(card => card.Category == "Numbered" && card.Player.Contains(SearchStr));
                Cards = new ObservableCollection<Card>(numberedCards);
            }
        }
    }
}
