using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHTTPMethods.Models
{
    public class EmployeeContext:DbContext
    {
        //public EmployeeContext()
        //{
        //}

        public EmployeeContext(DbContextOptions<EmployeeContext> options):base (options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
