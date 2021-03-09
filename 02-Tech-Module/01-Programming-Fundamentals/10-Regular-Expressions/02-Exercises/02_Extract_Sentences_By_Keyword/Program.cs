using System;
using System.Text.RegularExpressions;

namespace _02_Extract_Sentences_By_Keyword
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solition without regex
			//string testWord = Console.ReadLine();
			//string[] inputArr = Console.ReadLine().Split(new char[] { '.', '!', '?'});

			//foreach (string s in inputArr)
			//{
			//	if (s.Contains(testWord+" "))
			//	{
			//		Console.WriteLine(s.Trim());
			//	}
			//}

			//Solution with regex
			string testword = Console.ReadLine();
			string[] inputArr = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
			string pattern = $@"\b{testword}\b";

			foreach (string s in inputArr)
			{
				if (Regex.IsMatch(s, pattern))
				{
					Console.WriteLine(s.Trim());
				}
			}
		}
	}
}
