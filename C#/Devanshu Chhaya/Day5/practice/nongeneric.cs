using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nongeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //------ arryList ------//

            ArrayList al = new ArrayList();

            string str = "Hello";
            int x = 7;
            DateTime d = DateTime.Parse("7/10/2021");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach(var o in al)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();

            //------ HashTable -----//

            Hashtable ht = new Hashtable();

            ht.Add(1, "Apple");
            ht.Add(2, "Tesla");
            ht.Add(3, "Microdoft");

            foreach(DictionaryEntry di in ht)
            {
                Console.WriteLine(di.Key+" : "+di.Value);  
            }

            //------ Stack -------//

            //Stack myStack = new Stack();

            //myStack.Push("String");
            //myStack.Push('N');
            //myStack.Push(null);
            //myStack.Push(12);
            //myStack.Push(40.25);

            //foreach ( var ele in myStack)
            //{
            //    Console.WriteLine(ele);
            //}

            //myStack.Pop();

            //Console.WriteLine();
            //foreach (var ele in myStack)
            //{
            //    Console.WriteLine(ele);
            //}

            //Console.WriteLine(myStack.Count);

            //Console.WriteLine(myStack.Peek());

            //if (myStack.Contains('N') == true)
            //{
            //    Console.WriteLine("Yes");
            //}

            //---------- Queue -----------//

            Queue obj = new Queue();

            obj.Enqueue("string");
            obj.Enqueue(1);
            obj.Enqueue(2.4);

            foreach(var ele in obj)
            {
                Console.WriteLine(ele);
            }
           

            Console.ReadLine();
        }
    }
}
