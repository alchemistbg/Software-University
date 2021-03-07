using System;

namespace _06_Triples_Of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			for (int i = 97; i < 97 + num; i++)
			{
				for (int j = 97; j < 97 + num; j++)
				{
					for (int k = 97; k < 97 + num; k++)
					{
						Console.WriteLine("" + (char)i + (char)j + (char)k);
					}
				}
			}

			//for (char ch1 = 'a'; ch1 <= 96 + num; ch1++)
			//{
			//	for (char ch2 = 'a'; ch2 <= 96 + num; ch2++)
			//	{
			//		for (char ch3 = 'a'; ch3 <= 96 + num; ch3++)
			//		{
			//			Console.WriteLine("" + ch1 + ch2 + ch3);
			//		}
			//	}
			//}
		}
	}
}
