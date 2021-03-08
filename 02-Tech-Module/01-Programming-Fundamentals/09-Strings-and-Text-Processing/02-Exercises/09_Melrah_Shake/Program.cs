using System;

namespace _09_Melrah_Shake
{
	class Program
	{
		static void Main(string[] args)
		{
			string textToShake = Console.ReadLine();//.ToLower();
			string pattern = Console.ReadLine();//.ToLower();
												//Console.WriteLine(textToShake + ": " + pattern);

			while (true)
			{
				if (pattern.Length > 0 && textToShake.IndexOf(pattern) != textToShake.LastIndexOf(pattern))
				{
					//Console.WriteLine(pattern);
					textToShake = textToShake.Remove(textToShake.IndexOf(pattern), pattern.Length);
					textToShake = textToShake.Remove(textToShake.LastIndexOf(pattern), pattern.Length);
					pattern = pattern.Remove(pattern.Length / 2, 1);
					//Console.WriteLine(pattern);
					Console.WriteLine("Shaked it.");
					//Console.WriteLine(pattern);
				}
				else
				{
					Console.WriteLine("No shake.");
					Console.WriteLine(textToShake);
					break;
				}
			}

		}
	}
}
