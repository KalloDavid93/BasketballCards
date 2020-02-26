using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Basketball_Card_Tracker.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Insert { get; set; }
        public string Player { get; set; }
        public string Serial { get; set; }
        public string Parallel { get; set; }
        public int Numbered { get; set; }
        public string Seller { get; set; }
        public int Quantity { get; set; }
        
        public Card(string insert, string serial, string player, string parallel, int numbered, string seller)
        {
            Insert = insert;
            Serial = serial;
            Player = player;
            Parallel = parallel;
            Numbered = numbered;
            Seller = seller;
            Quantity = 1;
        }
    }
}
