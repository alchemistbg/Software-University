using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Average_Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			List<Student> studentList = new List<Student>();

			for (int i = 0; i < num; i++)
			{
				string[] inputArr = Console.ReadLine().Split(' ');
				string studentName = inputArr[0];
				double[] studentGrades = new double[inputArr.Length - 1];
				for (int k = 0; k < studentGrades.Length; k++)
				{
					studentGrades[k] = double.Parse(inputArr[k + 1]);
				}

				Student student = new Student(studentName, studentGrades);
				studentList.Add(student);
			}

			foreach (Student item in studentList.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
			{
				Console.WriteLine($"{item.Name} -> {item.Average:f2}");
			}
		}
	}

	class Student
	{
		public string Name { get; set; }
		public double[] Grades { get; set; }
		public double Average { get; }

		public Student(string name, double[] grades)
		{
			this.Name = name;
			this.Grades = grades;
			Average = Grades.Average();
		}
	}
}
