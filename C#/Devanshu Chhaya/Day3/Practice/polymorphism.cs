using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class overloading
    {
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int add(int a, int b)
        {
            return a + b;
        }
    }

    public class overriding
    {
        public virtual double area()
        {
            return 0;
        }

    }

    public class circle: overriding
    {
        public double radious { get; set; }
        public circle()
        {
            this.radious = 5;
        }

        public override double area()
        {
            return 3.14 * Math.Pow(radious, 2);
        }

    }

    public class square : overriding
    {
        public double side { get; set; }
        public square()
        {
            this.side = 5;
        }

        public override double area()
        {
            return side*4;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var obj = new overloading();
            Console.WriteLine( obj.add(2, 3, 4));
            Console.WriteLine(obj.add(2, 3));
            

            overriding obj1 = new overriding();
            overriding obj2 = new circle();
            var obj3 = new square();
            Console.WriteLine(obj3.area());
            Console.WriteLine(obj2.area());
            Console.WriteLine(obj1.area());
            Console.ReadKey();
        }
    }
}
