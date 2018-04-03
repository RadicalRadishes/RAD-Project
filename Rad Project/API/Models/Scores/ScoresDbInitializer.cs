using System.Data.Entity;

namespace API.Models.Scores
{
    public class ScoresDbInitializer : CreateDatabaseIfNotExists<ScoresDbContext>
    {
        protected override void Seed(ScoresDbContext context)
        {


            context.SaveChanges();
        }
    }
}