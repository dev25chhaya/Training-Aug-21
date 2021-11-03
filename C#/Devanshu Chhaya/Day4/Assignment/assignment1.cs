//1.Create a user defined Exception Class AgeException. If Age is less than 0 it should be thrown an exception. 
//And you need to handle that exception in student class.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class AgeException : Exception
    {
        public AgeException()
        {
            Console.WriteLine("Exception has occured: ");
        }


    }

    class student
    {
        public student(string name, int age)
        {
            if (age <= 0)
            {
                throw new AgeException();
            }
            Console.WriteLine("Name :"+name+"Age :"+age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var s1 = new student("Dev", 0);
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
