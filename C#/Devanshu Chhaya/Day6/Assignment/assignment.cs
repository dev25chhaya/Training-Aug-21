
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Program
    {
        //Compute area of rectangle using func delegate

        public delegate void area(int a, int b);

        public void rectarea(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Area of rectangle: "+res);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            var del_obj = new area(obj.rectarea);

            del_obj(5, 5);

            //Compute add of two number using lambda expression

            Func<int, int, int> val = (x, y) => x + y;
            Console.WriteLine();
            Console.WriteLine("The sum is: "+val(5,5));

            Console.ReadLine();
        }


    }
}
