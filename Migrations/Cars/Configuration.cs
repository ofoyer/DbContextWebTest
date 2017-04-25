namespace DbContextWebTest.Migrations.Cars
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DbContextWebTest.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContextWebTest.Context.CarsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Cars";
        }

        protected override void Seed(DbContextWebTest.Context.CarsDbContext context)
        {
            Cars[] SeedCars = new Cars[] {   new Cars() { CarName = "Toyota",IsChecked = true },
                                         new Cars() { CarName = "BMW",IsChecked = false },
                                         new Cars() { CarName = "Hundai",IsChecked = true }};

            context.Cars.AddOrUpdate(SeedCars);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
