using System;

namespace _04_Numbers_In_Reversed_Order
{
	class Program
	{
		static void Main(string[] args)
		{
			String number = Console.ReadLine();
			printReverseNumber_1(number);
			//printReverseNumber_2(number);
		}

		static void printReverseNumber_1(String s)
		{
			char[] ch = s.ToCharArray();
			Array.Reverse(ch);
			Console.WriteLine(ch);
		}

		static void printReverseNumber_2(String s)
		{
			for (int i = s.Length; i > 0; i--)
			{
				Console.Write(s[i - 1]);
			}
			Console.WriteLine();
		}
	}
}
