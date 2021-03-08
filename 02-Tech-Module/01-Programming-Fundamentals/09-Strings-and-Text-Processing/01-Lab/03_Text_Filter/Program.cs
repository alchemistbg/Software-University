using System;

namespace _03_Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			String[] banWords = Console.ReadLine().Split(", ");
			String textToClear = Console.ReadLine();

			for (int i = 0; i < banWords.Length; i++)
			{
				if (textToClear.Contains(banWords[i]))
				{
					textToClear = textToClear.Replace(banWords[i], new String('*', banWords[i].Length));
				}
			}
			Console.WriteLine(textToClear);
		}
	}
}
