using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //------ FIltering Operator: Where ------//

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //var ages = from s in studentList
            //           where s.Age > 12 && s.Age < 20
            //           select s;

            //foreach(Student s in ages)
            //{
            //    Console.WriteLine(s.StudentID+"||"+s.StudentName);
            //}

            //Console.WriteLine();

            //var ages2 = studentList.Where(s => s.Age > 12 && s.Age < 20);

            //foreach (Student s in ages)
            //{
            //    Console.WriteLine(s.StudentID + "||" + s.StudentName);
            //}

            //--- OfTypes----//

            //IList mixedList = new ArrayList();
            //mixedList.Add(0);
            //mixedList.Add("One");
            //mixedList.Add("Two");
            //mixedList.Add(3);
            //mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            //var stringResult = from s in mixedList.OfType<string>()
            //                   select s;

            //foreach (var str in stringResult)
            //    Console.WriteLine(str);

            //var intResult = from s in mixedList.OfType<int>()
            //                select s;

            //foreach (var integer in intResult)
            //    Console.WriteLine(integer);

            //var stdResult = from s in mixedList.OfType<Student>()
            //                select s;

            //foreach (var std in stdResult)
            //    Console.WriteLine(std.StudentName);

            //var stringResult2 = mixedList.OfType<string>();

            //foreach (var str in stringResult2)
            //{
            //    Console.WriteLine(str);
            //}


            //----- OrderBy -----//

            //var orderByResult = from s in studentList
            //                    orderby s.StudentName //Sorts the studentList collection in ascending order
            //                    select s;

            //var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
            //                              orderby s.StudentName descending
            //                              select s;
            //Console.WriteLine("Ascending Order:");

            //foreach (var std in orderByResult)
            //    Console.WriteLine(std.StudentName);

            //Console.WriteLine("Descending Order:");

            //foreach (var std in orderByDescendingResult)
            //    Console.WriteLine(std.StudentName);

            //var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            //var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


            //Console.WriteLine("Ascending Order:");

            //foreach (var std in studentsInAscOrder)
            //    Console.WriteLine(std.StudentName);

            //Console.WriteLine("Descending Order:");

            //foreach (var std in studentsInDescOrder)
            //    Console.WriteLine(std.StudentName);


            // ----- group by ---- //

            //var groupedResult = from s in studentList
            //                    group s by s.Age;

            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            //    foreach (Student s in ageGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //var groupedResult2 = studentList.GroupBy(s => s.Age);

            //foreach (var ageGroup in groupedResult2)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

            //    foreach (Student s in ageGroup)  //Each group has a inner collection  
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //var lookupResult = studentList.ToLookup(s => s.Age);

            //foreach (var group in lookupResult)
            //{
            //    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

            //    foreach (Student s in group)  //Each group has a inner collection  
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}


            Console.ReadLine();
        }
    }
}
