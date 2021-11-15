using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToysCompany;Trusted_Connection=True;");
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<ToysCategory> ToysCategories { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Toys> Toys { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
