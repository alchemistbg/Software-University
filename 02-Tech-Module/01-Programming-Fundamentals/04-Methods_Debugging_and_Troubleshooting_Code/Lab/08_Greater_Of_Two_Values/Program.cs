using System;

namespace _08_Greater_Of_Two_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();

			if (type.Equals("int"))
			{
				int i1 = int.Parse(Console.ReadLine());
				int i2 = int.Parse(Console.ReadLine());
				Console.WriteLine(getMax(i1, i2));
			}
			else if (type.Equals("char"))
			{
				char ch1 = char.Parse(Console.ReadLine());
				char ch2 = char.Parse(Console.ReadLine());
				Console.WriteLine(getMax(ch1, ch2));
			}
			else if (type.Equals("string"))
			{
				string s1 = Console.ReadLine();
				string s2 = Console.ReadLine();
				Console.WriteLine(getMax(s1, s2));
			}
		}

		static int getMax(int i1, int i2)
		{
			return Math.Max(i1, i2);
		}
		static char getMax(char ch1, char ch2)
		{
			if (ch1 >= ch2)
			{
				return ch1;
			}
			else
			{
				return ch2;
			}

		}
		static string getMax(string s1, string s2)
		{
			if (s1.CompareTo(s2) >= 0)
			{
				return s1;
			}
			else
			{
				return s2;
			}
		}
	}
}
