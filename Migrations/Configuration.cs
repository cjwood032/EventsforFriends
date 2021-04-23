namespace Events.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Events.Models.EventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Events.Models.EventDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 1, InPerson=true, InterestName="Board Games", UserID=null});
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 2, InPerson=false, InterestName = "Bad Movies", UserID = null });
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 3, InPerson=true, InterestName = "Tabletop Games", UserID = null });
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 4, InPerson=false, InterestName = "Crafts", UserID = null });
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 5, InPerson=true, InterestName = "Food", UserID = null });
            context.interests.AddOrUpdate(new Models.Interest() { InterestID = 6, InPerson = false, InterestName = "Hanging out", UserID = null });
            context.groups.AddOrUpdate(new Models.Group() { OwnerID = 1, GroupName = "Bad Movie Fans" } );
            context.groups.AddOrUpdate(new Models.Group() { OwnerID = 1, GroupName = "Board Game friends" });
            context.groups.AddOrUpdate(new Models.Group() { OwnerID = 1, GroupName = "DnD campaign" });
            context.shindigs.AddOrUpdate(new Models.Shindig() { OwnerID = 1, DateOfEvent = new DateTime(2022, 03, 14), ShindigName = "Pi Day", Openings = 10, interestID = 5, ShindigDescription = "Come eat pie at the casa de woocha!", Location = "Casa de Woocha" });
        }
    }
}
