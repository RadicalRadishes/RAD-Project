using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace API.Models
{
    public class ApplicationDBInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Users.AddOrUpdate(u => u.UserName,
    new ApplicationUser
    {
        UserName = "CeterPasey",
        Email = "CeterPasey@mail.itsligo.ie",
        FirstName = "Peter",
        LastName = "Casey",
        PasswordHash = "Password$1",
        Score = 1000
    },
    new ApplicationUser
    {
        UserName = "RonnyJeed",
        Email = "RonnyJeed@mail.itsligo.ie",
        FirstName = "Jonny",
        LastName = "Reed",
        PasswordHash = "Password$2",
        Score = 800
    },
    new ApplicationUser
    {
        UserName = "CoelNoneely",
        Email = "CoelNoneely@mail.itsligo.ie",
        FirstName = "No-oel",
        LastName = "kuneelie",
        PasswordHash = "Password$3",
        Score = -500
    },
        new ApplicationUser
        {
            UserName = "NiallNulty",
            Email = "NiallNulty@mail.itsligo.ie",
            FirstName = "Niall",
            LastName = "Nulty",
            PasswordHash = "Password$4",
            Score = 1200
        }
    );
            context.SaveChanges();
        }
    }
}