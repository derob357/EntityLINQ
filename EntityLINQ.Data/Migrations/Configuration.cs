namespace EntityLINQ.Data.Migrations
{
    using EntityLINQ.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityLINQ.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityLINQ.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Customers.AddOrUpdate(
                  p => p.Id,
                  new Customer { Id = 1, Name = "Deric", Birthdate =  DateTime.Now},
                  new Customer { Id = 2, Name = "Luke", Birthdate = DateTime.Now },
                  new Customer { Id = 3, Name = "Joe", Birthdate = DateTime.Now },
                  new Customer { Id = 4, Name = "Ray", Birthdate = DateTime.Now },
                  new Customer { Id = 5, Name = "Jason", Birthdate = DateTime.Now },
                  new Customer { Id = 6, Name = "Jared", Birthdate = DateTime.Now },
                  new Customer { Id = 7, Name = "Jonah", Birthdate = DateTime.Now },
                  new Customer { Id = 8, Name = "George", Birthdate = DateTime.Now },
                  new Customer { Id = 9, Name = "Andrew", Birthdate = DateTime.Now },
                  new Customer { Id = 10, Name = "Alex", Birthdate = DateTime.Now }
                );
                  
            context.Orders.AddOrUpdate(
                  p => p.Id,
                  new Order { Id = 1, Description = "Really cool", OrderDate = DateTime.Now, OrderTotal = 40.59, CustomerId = 1},
                  new Order { Id = 2, Description = "AWESOME", OrderDate = DateTime.Now, OrderTotal = 55.99, CustomerId = 2},
                  new Order { Id = 3, Description = "You want this", OrderDate = DateTime.Now, OrderTotal = 25.79, CustomerId = 3 },
                  new Order { Id = 4, Description = "But it now", OrderDate = DateTime.Now, OrderTotal = 17.99, CustomerId = 4 },
                  new Order { Id = 5, Description = "Do it, buy me", OrderDate = DateTime.Now, OrderTotal = 14.59, CustomerId = 5},
                  new Order { Id = 6, Description = "I need to be bought", OrderDate = DateTime.Now, OrderTotal = 20.99, CustomerId = 6 },
                  new Order { Id = 7, Description = "You need money for me", OrderDate = DateTime.Now, OrderTotal = 400.19, CustomerId = 7 },
                  new Order { Id = 8, Description = "I'm cheap", OrderDate = DateTime.Now, OrderTotal = 8.89, CustomerId = 8 },
                  new Order { Id = 9, Description = "Fantastic item", OrderDate = DateTime.Now, OrderTotal = 42.24, CustomerId = 9 },
                  new Order { Id = 10, Description = "Regular necessity", OrderDate = DateTime.Now, OrderTotal = 13.29, CustomerId = 10 }
                  );
            
        }
    }
}
