using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcdelegate
{
    class Program
    {
        public static int mymethod(int s, int d, int f, int g)
        {
            return s * d * f * g;
        }
        static void Main(string[] args)
        {
            Func<int, int, int, int, int> val = mymethod;
            Console.WriteLine(val(10, 100, 1000, 1));
            Console.ReadLine();


        }
    }
}
