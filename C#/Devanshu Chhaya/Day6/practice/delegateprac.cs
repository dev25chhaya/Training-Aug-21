using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegatesprac.prac;


namespace delegatesprac
{
    class prac
    {
        public delegate void trydel(int a, int b);
        //public delegate void sumnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public int div( int a, int b, int c)
        {
            Console.WriteLine("hello");
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new prac();

            var add = new trydel(obj.sum);
            var sub = new trydel(obj.subtract);

            add(25, 25);
            sub(25, 25);

            Console.ReadLine();
        }
    }
}
