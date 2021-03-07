using System;

namespace _02_Count_Substring_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			String input = Console.ReadLine().ToLower();
			String pattern = Console.ReadLine().ToLower();

			int countOccurencies = 0;
			int index = 0;

			while (true)
			{
				index = input.IndexOf(pattern, index);
				if (index >= 0)
				{
					countOccurencies++;
					index++;
				}
				else
				{
					break;
				}
			}

			Console.WriteLine(countOccurencies);
		}
	}
}
