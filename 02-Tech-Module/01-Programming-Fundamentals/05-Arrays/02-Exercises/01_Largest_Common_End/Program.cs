using System;

namespace _01_Largest_Common_End
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] str1 = Console.ReadLine().Split(' ');
			string[] str2 = Console.ReadLine().Split(' ');

			int commonEndSize;
			if (str1.Length <= str2.Length)
			{
				commonEndSize = commndEndFinder(str1, str2);
			}
			else
			{
				commonEndSize = commndEndFinder(str2, str1);
			}
			Console.WriteLine(commonEndSize);
		}

		static int commndEndFinder(string[] s1, string[] s2)
		{
			int commonEndLeftToRight = 0;
			for (int i = 0; i < s1.Length; i++)
			{
				if (s1[i] == s2[i])
				{
					commonEndLeftToRight++;
				}
			}

			int commonEndRightToLeft = 0;
			for (int i = s1.Length - 1; i >= 0; i--)
			{
				if (s1[i] == s2[i + (s2.Length - s1.Length)])
				{
					commonEndRightToLeft++;
				}
			}

			if (commonEndLeftToRight >= commonEndRightToLeft)
			{
				return commonEndLeftToRight;
			}
			else
			{
				return commonEndRightToLeft;
			}
		}
	}
}
