namespace API.Migrations.ApplicationUserMigrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialApplicationMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Score");
        }

        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Score", c => c.Int(nullable: false));
        }
    }
}