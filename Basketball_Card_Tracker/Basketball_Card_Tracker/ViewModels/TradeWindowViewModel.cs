using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Basketball_Card_Tracker.ViewModels
{
    public class TradeWindowViewModel : ViewModelBase
    {
        public Card SelectedCard { get; set; }

        public TradeWindowViewModel()
        {
            Category = "Trade";
            LoadTable();
        }

        public override void LoadTable()
        {
            using CardTrackerContext context = new CardTrackerContext();
            if (String.IsNullOrEmpty(SearchStr))
            {
                var tradeCards = context.Cards
                .Where(card => card.Category == this.Category);
                Cards = new ObservableCollection<Card>(tradeCards);

            }
            else
            {
                var numberedCards = context.Cards
                .Where(card => card.Category == this.Category && card.Player.Contains(SearchStr));
                Cards = new ObservableCollection<Card>(numberedCards);
            }
        }

        public void DecreaseQuantity()
        {
            using CardTrackerContext context = new CardTrackerContext();
            var result = context.Cards.SingleOrDefault(card => card.Id == SelectedCard.Id);
            result.Quantity--;
            if (result.Quantity == 0)
            {
                context.Remove(result);
            }
            context.SaveChanges();
            LoadTable();
        }

        public void IncreaseQuantity()
        {
            using CardTrackerContext context = new CardTrackerContext();
            var result = context.Cards.SingleOrDefault(card => card.Id == SelectedCard.Id);
            result.Quantity++;
            context.SaveChanges();
            LoadTable();
        }
    }
}
