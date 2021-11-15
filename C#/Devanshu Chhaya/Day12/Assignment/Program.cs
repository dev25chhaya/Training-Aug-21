using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ToysManufacturingCompany.Models;

namespace ToysManufacturingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContext())
            {
                //List<Plant> Plants = new List<Plant>()
                //{
                //    new Plant(){ Location="Ahmedabad"},
                //    new Plant(){ Location="Rajkot"},
                //    new Plant(){ Location="Mumbai"}
                //};

                //context.Plants.AddRange(Plants);


                //List<ToysCategory> toysCategories = new List<ToysCategory>()
                //{
                //    new ToysCategory(){ Name="Vehicals",PlantsId=1},
                //    new ToysCategory(){ Name="Animals", PlantsId=2},
                //    new ToysCategory(){ Name="Musical", PlantsId=3}
                //};

                //context.ToysCategories.AddRange(toysCategories);
                //context.SaveChanges();

                //List<Toys> toys = new List<Toys>()
                //{
                //    new Toys(){ Name="Lion", ToysCategoryId=2, UnitPrice=1500},
                //    new Toys(){ Name="Drum", ToysCategoryId=3, UnitPrice=2000},
                //    new Toys(){ Name="Bike", ToysCategoryId=1, UnitPrice=500},
                //};

                //context.Toys.AddRange(toys);
                //context.SaveChanges();

                //List<Customer> customers = new List<Customer>()
                //{
                //    new Customer(){ Name="Ajay"},
                //    new Customer(){ Name="Milan"},
                //    new Customer(){ Name="Dinesh"}
                //};

                //context.Customers.AddRange(customers);
                //context.SaveChanges();

                //List<Address> addresses = new List<Address>()
                //{
                //    new Address(){ AddressLine="Near station",City="Ahmedabad",Pincode=121211, State="Gujarat",CustomerId=1},
                //    new Address(){ AddressLine="Gandhi road", City="Junagadh",Pincode=212121, State="Gujarat", CustomerId=2 },
                //    new Address(){ AddressLine="Nehru park",City="Mumbai",Pincode=101010, State="Maharashtra",CustomerId=3},
                //};

                //context.Addresses.AddRange(addresses);
                //context.SaveChanges();

                //List<Order> orders = new List<Order>()
                //{
                //    new Order(){ TotalAmount=2500, TotalDiscount=200, NetAmount=2300 , AddressId=1},
                //    new Order(){ TotalAmount=3500, TotalDiscount=200, NetAmount=3300 , AddressId=2},
                //    new Order(){ TotalAmount=2000, TotalDiscount=200, NetAmount=1800 , AddressId=3}
                //};

                //context.Orders.AddRange(orders);
                //context.SaveChanges();

                //List<Purchase> purchases = new List<Purchase>()
                //{
                //    new Purchase(){ToysId=3, OrderId=1, Quantity=2},
                //    new Purchase(){ToysId=2, OrderId=2, Quantity=1},
                //    new Purchase(){ToysId=1, OrderId=1, Quantity=1}
                //};

                //context.Purchases.AddRange(purchases);
                //context.SaveChanges();

                var add = context.Addresses.FromSqlRaw("getAddress '1'").ToList();
                foreach(var i in add)
                {
                    Console.WriteLine(i.AddressId+" "+i.AddressLine+" "+i.City+" "+i.State+" "+i.Pincode);
                    Console.WriteLine();
                }

                //----- add customer------//

                List<Customer> customers = new List<Customer>()
                {
                    new Customer(){Name="Mayur"}
                };
                context.Customers.AddRange(customers);
                context.SaveChanges();

                //------ Update customer------//

                var cust = context.Customers.First<Customer>();
                cust.Name = "Ajay A.";
                context.SaveChanges();

                //----- Remove Customer ------//

                var remcust = context.Customers.First<Customer>();
                context.Customers.Remove(remcust);

                Console.WriteLine("Choose 1 to watch all products");
                var choice =Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        products();
                        break;

                    
                                
                }

                void products()
                {
                    var pro = context.Toys.Include(s => s.ToysCategory).ToList();
                    foreach(var i in pro)
                    {
                        Console.WriteLine("Id: "+i.ToysID);
                        Console.WriteLine("Name: "+i.Name);
                        Console.WriteLine("Price: "+i.UnitPrice);
                        Console.WriteLine("Catogery: "+i.ToysCategory.Name);
                    }
                }
            }

        }
    }
}
