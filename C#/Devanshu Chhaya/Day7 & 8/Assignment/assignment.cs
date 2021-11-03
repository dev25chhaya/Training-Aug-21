
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Employee

    {

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Deparment { get; set; }

    }

    class Incentive

    {

        public int ID { get; set; }

        public double IncentiveAmount { get; set; }

        public DateTime IncentiveDate { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>()

            {

                new Employee(){ ID=1,FirstName="John",LastName="Abraham",Salary=1000000,JoiningDate=new DateTime(2013,1,1),Deparment="Banking"},

                new Employee(){ID=2,FirstName="Michael",LastName="Clarke",Salary=800000,JoiningDate=new DateTime(),Deparment="Insurance" },

                new Employee(){ID=3,FirstName="oy",LastName="Thomas",Salary=700000,JoiningDate=new DateTime() ,Deparment="Insurance"},

                   new Employee(){ID=4,FirstName="Tom",LastName="Jose",Salary=600000,JoiningDate=new DateTime() ,Deparment="Banking"},

                      new Employee(){ID=4,FirstName="TestName2", LastName="Lname%", Salary=600000,JoiningDate=new DateTime(2013,1,1) ,Deparment="Services"}

            };

            List<Incentive> incentives = new List<Incentive>()

            {

                new Incentive(){ ID=1,IncentiveAmount=5000,IncentiveDate=new DateTime(2013,02,02)},

                new Incentive(){ID=2,IncentiveAmount=10000,IncentiveDate=new DateTime(2013,02,4)},

                new Incentive(){ID=1,IncentiveAmount=6000,IncentiveDate=new DateTime(2012,01,5)},

                new Incentive(){ID=2,IncentiveAmount=3000,IncentiveDate=new DateTime(2012,01,5)}

            };

            //1.Get employee details from employees object whose employee name is “John" (note restrict operator)

            Console.WriteLine("Quer 1: ");

            var query1 = employees.Where(s => s.FirstName == "John" || s.LastName == "John");

            foreach(var val in query1)
            {
                Console.WriteLine("ID: "+val.ID+" || First Name: "+val.FirstName+" || Last Name: "+val.LastName+" || Salary: "+val.Salary+" || Department: "+val.Deparment);
            }

            var res1 = from emp in employees
                       where emp.FirstName == "John" || emp.LastName == "John"
                       select emp;

            foreach (var val in res1)
            {
                Console.WriteLine("ID: " + val.ID + " || First Name: " + val.FirstName + " || Last Name: " + val.LastName + " || Salary: " + val.Salary + " || Department: " + val.Deparment);
            }

            Console.WriteLine();


            //2.Get FIRSTNAME,LASTNAMe from employees object(note project operator)

            Console.WriteLine("Quer 2: ");

            var query2 = employees.Select(s => new { Fname= s.FirstName, Lname= s.LastName});

            foreach( var val in query2)
            {
                Console.WriteLine(val.Fname+" "+val.Lname);
            }

            var res2 = from emp in employees
                       select new { Fname = emp.FirstName, Lname = emp.LastName };

            foreach (var val in query2)
            {
                Console.WriteLine(val.Fname + " " + val.Lname);
            }

            //3.Select FirstName, IncentiveAmount from employees and incentives object for those employees who have incentives.(join operator)
            Console.WriteLine();
            var groupjoin = from emp in employees
                            join ins in incentives
                            on emp.ID equals ins.ID
                            into insgrp
                            select new
                            {
                                emps = insgrp,
                                name = emp.FirstName
                            };

            foreach(var val in groupjoin)
            {
                
                foreach(var res in val.emps)
                {
                    Console.WriteLine(res.IncentiveAmount);
                    Console.WriteLine(val.name);
                }
            }


            //4.Get department wise maximum salary from employee table order by salary ascending (note group by)

            Console.WriteLine("Query: 4");

            //var query4 =
            //    employees.Max(s => s.Salary);

            //foreach()
            //{

            //}


            //foreach(var dept in query4)
            //{
            //    Console.WriteLine("Department: " +);
            //    foreach (var res in dept)
            //    {
            //        Console.WriteLine(res.FirstName);
            //    }

            //}

            var res4 = from emp in employees
                       group emp by emp.Deparment
                       into dept
                       select new
                       {
                           department = dept.Key,
                           Maxsal = dept.Max(c => c.Salary),

                       };

            var orderign = from ord in res4
                           orderby ord.Maxsal
                           select ord;

            foreach (var final in orderign)
                {
                    Console.WriteLine(final.department);
                    Console.WriteLine(final.Maxsal);
                    
                }


            //5.Select department, total salary with respect to a department from employees object where total salary greater than 800000 order by TotalSalary descending(group by having)

            Console.WriteLine();
            Console.WriteLine("Query - 5");

            var res5 = from emp in employees
                       group emp by emp.Deparment
                       into dept
                       select new
                       {
                           departmaent = dept.Key,
                           sumsal = dept.Sum(c => c.Salary)
                       };

            var final5 = from ord in res5
                         where ord.sumsal > 8000
                         orderby ord.sumsal descending
                         select ord;

            foreach (var final in final5)
            {
                Console.WriteLine(final.departmaent);
                Console.WriteLine(final.sumsal);

            }

            Console.ReadLine();


        }
    }
}
