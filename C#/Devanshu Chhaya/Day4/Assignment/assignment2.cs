//2.Create a user defined exception class NameException which will validate a Name and name should contain only character. 
//If name does not contain proper value it should throw an exception. You need to handle exception in student class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class NameException : Exception
    {
        public NameException()
        {
            Console.WriteLine("Please enter a valid name");
        }
    }

    class student
    {
        string Name;
        public StringBuilder s = new StringBuilder();
        public void get()
        {
            Console.WriteLine("Enter your name");

             Name = Console.ReadLine();

        }

        public void set()
        {
            try
            {
                for (int i = 0; i < Name.Length; i++)
                {

                    if (Char.IsDigit(Name[i]))
                    {
                        throw new NameException();
                    }
                    else
                    {
                        Console.WriteLine(Name[i]); 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new student();
            s1.get();
            s1.set();
            Console.ReadLine();
        }
    }
}

