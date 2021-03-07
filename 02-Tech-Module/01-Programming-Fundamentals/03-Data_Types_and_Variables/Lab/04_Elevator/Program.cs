using System;

namespace _04_Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int persons = int.Parse(Console.ReadLine());
			int elevCap = int.Parse(Console.ReadLine());

			int courses = persons / elevCap;
			int reminder = persons % elevCap;
			if (reminder > 0)
			{
				courses++;
			}
			Console.WriteLine(courses);
		}
	}
}
