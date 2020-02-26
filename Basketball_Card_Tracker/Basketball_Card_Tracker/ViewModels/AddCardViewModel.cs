using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basketball_Card_Tracker.ViewModels
{
    class AddCardViewModel
    {
        public string Insert { get; set; }
        public string Serial { get; set; }
        public string Player { get; set; }
        public string Parallel { get; set; }
        public int Numbered { get; set; }
        public string Seller { get; set; }

        public void GenerateCard()
        {
            using CardTrackerContext context = new CardTrackerContext();
            Card card = new Card(Insert, Serial, Player, Parallel, Numbered, Seller);
            context.Add(card);
            context.SaveChanges();
        }
    }
}
