namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.DataAccess;
    using FriendOrginizer.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
             f => f.FirstName,
             new Friend { FirstName = "Tom", Email = "tom.skott@gmai.co", LastName = "skott" },
             new Friend { FirstName = "Jerry", Email = "jerry.pill@gmai.co", LastName = "Pill" },
             new Friend { FirstName = "Pinokio", Email = "pinokio.dav@gmai.co", LastName = "Dav" },
             new Friend { FirstName = "Ivan", Email = "ivan.ivanov@gmai.co", LastName = "Ivanov" }
             );
        }
    }
}
