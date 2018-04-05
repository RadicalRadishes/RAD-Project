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
        Score = 10
    },
    new ApplicationUser
    {
        UserName = "RonnyJeed",
        Email = "RonnyJeed@mail.itsligo.ie",
        FirstName = "Jonny",
        LastName = "Reed",
        PasswordHash = "Password$2",
        Score = 8
    },
    new ApplicationUser
    {
        UserName = "CoelNoneely",
        Email = "CoelNoneely@mail.itsligo.ie",
        FirstName = "Noel",
        LastName = "Coneeley",
        PasswordHash = "Password$3",
        Score = 2
    },
        new ApplicationUser
        {
            UserName = "NiallNulty",
            Email = "NiallNulty@mail.itsligo.ie",
            FirstName = "Niall",
            LastName = "Nulty",
            PasswordHash = "Password$4",
            Score = 12
        }
    );
            context.SaveChanges();
        }
    }
}