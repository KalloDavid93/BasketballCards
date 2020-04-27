using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;

namespace Basketball_Card_Tracker.ViewModels
{
    public class MissingWindowViewModel : ViewModelBase
    {
        public MissingWindowViewModel()
        {
            Category = "Missing";
            LoadTable();
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
