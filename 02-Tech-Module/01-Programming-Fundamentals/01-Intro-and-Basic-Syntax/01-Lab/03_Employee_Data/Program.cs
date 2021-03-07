using System;

namespace _03_Employee_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			int employeeID = int.Parse(Console.ReadLine());
			double salary = double.Parse(Console.ReadLine());

			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Age: {0}", age);
			Console.WriteLine("Employee ID: {0}", employeeID.ToString("D8"));
			Console.WriteLine("Salary: {0}", salary.ToString("f2"));
		}
	}
}
