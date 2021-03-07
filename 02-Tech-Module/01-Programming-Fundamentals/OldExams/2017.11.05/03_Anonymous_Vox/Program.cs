using System;

namespace _03_Anonymous_Vox
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"(?<start>[A-Za-z]+)(?<placeholder>.+)(?<end>\k<start>)";
			Regex regex = new Regex(pattern);
			MatchCollection mc = regex.Matches(input);

			string[] values = Console.ReadLine().Split(new char[] { '{', '}', }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < Math.Min(mc.Count, values.Length); i++)
			{
				string temp = mc[i].Value;
				temp = regex.Replace(temp, "${start}" + values[i] + "${end}");
				input = input.Replace(mc[i].Value, temp);
			}

			Console.WriteLine(input);
		}
	}
}
