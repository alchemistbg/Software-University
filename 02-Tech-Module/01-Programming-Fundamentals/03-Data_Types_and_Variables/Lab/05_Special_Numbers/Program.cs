using System;

namespace _05_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				char[] chArr = i.ToString().ToCharArray();

				int sum = 0;
				for (int k = 0; k < chArr.Length; k++)
				{
					sum += int.Parse(chArr[k].ToString());
				}
				if (sum == 5 || sum == 7 || sum == 11)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");
				}
			}
		}
	}
}
