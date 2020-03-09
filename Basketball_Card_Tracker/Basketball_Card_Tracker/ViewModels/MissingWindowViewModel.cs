using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Basketball_Card_Tracker.ViewModels
{
    public class MissingWindowViewModel : ViewModelBase
    {
        public override void LoadTable()
        {
            Category = "Missing";
            using CardTrackerContext context = new CardTrackerContext();
            var missingCards = context.Cards
                .Where(card => card.Category == "Missing");
            Cards = new ObservableCollection<Card>(missingCards);
        }
    }
}
