using System;
using System.Collections.Generic;

namespace _04_Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> palindromes = new List<string>();

			String[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string word in input)
			{
				if (isPalindrome(word) && !palindromes.Contains(word))
				{
					palindromes.Add(word);
				}
			}

			palindromes.Sort();

			Console.WriteLine(string.Join(", ", palindromes));
		}

		public static bool isPalindrome(string s)
		{
			bool palindrome = false;
			if (s == reverseString(s))
			{
				palindrome = true;
			}
			return palindrome;
		}

		public static String reverseString(string s)
		{
			char[] chArray = s.ToCharArray();
			Array.Reverse(chArray);
			return string.Join("", chArray);
		}
	}
}
