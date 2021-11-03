using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulartion
{
    
        public class encp
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

        }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new encp();
            Console.WriteLine(obj.Name="Dev");
            Console.ReadLine();
        }
    }
}
