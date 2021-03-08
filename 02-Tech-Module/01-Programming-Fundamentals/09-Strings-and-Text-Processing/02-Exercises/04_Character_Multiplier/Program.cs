using System;

namespace _04_Character_Multiplier
{
	class Program
	{
		static int sum = 0;
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string s1 = input.Split(' ')[0];
			string s2 = input.Split(' ')[1];

			if (s1.Length > s2.Length)
			{
				Console.WriteLine(unEqualsStringMultuplier(s2, s1));
			}
			else if (s1.Length < s2.Length)
			{
				Console.WriteLine(unEqualsStringMultuplier(s1, s2));
			}
			else
			{
				Console.WriteLine(equalsStringMultuplier(s1, s2));
			}
		}

		public static int equalsStringMultuplier(string s1, string s2)
		{
			for (int i = 0; i < s1.Length; i++)
			{
				sum += (int)s1[i] * (int)s2[i];
			}
			return sum;
		}

		public static int unEqualsStringMultuplier(string Shorter, string Longer)
		{
			for (int i = 0; i < Shorter.Length; i++)
			{
				sum += (int)Shorter[i] * (int)Longer[i];
			}

			for (int i = Shorter.Length; i < Longer.Length; i++)
			{
				sum += (int)Longer[i];
			}

			return sum;
		}
	}
}
