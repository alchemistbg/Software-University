using System;

namespace _01_SoftUni_Reception
{
	class Program
	{
		static void Main(string[] args)
		{
			int emp1cap = int.Parse(Console.ReadLine());
			int emp2cap = int.Parse(Console.ReadLine());
			int emp3cap = int.Parse(Console.ReadLine());
			int totCap = emp1cap + emp2cap + emp3cap;

			int totStudents = int.Parse(Console.ReadLine());

			int answerHours = 0;
			while (totStudents > 0)
			{
				answerHours++;
				if (answerHours % 4 == 0)
				{
					continue;
				}
				else
				{
					totStudents -= totCap;
				}
			}

			Console.WriteLine($"Time needed: {answerHours}h.");
		}
	}
}
