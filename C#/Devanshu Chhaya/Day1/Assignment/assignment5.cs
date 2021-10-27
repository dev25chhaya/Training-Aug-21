//Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible. Do it with ternary operator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32( Console.ReadLine());

            var msg = (age < 18 ? "You not are eligible" : "You are eligible");
            Console.WriteLine(msg);
           
            Console.ReadLine();
        }
    }
}
