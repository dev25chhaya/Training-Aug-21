using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysManufacturingCompany.Models;

namespace ToysCompany.Models
{
    public class ToysCompanyContext:DbContext
    {
        
        public ToysCompanyContext(DbContextOptions<ToysCompanyContext> options) : base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<ToysCategory> ToysCategories { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Toys> Toys { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
