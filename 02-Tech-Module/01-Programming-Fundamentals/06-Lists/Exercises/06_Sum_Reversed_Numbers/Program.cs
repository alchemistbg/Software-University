using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Sum_Reversed_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string strList = Console.ReadLine();
			List<int> numList = strList.Split(' ').Select(int.Parse).ToList();
			for (int i = 0; i < numList.Count; i++)
			{
				char[] chArr = numList.ElementAt(i).ToString().ToCharArray();
				Array.Reverse(chArr);
				numList[i] = int.Parse(string.Join("", chArr));
			}
			Console.WriteLine(numList.Sum());
		}
	}
}
