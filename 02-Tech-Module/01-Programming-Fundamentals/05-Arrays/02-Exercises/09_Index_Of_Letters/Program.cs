using System;

namespace _09_Index_Of_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] letters = {
				'a', 'b', 'c', 'd', 'e', 'f', 'g',
				'h', 'i', 'j', 'k', 'l', 'm', 'n',
				'o', 'p', 'q', 'r', 's', 't', 'u',
				'v', 'w', 'x', 'y', 'z',
			};

			string queryAsText = Console.ReadLine().ToLower();
			for (int i = 0; i < queryAsText.Length; i++)
			{
				for (int k = 0; k < letters.Length; k++)
				{
					if (queryAsText[i] == letters[k])
					{
						Console.WriteLine($"{queryAsText[i]} -> {k}");
					}
				}
			}
		}
	}
}
