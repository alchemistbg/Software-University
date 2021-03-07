using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Search_For_A_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string numString = Console.ReadLine();
			string opString = Console.ReadLine();

			List<int> numList = numString.Split(' ').Select(int.Parse).ToList();
			int[] opArray = opString.Split(' ').Select(int.Parse).ToArray();

			List<int> subNumList = numList.GetRange(0, opArray[0]);
			subNumList.RemoveRange(0, opArray[1]);
			if (subNumList.Contains(opArray[2]))
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}
		}
	}
}
