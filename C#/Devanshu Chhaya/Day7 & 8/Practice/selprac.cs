using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selprac
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
			//------ select ------//

			IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
			new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};

			var selectResult = from s in studentList
							   select s.StudentName;

			foreach (var name in selectResult)
			{
				Console.WriteLine(name);
			}

			var selectResult2 = studentList.Select(s => new {
				Name = s.StudentName,
				Id = s.StudentID
			});
			foreach (var name in selectResult2)
			{
				Console.WriteLine(name);
			}

			//---- all/any -----//

			bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
			Console.WriteLine(areAllStudentsTeenAger);

			bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
			Console.WriteLine(isAnyStudentTeenAger);


			//----- Aggregate ------//

			IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

			var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

			Console.WriteLine(commaSeperatedString);

			//----- Average ------//

			var avgAge = studentList.Average(s => s.Age);

			Console.WriteLine("Average Age of Student: {0}", avgAge);

			//----- count ------//

			var totalStudents = studentList.Count();

			Console.WriteLine("Total Students: {0}", totalStudents);

			var adultStudents = studentList.Count(s => s.Age >= 18);

			Console.WriteLine("Number of Adult Students: {0}", adultStudents);

			// ----- single or default ------//

			IList<int> oneElementList = new List<int>() { 7 };
			IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
			IList<string> strList2 = new List<string>() { null, "Two", "Three", "Four", "Five" };
			IList<string> emptyList = new List<string>();

			Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
			Console.WriteLine("The only element in oneElementList: {0}",
						 oneElementList.SingleOrDefault());

			Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

			Console.WriteLine("The only element which is less than 10 in intList: {0}",
						 intList.Single(i => i < 10));

			//----- Intersect -----//

			IList<Student> studentList1 = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
			new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};

			IList<Student> studentList2 = new List<Student>() {
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } ,
				new Student() { StudentID = 6, StudentName = "Ram" , Age = 29 }
			};

			var resultedCol = studentList1.Intersect(studentList2, new StudentComparer());

			foreach (Student std in resultedCol)
				Console.WriteLine(std.StudentName);

			//----- union ------//

			var result = studentList1.Union(studentList2, new StudentComparer2());

			foreach (var std in result)
				Console.WriteLine(std.StudentName);


			Console.ReadLine();

		}
	}

	public class StudentComparer : IEqualityComparer<Student>
	{
		public bool Equals(Student x, Student y)
		{
			if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
				return true;

			return false;
		}

		public int GetHashCode(Student obj)
		{
			return obj.StudentID.GetHashCode();
		}
	}

	public class StudentComparer2 : IEqualityComparer<Student>
	{
		public bool Equals(Student x, Student y)
		{
			if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
				return true;

			return false;
		}

		public int GetHashCode(Student obj)
		{
			return obj.StudentID.GetHashCode();
		}
	}

}
