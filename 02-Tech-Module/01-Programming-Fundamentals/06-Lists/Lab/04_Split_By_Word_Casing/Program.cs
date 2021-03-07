using System;
using System.Collections.Generic;

namespace _04_Split_By_Word_Casing
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().
				Split(",;:.!()\"\'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

			List<string> upperCase = new List<string>();
			List<string> lowerCase = new List<string>();
			List<string> mixedCase = new List<string>();

			foreach (string word in words)
			{
				if (isUpperWord(word))
				{
					upperCase.Add(word);
				}
				else if (isLowerWord(word))
				{
					lowerCase.Add(word);
				}
				else
				{
					mixedCase.Add(word);
				}
			}

			Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
			Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
			Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

		}

		static bool isLowerWord(string word)
		{
			foreach (char symbol in word)
			{
				if (symbol < 'a' || symbol > 'z')
				{
					return false;
				}
			}
			return true;
		}

		static bool isUpperWord(string word)
		{
			foreach (char symbol in word)
			{
				if (symbol < 'A' || symbol > 'Z')
				{
					return false;
				}
			}
			return true;
		}
	}
}
