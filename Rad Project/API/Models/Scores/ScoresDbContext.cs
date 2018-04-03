using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Models.Scores
{
    public class ScoresDbContext : DbContext
    {
        public ScoresDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new ScoresDbInitializer());
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Score> Scores { get; set; }

        //public System.Data.Entity.DbSet<API.Models.Displayed_Players.Players> Players { get; set; }

    }
}