using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Take_Skip_Rope
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] input = Console.ReadLine().ToCharArray();
			List<int> numbersList = new List<int>();
			List<char> nonNumbersList = new List<char>();
			foreach (char ch in input)
			{
				if (ch > 47 && ch < 58)
				{
					numbersList.Add(int.Parse(ch.ToString()));
				}
				else
				{
					nonNumbersList.Add(ch);
				}
			}
			String s = String.Join("", nonNumbersList);

			List<int> takeList = new List<int>();
			List<int> skipList = new List<int>();
			for (int i = 0; i < numbersList.Count; i++)
			{
				if (i % 2 == 0)
				{
					takeList.Add(numbersList[i]);
				}
				else
				{
					skipList.Add(numbersList[i]);
				}
			}

			StringBuilder sb = new StringBuilder();
			int totalSkips = 0;
			for (int i = 0; i < takeList.Count; i++)
			{
				String temp = String.Empty;
				if (totalSkips + takeList[i] > s.Length)
				{

					temp = s.Substring(totalSkips, (s.Length - totalSkips));
				}
				else
				{
					temp = s.Substring(totalSkips, takeList[i]);
				}
				sb.Append(temp);
				totalSkips += takeList[i];
				totalSkips += skipList[i];
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
