using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethod
{
    static class NewMethod
    {
        public static void M4(this Practice p)
        {
            Console.WriteLine("4th method");
        } 

        public static void M5(this Practice p, string str)
        {
            Console.WriteLine(str);
        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            Practice p = new Practice();
            p.M1();
            p.M2();
            p.M3();
            p.M4();
            p.M5("5th method");
            Console.ReadLine();
        }
    }
}
