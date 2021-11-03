using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 19123123, 0, 75, 25 };

            try
            {
                for( int i=0; i < arr.Length; i++)
                {
                    
                    
                    Console.WriteLine(arr[i] / arr[i + 1]);

                    
                }

            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An Excaption has occured :"+e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine("An Excaption has ocuured :"+e.Message);
            }

            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("An excaption has occured :" + e.Message);
            }

            finally
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" "+arr[i]);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
