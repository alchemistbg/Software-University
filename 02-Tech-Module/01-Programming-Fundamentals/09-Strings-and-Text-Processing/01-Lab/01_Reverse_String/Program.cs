using System;

namespace _01_Reverse_String
{
	class Program
	{
		static void Main(string[] args)
		{
			String input = Console.ReadLine();
			Console.WriteLine(reverseString(input));
		}

		public static String reverseString(String s)
		{
			char[] stringToCharArray = s.ToCharArray();
			char[] reversedCharArray = new char[stringToCharArray.Length];
			for (int i = 0; i <= stringToCharArray.Length - 1; i++)
			{
				reversedCharArray[stringToCharArray.Length - i - 1] = stringToCharArray[i];
			}
			return String.Join("", reversedCharArray);
		}
	}
}
