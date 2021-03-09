using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Camera_View
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solution without regex
			//int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			//int skips = numbers[0];
			//int taken = numbers[1];
			//string[] input = Console.ReadLine().Split("|<");

			//List<string> result = new List<string>();

			//for (int i = 1; i < input.Length; i++)
			//{
			//	if (input[i].Length >= skips + taken)
			//	{
			//		result.Add(input[i].Substring(skips, taken));
			//	}
			//	else
			//	{
			//		result.Add(input[i].Substring(skips));
			//	}
			//}

			//Console.WriteLine(string.Join(", ", result));

			//solution with regex
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int skips = numbers[0];
			int taken = numbers[1];
			string input = Console.ReadLine();
			string pattern = @"\|<([\w]{" + skips + @"})([\w]{0," + taken + "})";

			MatchCollection matches = Regex.Matches(input, pattern);

			List<string> list = new List<string>();
			foreach (Match m in matches)
			{
				list.Add(m.Groups[2].Value);
			}

			Console.WriteLine(string.Join(", ", list));
		}
	}
}
