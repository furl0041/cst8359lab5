using Lab5.Models;

namespace Lab5.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DealsFinderDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if database has already been seeded
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            // Seed Customers
            var customers = new Customer[]
            {
                new Customer{FirstName="Carson",LastName="Alexander",BirthDate=DateTime.Parse("1995-01-09")},
                new Customer{FirstName="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("1992-09-05")},
                new Customer{FirstName="Arturo",LastName="Anand",BirthDate=DateTime.Parse("1993-10-09")},
                new Customer{FirstName="Gytis",LastName="Barzdukas",BirthDate=DateTime.Parse("1992-01-09")},
            };

            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            // Seed FoodDeliveryServices
            var foodDeliveryServices = new FoodDeliveryService[]
            {
                new FoodDeliveryService{Id="A1",Title="Alpha",Fee=300},
                new FoodDeliveryService{Id="B1",Title="Beta",Fee=130},
                new FoodDeliveryService{Id="O1",Title="Omega",Fee=390},
            };

            foreach (FoodDeliveryService c in foodDeliveryServices)
            {
                context.FoodDeliveryServices.Add(c);
            }
            context.SaveChanges();

            // Seed Subscriptions
            var subscriptions = new Subscription[]
            {
                new Subscription{CustomerId=1,ServiceId="A1"},
                new Subscription{CustomerId=1,ServiceId="B1"},
                new Subscription{CustomerId=1,ServiceId="O1"},
                new Subscription{CustomerId=2,ServiceId="A1"},
                new Subscription{CustomerId=2,ServiceId="B1"},
                new Subscription{CustomerId=3,ServiceId="A1"},
            };

            foreach (var subscription in subscriptions)
            {
                context.Subscriptions.Add(subscription);
            }
            context.SaveChanges();
        }
    }
}