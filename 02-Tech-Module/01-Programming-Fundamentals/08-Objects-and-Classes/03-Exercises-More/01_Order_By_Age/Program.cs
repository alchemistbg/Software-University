using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Order_By_Age
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Person> personDB = new Dictionary<string, Person>();

			string input = Console.ReadLine();
			while (input != "End")
			{
				string[] inputArr = input.Split(' ');

				if (!personDB.ContainsKey(inputArr[1]))
				{

					personDB.Add(inputArr[1], new Person());
				}
				personDB[inputArr[1]].Name = inputArr[0];
				personDB[inputArr[1]].Age = int.Parse(inputArr[2]);

				input = Console.ReadLine();
			}

			foreach (var man in personDB.OrderBy(x => x.Value.Age))
			{
				Console.WriteLine($"{man.Value.Name} with ID: {man.Key} is {man.Value.Age} years old.");
			}
		}
	}

	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person()
		{
			this.Name = string.Empty;
			//this.Age = 0;
		}
	}
}
