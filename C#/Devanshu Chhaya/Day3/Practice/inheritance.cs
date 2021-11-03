using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class super
    {
        string name;
        string department;

        public void display (string name, string dept)
        {
            this.name = name;
            this.department = dept;
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Department: "+department);

        }
    }

    class sub:super
    {
        public sub()
        {
            Console.WriteLine("Constructor is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new sub();
            s1.display("dev", ".NET");
            Console.ReadLine();
        }
    }
}
