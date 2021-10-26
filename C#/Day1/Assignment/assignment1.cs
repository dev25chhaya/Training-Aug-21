//Print sum of all the even numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int sum=0;

            for( int i = 1; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    i++;
                }
            }

            Console.WriteLine($"The sum is {sum}");

            Console.ReadLine();
        }
    }
}
