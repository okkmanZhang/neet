using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.linq
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
    public class Purchase
    {
        public int ID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual Customer Customer { get; set; }

    }

    public class ExampleDB
    {
        public static List<Customer> Customers
        {
            get
            {
                return new List<Customer>
                {
                    new Customer { ID = 1, Name = "c1" },
                    new Customer { ID = 2, Name = "c2" },
                    new Customer { ID = 3, Name = "c3" },
                    new Customer { ID = 100, Name = "c100" },
                    new Customer { ID = 10, Name = "c10" }
                };
            }
        }

        public static List<Purchase> Purchases
        {
            get
            {
                return new List<Purchase>
                {
                    new Purchase{ ID = 1, Date = DateTime.Now, Description="p1", Price=1.1M },
                    new Purchase{ ID = 2, Date = DateTime.Now, Description="p2", Price=1.2M },
                    new Purchase{ ID = 3, Date = DateTime.Now, Description="p3", Price=1.3M },
                    new Purchase{ ID = 100, Date = DateTime.Now, Description="p100", Price=100.3M },
                    new Purchase{ ID = 10, Date = DateTime.Now, Description="p10", Price=10.3M },
                };
            }
        }

        public static List<Customer> CustomerPurchases
        {
            get
            {
                return new List<Customer>
                {
                    new Customer { ID = 1, Name = "c1" },
                    new Customer { ID = 2, Name = "c2" },
                    new Customer { ID = 3, Name = "c3", Purchases = new List<Purchase> {
                        new Purchase{ ID = 3, Date = DateTime.Now, Description="p3", Price=1.3M, CustomerID = 3},
                    } },
                    new Customer { ID = 100, Name = "c100", Purchases = new List<Purchase> {
                        new Purchase{ ID = 1, Date = DateTime.Now, Description="p1", Price=1.1M, CustomerID = 100 },
                        new Purchase{ ID = 2, Date = DateTime.Now, Description="p2", Price=1.2M, CustomerID = 100 },                    
                        new Purchase{ ID = 100, Date = DateTime.Now, Description="p100", Price=100.3M, CustomerID = 100 },
                        new Purchase{ ID = 10, Date = DateTime.Now, Description="p10", Price=10.3M, CustomerID = 100 },
                    } },
                    new Customer { ID = 10, Name = "c10" }
                };
            }
        }
    }
}
