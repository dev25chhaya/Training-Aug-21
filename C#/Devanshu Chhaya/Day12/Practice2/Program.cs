using System;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //var std = new Student()
                //{

                //    Name = "Bill"
                //};

                //var c = new Course()
                //{
                //    CourseName = ".NET"
                //};

                //context.Courses.Add(c);
                //context.Students.Add(std);
                //context.SaveChanges();

                //var courses = from Course in context.Courses
                //              select Course;

                //var students = from Student in context.Students
                //               select Student;

                //foreach(Course c in courses)
                //{
                //    Console.WriteLine($"CourseId: {c.CourseId}");
                //    Console.WriteLine($"CourseName: {c.CourseName}");
                //}

                //foreach(Student s in students)
                //{
                //    Console.WriteLine($"StudentId: {s.StudentId}");
                //    Console.WriteLine($"StudentName: {s.Name}");
                //}

                var nameofCourse = context.Courses
                            .Where(p => p.CourseName == ".NET")
                            .FirstOrDefault();    
                if(nameofCourse is Course)
                {
                    nameofCourse.CourseName="DotNet";
                }
                context.SaveChanges();

                var courses = from Course in context.Courses
                              select Course;

                foreach (Course c in courses)
                {
                    Console.WriteLine($"CourseId: {c.CourseId}");
                    Console.WriteLine($"CourseName: {c.CourseName}");
                }

            }
        }
    }
}
