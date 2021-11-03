using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letandinto
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
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 12 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            var lowercaseStudentNames = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;



            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);

            //---- into ----// 

            var teenAgerStudents = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select s
                                    into teenStudents
                                   where teenStudents.StudentName.StartsWith("B")
                                   select teenStudents;


            foreach (Student std in teenAgerStudents)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.ReadLine();
        }
    }
}

