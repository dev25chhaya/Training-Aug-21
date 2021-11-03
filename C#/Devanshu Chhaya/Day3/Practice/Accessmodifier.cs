using System;

namespace accessmodifier
{
    // Public 
    class Student
    {

        public int rollNo;
        public string name;

        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }

    // Protected
    class X
    {

        protected int x;

        public X()
        {
            x = 10;
        }
    }
    class Y : X
    {
        public int getX()
        {
            return x;
        }
    }

    //internal
    internal class Complex
    {

        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {

            Student S = new Student(1, "Astrid");


            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);

            Console.WriteLine();


            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());


            X obj1 = new X();
            Y obj2 = new Y();

            Console.WriteLine("Value of x is : {0}", obj2.getX());

            Complex c = new Complex();


            c.setData(2, 1);
            c.displayData();
            Console.ReadLine();
        }
    }
}

