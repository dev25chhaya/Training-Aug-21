//Store your name in one string and find out how many vowel characters are there in your name.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "devanshu";
            int sum=0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    Console.WriteLine(name[i]);
                    sum += 1;
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
