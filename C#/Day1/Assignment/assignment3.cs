//Create a weekday enum and accept week day number and display week day.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    enum weekDay
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sunday "+(int)weekDay.Sunday);
            Console.WriteLine("Monday " + (int)weekDay.Monday);
            Console.WriteLine("Tuesday " + (int)weekDay.Tuesday);
            Console.WriteLine("Wednesday " + (int)weekDay.Wednesday);
            Console.WriteLine("Thursday " + (int)weekDay.Thursday);
            Console.WriteLine("Friday " + (int)weekDay.Friday);
            Console.WriteLine("Saturday " + (int)weekDay.Saturday);

            Console.ReadLine();
        }
    }
}
