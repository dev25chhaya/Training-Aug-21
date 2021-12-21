using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class EmpAssContext: DbContext
    {
        public EmpAssContext(DbContextOptions<EmpAssContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignments> Assignments { get; set; }


    }
}
