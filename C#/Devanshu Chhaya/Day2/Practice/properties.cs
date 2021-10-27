using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    public class prac
    {
        private string msg = "Hello Everyone";

        public string Msg
        {
            get
            {
                return msg;
            }

            set
            {
                msg = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
            p.Msg = "This is Msg property for msg field";
            Console.WriteLine(p.Msg);

            Console.ReadLine();
        }
    }
}
