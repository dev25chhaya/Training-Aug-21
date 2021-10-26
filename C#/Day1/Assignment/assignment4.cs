//Accept 10 student Name, Address, Hindi, English, Maths Marks ,do the total and compute Grade. 
//    Note do it with Array and display the result in grid format


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[10, 5];

            for (int i=0; i < students.GetLength(0); i++)
            {
                for (int j=0; j < students.GetLength(1); j++)
                {
                    students[i, j] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            int[] total = new int[10];

            int sum = 0;

            for(int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 2; j < students.GetLength(1); j++)
                {
                   sum+= Convert.ToInt32( students[i, j]);
                }
           
                total[i] = sum/3;
                sum = 0;
            }

            string[] grade = new string[10];

            for( int i = 0; i < total.Length; i++)
            {
                switch (total[i] / 10)
                {
                    case 10:
                    case 9:
                        grade[i] = "A";
                        break;

                    case 8:
                        grade[i] = "B";
                        break;
                    case 7:
                        grade[i] = "C";
                        break;
                    case 6:
                        grade[i] = "D";
                        break;
                    case 5:
                        grade[i] = "E";
                        break;
                    default:
                        grade[i] = "F";
                        break;
                }
                Console.WriteLine(grade[i]+",");
            }

            string[] title = new string[5] { "Name", "Add", "Hin", "Eng", "Mat" };

            for (int k = 0; k < students.GetLength(1); k++)
            {
                Console.Write("|          "+title[k] + "          |");
                
            }
            Console.WriteLine();

            for (int i = 0; i < students.GetLength(0); i++)
            {
               
               for (int j = 0; j < students.GetLength(1); j++)
                {

                    Console.Write("|          " + students[i, j] + "          |");
                }
                Console.WriteLine(grade[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
