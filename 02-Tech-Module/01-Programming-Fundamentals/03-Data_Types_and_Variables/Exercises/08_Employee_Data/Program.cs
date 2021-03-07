using System;

namespace _08_Employee_Data
{
	class Program
	{
		static void Main(string[] args)
		{
			string fName = Console.ReadLine();
			string lName = Console.ReadLine();
			byte age = byte.Parse(Console.ReadLine());
			char sex = char.Parse(Console.ReadLine());
			long pID = long.Parse(Console.ReadLine());
			int eID = int.Parse(Console.ReadLine());

			Console.WriteLine($"First name: {fName}");
			Console.WriteLine($"Last name: {lName}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Gender: {sex}");
			Console.WriteLine($"Personal ID: {pID}");
			Console.WriteLine($"Unique Employee number: {eID}");
		}
	}
}
