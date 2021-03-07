using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_Cubic_Messages
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "Over!")
			{
				int length = int.Parse(Console.ReadLine());
				string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";
				Match m1 = Regex.Match(input, pattern);
				if (m1.Success)
				{
					string message = m1.Groups["2"].Value;
					if (message.Length == length)
					{
						StringBuilder sb = new StringBuilder();
						MatchCollection mc = Regex.Matches(input, @"\d+");
						foreach (Match m in mc)
						{
							sb.Append(m);
						}
						Console.Write($"{message} == ");
						for (int i = 0; i < sb.Length; i++)
						{
							int j = int.Parse(sb[i].ToString());
							if (j < message.Length)
							{
								Console.Write(message[j]);
							}
							else
							{
								Console.Write(" ");
							}
						}
						Console.WriteLine();
					}
				}
				input = Console.ReadLine();
			}
		}
	}
}
