using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SoftUni_Exam_Results
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Student> Exam = new Dictionary<string, Student>();
			Dictionary<string, int> Lang = new Dictionary<string, int>();
			string input = Console.ReadLine();
			while (input != "exam finished")
			{
				if (!input.Contains("-banned"))
				{
					string[] inputArr = input.Split("-");

					string Name = inputArr[0];
					string ProgLang = inputArr[1];
					int Score = int.Parse(inputArr[2]);

					if (!Exam.ContainsKey(Name))
					{
						Student student = new Student();
						student.Name = Name;
						student.ProgLang = ProgLang;
						student.Score = Score;
						Exam.Add(Name, student);
					}
					else
					{
						if (Exam[Name].Score < Score)
						{
							Exam[Name].ProgLang = ProgLang;
							Exam[Name].Score = Score;
						}
					}

					if (!Lang.ContainsKey(ProgLang))
					{
						Lang[ProgLang] = 1;
					}
					else
					{
						Lang[ProgLang]++;
					}
				}
				else
				{
					string NameToBan = input.Split("-")[0];
					if (Exam.ContainsKey(NameToBan))
					{
						Exam.Remove(NameToBan);
					}
				}


				input = Console.ReadLine();
			}

			Console.WriteLine("Results:");
			foreach (var student in Exam.OrderByDescending(x => x.Value.Score).ThenBy(x => x.Value.Name))
			{
				Console.WriteLine($"{student.Value.Name} | {student.Value.Score}");
			}
			Console.WriteLine("Submissions:");
			foreach (var lang in Lang.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{lang.Key} - {lang.Value}");
			}
		}
	}

	class Student
	{
		public string Name { get; set; }
		public string ProgLang { get; set; }
		public int Score { get; set; }
	}
}
