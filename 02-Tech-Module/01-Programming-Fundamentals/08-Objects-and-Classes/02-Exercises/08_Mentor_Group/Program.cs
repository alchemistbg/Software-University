using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08_Mentor_Group
{
	class Program
	{

		static void Main(string[] args)
		{
			Dictionary<string, Student> group = new Dictionary<string, Student>();

			string inputDates = Console.ReadLine();
			while (inputDates != "end of dates")
			{
				string[] s = inputDates.Split(new char[] { ' ', ',' });
				string studentName = s[0];
				if (!group.ContainsKey(studentName))
				{
					group.Add(studentName, new Student());
				}

				for (int i = 1; i < s.Length; i++)
				{
					group[studentName].AttDates.Add(DateTime.ParseExact(s[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
				}

				inputDates = Console.ReadLine();
			}

			string inputComments = Console.ReadLine();
			while (inputComments != "end of comments")
			{
				string[] s = inputComments.Split('-');
				string studentName = s[0];
				string comment = s[1];
				if (group.ContainsKey(studentName))
				{
					group[studentName].Comments.Add(comment);
				}
				inputComments = Console.ReadLine();
			}

			foreach (var stu in group.OrderBy(x => x.Key))
			{
				Console.WriteLine(stu.Key);
				Console.WriteLine("Comments:");
				foreach (string comment in stu.Value.Comments)
				{
					Console.WriteLine($"- {comment}");
				}

				Console.WriteLine("Dates attended:");
				foreach (DateTime attDate in stu.Value.AttDates.OrderBy(x => x.Date))
				{
					Console.WriteLine($"-- {attDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
				}
			}
		}
	}

	class Student
	{
		public List<string> Comments { get; set; }
		public List<DateTime> AttDates { get; set; }

		public Student()
		{
			this.Comments = new List<string>();
			this.AttDates = new List<DateTime>();
		}
	}
}
