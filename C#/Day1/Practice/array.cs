using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
                Console.WriteLine(intArray[i]);
            }
            

            string[] weekday = new string[] { "Sun", "mon", "tue", "wed", "thus", "fri", "sat" };
            foreach(string day in weekday)
            {
                Console.WriteLine(day);
            }

            int[,] twodarrayint = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for( int i=0; i<twodarrayint.GetLength(0); i++)
            {
                for ( int j=0; j < twodarrayint.GetLength(1); j++)
                {
                    Console.Write(twodarrayint[i,j]+", ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
