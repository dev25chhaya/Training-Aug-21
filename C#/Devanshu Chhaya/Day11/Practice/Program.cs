using EFcorePrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcorePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new practiceContext())
            {
                //---- Add ----//
                //var c1 = new Countries()
                //{
                //    CountryId="AA",
                //    CountryName="Austria",
                //    RegionId=5
                //};

                //context.Countries.Add(c1);
                //context.SaveChanges();

                List<Departments> departments = new List<Departments>()
                {
                    new Departments(){DepartmentId=280, DepartmentName=".NET", LocationId=1700, ManagerId=200},
                    new Departments(){DepartmentId=290, DepartmentName="Node", LocationId=1700, ManagerId=121},
                    new Departments(){DepartmentId=300, DepartmentName="Mobile", LocationId=1800, ManagerId=201}
                };
                context.Departments.AddRange(departments);
                context.SaveChanges();
                
            }
        }
    }
}
