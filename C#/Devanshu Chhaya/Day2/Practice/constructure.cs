using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorPrac
{
    class prac
    {
        string name;
        int age;

        public prac()
        {
            Console.WriteLine("called");
        }

        public prac(string name)
        {
            this.name = name;
        }

        public prac(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        static void Main(string[] args)
        {
            var p1 = new prac();
            Console.WriteLine(p1.age+" "+p1.name);

            var p2 = new prac("Dev");
            Console.WriteLine(p2.name + " " + p2.age);

            var p3 = new prac("Dev", 22);
            Console.WriteLine(p3.name + " " + p3.age);



            Console.ReadLine();
        }
    }
}
