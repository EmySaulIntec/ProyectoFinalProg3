using DatabaseProject.Models;
using System.Data.Entity.Migrations;

namespace DatabaseProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexts.CashDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseProject.Contexts.CashDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var userAdmin = new User()
            {
                IsCasher = false,
                IsEnabled = true,
                UserName = "Admin",
                Password = "123",
                IsAdmin = true,
                Id = 1
            };

            context.Users.AddOrUpdate(userAdmin);
        }
    }
}
