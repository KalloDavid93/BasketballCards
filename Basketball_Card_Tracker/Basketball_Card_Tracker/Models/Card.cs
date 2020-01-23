using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Basketball_Card_Tracker.Models
{
    public abstract class Card
    {
        [Key]
        public int Id { get; set; }
        public string Insert { get; set; }
        public string Serial { get; set; }
        public string Player { get; set; }
        public string Parallel { get; set; }
        public int Numbered { get; set; }

    }
}
