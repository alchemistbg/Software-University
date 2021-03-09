using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06_Valid_Usernames
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> validUserNames = new List<string>();

			string input = Console.ReadLine();
			string[] inputArr = input.Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

			string UserNamePattern = @"\b[A-Za-z](\w{2,24}\b)";
			Regex regex = new Regex(UserNamePattern);
			foreach (string UserName in inputArr)
			{
				if (regex.IsMatch(UserName))
				{
					validUserNames.Add(UserName);
				}
			}

			int pairIndex1 = 0;
			int pairIndex2 = 1;
			int biggestSum = int.MinValue;
			for (int i = 0; i < validUserNames.Count - 1; i++)
			{
				int currSum = int.MinValue;
				currSum = validUserNames[i].Length + validUserNames[i + 1].Length;
				if (currSum > biggestSum)
				{
					biggestSum = currSum;
					pairIndex1 = i;
					pairIndex2 = i + 1;
				}
			}

			Console.WriteLine(validUserNames[pairIndex1]);
			Console.WriteLine(validUserNames[pairIndex2]);
		}
	}
}
