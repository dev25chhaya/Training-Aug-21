
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list which will store 5 student names and then display it search it index number

            List<string> name = new List<string>();

            name.Add("Ajay");
            name.Add("Milan");
            name.Add("Nilay");
            name.Add("Dinesh");
            name.Add("Mayur");

            foreach ( string stu in name)
            {
                Console.Write(name.IndexOf(stu));
                Console.WriteLine(" : " + stu);

            }
            Console.WriteLine();
            //2. Create a stack which will store Age of person and display it last in first out order.

            Stack<int> age = new Stack<int>();
            age.Push(22);
            age.Push(25);
            age.Push(8);

            foreach(int a in age)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            //3. Store a product information in map object. Key will be a product item and value will be the price of that product. 
            //Search the product by product name.

            Dictionary<string, float> pro = new Dictionary<string, float>()
            { {"Ipad",399},{"iPhone",799},{"MacBook",1499} };

            foreach(KeyValuePair<string,float> item in pro)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }

            if (pro.ContainsKey("iPhone") == true)
            {
                Console.WriteLine("Yes this is product is available");
            }
            Console.ReadLine();
        }
    }
}
