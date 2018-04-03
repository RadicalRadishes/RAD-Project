using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Models.Scores
{
    public class ScoresDbContext : DbContext
    {
        public ScoresDbContext() : base("DefaultConnextion")
        {
            Database.SetInitializer(new ScoresDbInitializer());
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Score> Scores { get; set; }
    }
}