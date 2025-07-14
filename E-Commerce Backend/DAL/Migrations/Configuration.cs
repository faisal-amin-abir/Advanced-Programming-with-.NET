namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ProductContext>
    {
        internal int OrderDetailsId;

        public Configuration()
        {
            OrderDetailsId = 1;
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(DAL.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for(int i=1; i<=10; i++) {
                context.Users.AddOrUpdate(new User
                {
                    Id = i,
                    Name = "Name-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 15),
                    Type = "General",
                    Gender = (i % 2 == 0 ? "Male" : "Female")
                });
            }
            Random random = new Random();
            for(int i=1; i<=20; i++)
            {
                context.Products.AddOrUpdate(new Product
                {
                    Id = i,
                    Name = "Product-" + i,
                    UnitPrice = random.Next(0, 5000),
                    Description = Guid.NewGuid().ToString()
                });
            }
            for(int i=1; i<=100; i++)
            {
                context.Orders.AddOrUpdate(new Order
                {
                    Id = i,
                    CustomerId = random.Next(1, 11),
                    Date = DateTime.Now
                });
            }

            for(int i=1; i<=100; i++)
            {
                int ProductCnt = random.Next(1, 6);
                int UnitP = random.Next(0, 50000);

                for(int j=1; j<=ProductCnt; j++)
                {
                    context.OrderDetails.AddOrUpdate(new OrderDetails
                    {
                        Id = OrderDetailsId,
                        OrderId = i,
                        ProductId = random.Next((j - 1) * 4 + 1, j * 4 + 1),
                        Quantity = random.Next(0, 20),
                        UnitPrice = random.Next(0, 50000)
                    });
                    OrderDetailsId++;
                }
            }

            for(int i=1; i<=5; i++)
            {
                context.Carts.AddOrUpdate(new Cart
                {
                    Id = i,
                    CustomerId = random.Next(1, 11),
                    ProductId = random.Next(1, 21)
                });
            }
        }
    }
}
