using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    interface Iemp
    {
        void get();
        void display();
        void salary();
    }

    public abstract class Empployee:Iemp
    {
        static int id=999;
        int pannumber;
        string name, address;

        public virtual void get()
        {
            id += 1;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();
            Console.WriteLine("Enter pannumber");
            pannumber =Convert.ToInt32( Console.ReadLine());

        }

        public virtual void display()
        {
            Console.WriteLine($"EmployeeId: {id}  ||  Name: {name}  ||  Adddress: {address}  ||  Pannumber: {pannumber}");
        }

        public abstract void salary();
        
    }

    public class parttime : Empployee
    {
        int noofhour, saleperhour, total;

        public override void salary()
        {
            Console.WriteLine("Enter noofhours");
            noofhour =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sale per hour");
            saleperhour =Convert.ToInt32(Console.ReadLine());
            total=((noofhour*100)+(saleperhour*100));
            
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Salary is: "+ total);
        }
    }

    public class fulltime: Empployee
    {
        int basic, HRA, TA, TD, total;

        public override void salary()
        {
            Console.WriteLine("Enter basic salary:");
            basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter HRA:");
            HRA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TA: ");
            TA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TD: ");
            TD = Convert.ToInt32(Console.ReadLine());

            total = basic + HRA - TA - TD;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Salary is: " + total);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iemp emp=null;

            Console.WriteLine("For parttime choose 1 and for fulltime choose 2");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: emp = new parttime();
                    break;

                case 2: emp = new fulltime();
                    break;
                
                default: Console.WriteLine("Invalid choice");
                    break;
            }

            emp.get();
            emp.salary();
            emp.display();
            
            Console.ReadLine();
        }
    }
}
