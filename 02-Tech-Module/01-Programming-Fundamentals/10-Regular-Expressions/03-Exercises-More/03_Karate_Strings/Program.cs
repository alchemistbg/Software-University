using System;

namespace _03_Karate_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> tokens = Console.ReadLine().Split(">").ToList();

			int reminder = 0;
			for (int i = 1; i < tokens.Count; i++)
			{
				int stringLength = tokens[i].Length;
				int charsToRemove = int.Parse(tokens[i][0].ToString());

				if (charsToRemove + reminder <= stringLength)
				{
					tokens[i] = tokens[i].Remove(0, charsToRemove + reminder);
				}
				else
				{
					reminder += charsToRemove - stringLength;
					tokens[i] = tokens[i].Remove(0, stringLength);
				}
			}

			Console.WriteLine(string.Join(">", tokens));
		}
	}
}
