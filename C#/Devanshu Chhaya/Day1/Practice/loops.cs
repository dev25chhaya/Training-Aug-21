using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == 5))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }

            int cou = 0;
            do
            {
                Console.WriteLine($"The counter is {cou}");
                cou++;
            } while (cou < 5);

            
            for( int i=1; i<10; i*=2)
            {
                Console.WriteLine($"The value is{i}");
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }


            Console.ReadLine();
        }
    }
}
