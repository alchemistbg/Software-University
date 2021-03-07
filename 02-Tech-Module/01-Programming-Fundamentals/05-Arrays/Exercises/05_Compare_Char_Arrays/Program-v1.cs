using System;
using System.Linq;

namespace _05_Compare_Char_Arrays
{
	class Program_v1
	{
		//static void Main(string[] args)
		//{
		//	char[] word1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
		//	char[] word2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

		//	int iter = Math.Min(word1.Length, word2.Length);
		//	bool isFirst = false;

		//	for (int i = 0; i < iter; i++)
		//	{
		//		if (word1[i] < word2[i])
		//		{
		//			isFirst = true;
		//			break;
		//		}
		//		else if (word1[i] > word2[i])
		//		{
		//			isFirst = false;
		//			break;
		//		}

		//		if (i == iter - 1)
		//		{
		//			if (word1.Length < word2.Length)
		//			{
		//				isFirst = true;
		//			}
		//			else
		//			{
		//				isFirst = false;
		//			}
		//		}
		//	}

		//	if (isFirst)
		//	{
		//		Console.WriteLine(string.Join("", word1));
		//		Console.WriteLine(string.Join("", word2));
		//	}
		//	else
		//	{
		//		Console.WriteLine(string.Join("", word2));
		//		Console.WriteLine(string.Join("", word1));
		//	}
		//}
	}
}
