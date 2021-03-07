using System;

namespace _14_Magic_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			char letter1 = Console.ReadLine()[0];
			char letter2 = Console.ReadLine()[0];
			char letter3 = Console.ReadLine()[0];

			string combinations = "";

			for (char i = letter1; i <= letter2; i++)
			{
				for (char j = letter1; j <= letter2; j++)
				{
					for (char k = letter1; k <= letter2; k++)
					{
						string s1 = new string(i, 1);
						string s2 = new string(j, 1);
						string s3 = new string(k, 1);
						combinations = s1 + s2 + s3;
						if (!combinations.Contains(new string(letter3, 1)))
						{
							Console.Write(combinations);
							Console.Write(" ");
						}
					}
				}
			}
		}
	}
}
