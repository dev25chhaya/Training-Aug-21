using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract class Abstraction
    {
        public abstract double Area();
    }

    class Square : Abstraction
    {

        private int side;

       
        public Square(int x = 0)
        {
            side = x;
        }

        
        public override double Area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Square(4);
            Console.WriteLine(obj.Area());
            Console.ReadKey();
        }
    }
}
