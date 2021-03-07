using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Multiply_Big_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string n1 = Console.ReadLine();
			n1 = n1.Trim('0');
			string n2 = Console.ReadLine();
			n2 = n2.Trim('0');

			if (n2.Length == 0)
			{
				Console.WriteLine("0");
			}
			else
			{
				multiply(n1, n2);
			}
		}

		static void multiply(string s1, string s2)
		{
			int[] i1 = s1.Select(x => int.Parse(x.ToString())).ToArray();
			int i2 = int.Parse(s2);

			List<int> result = new List<int>();
			int naum = 0;

			for (int i = i1.Length - 1; i >= 0; i--)
			{
				int temp = i1[i] * i2 + naum;
				result.Add(temp % 10);
				if (temp > 9)
				{
					naum = temp / 10;
				}
				else
				{
					naum = 0;
				}
			}
			if (naum > 0)
			{
				result.Add(naum);
			}
			result.Reverse();
			Console.WriteLine(string.Join("", result));
		}
	}
}
