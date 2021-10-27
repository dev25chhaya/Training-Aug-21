using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 5;
            int d = 2;
            int c = a - b *d;
            Console.WriteLine(c);
            
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double d1 = 19;
            double d2 = 23;
            double d3 = 8;
            double res = (d1 + d2) / d3;
            Console.WriteLine(res); 

            double dmax   = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double e = 1.0;
            double f = 3.0;
            Console.WriteLine(e / f);

            decimal g = 1.0M;
            decimal h = 3.0M;
            Console.WriteLine(g / h);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);


            Console.ReadLine();

        }
    }
}
