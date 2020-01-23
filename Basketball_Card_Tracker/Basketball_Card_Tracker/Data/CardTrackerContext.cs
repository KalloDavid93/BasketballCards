using Basketball_Card_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basketball_Card_Tracker.Data
{
    class CardTrackerContext : DbContext
    {
        public DbSet<CardMissing> MissingCards { get; set; }
        public DbSet<CardNumbered> NumberedCards { get; set; }
        public DbSet<CardForTrade> ForTradeCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BasketballCardTrackerDB");
        }

    }
}
