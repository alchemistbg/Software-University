using System;
using System.Linq;

namespace _06_Sum_Big_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//string[] input = Console.ReadLine().Split(' ');
			string n1 = Console.ReadLine();
			string n2 = Console.ReadLine();
			sum(n1, n2);
		}

		static void sum(string s1, string s2)
		{
			//Console.WriteLine(11%10);
			int length = Math.Max(s1.Length, s2.Length);
			s1 = s1.PadLeft(length + 1, '0');
			s2 = s2.PadLeft(length + 1, '0');

			int[] i1 = s1.Select(x => int.Parse(x.ToString())).ToArray();
			int[] i2 = s2.Select(x => int.Parse(x.ToString())).ToArray();

			int[] sum = new int[i1.Length];
			int naum = 0;

			for (int i = sum.Length - 1; i >= 0; i--)
			{
				int temp = i1[i] + i2[i] + naum;
				sum[i] = temp % 10;
				if (temp > 9)
				{
					naum = 1;
				}
				else
				{
					naum = 0;
				}
			}
			string sumS = string.Join("", sum);
			sumS = sumS.TrimStart('0');
			Console.WriteLine(sumS);
		}
	}
}
