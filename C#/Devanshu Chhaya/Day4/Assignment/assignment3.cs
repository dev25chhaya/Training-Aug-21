//3.Create a user defined Exception DateException class which will validate date should not be less than the current date. 
//If date is less than current date it should throw an exception.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class DateException : Exception
    {
        public DateException()
        {
            Console.WriteLine("Enter valid date");
        }
    }

    class dateobj
    {
        public DateTime date;

        public void get()
        {
            Console.WriteLine("Enter a date");

            date = DateTime.Parse(Console.ReadLine());
        }

        public void set()
        {
            DateTime today = DateTime.Now;

            int res = DateTime.Compare(date, today);

            //Console.WriteLine(res);

            try
            {
                if (res == -1)
                {
                    throw new DateException();
                }
                else
                {
                    Console.WriteLine("Accepted"); 
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                var obj = new dateobj();
                obj.get();
                obj.set();
                Console.ReadLine();
            }
        }
    }
}
