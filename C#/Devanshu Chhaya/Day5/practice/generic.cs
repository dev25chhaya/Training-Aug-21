using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> firstList = new List<int>();

            //firstList.Add(11);
            //firstList.Add(12);
            //firstList.Add(13);
            //firstList.Add(14);

            //Console.WriteLine(firstList.Capacity);
            //Console.WriteLine(firstList.Count);

            //firstList.Add(15);
            //firstList.Add(16);

            //Console.WriteLine(firstList.Capacity);
            //Console.WriteLine(firstList.Contains(15));
            //foreach ( int i in firstList)
            //{
            //    Console.WriteLine(i);
            //}

            //firstList.RemoveAt(3);
            //Console.WriteLine();

            //foreach (int i in firstList)
            //{
            //    Console.WriteLine(i);
            //}


            //List<int> newList = new List<int> { 22, 37, 15, 18, 21 };

            //Console.WriteLine("before");
            //foreach( int i in newList)
            //{
            //    Console.WriteLine(i);
            //}

            //newList.Sort();
            //Console.WriteLine("After sort: ");

            //Stack<string> one = new Stack<string>();

            //one.Push("Apple");
            //one.Push("Microsoft");
            //one.Push("Google");
            //one.Push("Tesla");

            //foreach(string name in one)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine(one.Pop());
            //Console.WriteLine();
            //foreach (string name in one)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine();

            //Console.WriteLine(one.Peek());
            //Console.WriteLine();

            //Console.WriteLine(one.Pop());
            //Console.WriteLine();
            //foreach (string name in one)
            //{
            //    Console.WriteLine(name);
            //}

            //Stack<string> copy = new Stack<string>(one.ToArray());
            //Console.WriteLine();
            //foreach (string name in one)
            //{
            //    Console.WriteLine(name);
            //}

            //------ Queue-------//

            //Queue<int> myqueue = new Queue<int>();

            //myqueue.Enqueue(10);
            //myqueue.Enqueue(25);
            //myqueue.Enqueue(5);
            //myqueue.Enqueue(20);

            //foreach(int ele in myqueue)
            //{
            //    Console.WriteLine(ele);
            //}
            //Console.WriteLine();

            //Console.WriteLine(myqueue.Dequeue());
            //Console.WriteLine();
            //Console.WriteLine(myqueue.Peek());

            //int[] intarr = myqueue.ToArray();

            //Console.WriteLine();
            //foreach(int ele in intarr)
            //{
            //    Console.WriteLine(ele);
            //}

            //------Dictionary-------//

            Dictionary<int, string> mydict = new Dictionary<int, string>();

            mydict.Add(1001, "Dev");
            mydict.Add(1002, "Milan");
            mydict.Add(1003, "Mayur");

            foreach(KeyValuePair<int,string> ele in mydict)
            {
                Console.WriteLine(ele.Key+" : "+ele.Value);
            }

            mydict.Remove(1003);

            Console.WriteLine();
            foreach (KeyValuePair<int, string> ele in mydict)
            {
                Console.WriteLine(ele.Key + " : " + ele.Value);
            }

            if (mydict.ContainsKey(1003) == true)
            {
                Console.WriteLine("Key is found");
            }

            else
            {
                Console.WriteLine("Key is not found");
            }

            if (mydict.ContainsValue("Milan") == true)
            {
                Console.WriteLine("value is found");
            }

            else
            {
                Console.WriteLine("Value is not found");
            }
            Console.ReadKey();
        }
    }
}
