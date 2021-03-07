using System;

namespace _02_Append_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string[] tokens = s.Split('|');

			string whatToPrint = "";

			for (int i = tokens.Length - 1; i >= 0; i--)
			{
				List<int> list = tokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
				whatToPrint += string.Join(" ", list) + " ";
			}

			Console.WriteLine(whatToPrint);
		}
	}
}
