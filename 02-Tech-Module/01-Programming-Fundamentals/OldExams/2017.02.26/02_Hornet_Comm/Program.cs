using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Hornet_Comm
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> privates = new List<string>();
			List<string> broadcasts = new List<string>();
			string input = Console.ReadLine();

			while (input != "Hornet is Green")
			{
				string pmPatern = @"^(?<firstQuery>\d+) <-> (?<secondQuery>[A-Za-z0-9]+)$";
				Match mPM = Regex.Match(input, pmPatern);
				if (mPM.Success)
				{
					string fQuery = string.Join("", mPM.Groups["firstQuery"].Value.Reverse());
					string sQuery = mPM.Groups["secondQuery"].Value;
					string pm = fQuery + " -> " + sQuery;
					privates.Add(pm);
				}

				string bcPattern = @"^(?<firstQuery>[^\d]+) <-> (?<secondQuery>[A-Za-z0-9]+)$";
				Match mBC = Regex.Match(input, bcPattern);
				if (mBC.Success)
				{
					string fQuery = mBC.Groups["firstQuery"].Value;
					char[] sQueryArr = mBC.Groups["secondQuery"].Value.ToArray();
					for (int i = 0; i < sQueryArr.Length; i++)
					{
						if (Char.IsLetter(sQueryArr[i]) && Char.IsLower(sQueryArr[i]))
						{
							sQueryArr[i] = Char.ToUpper(sQueryArr[i]);
						}
						else if (Char.IsLetter(sQueryArr[i]) && Char.IsUpper(sQueryArr[i]))
						{
							sQueryArr[i] = Char.ToLower(sQueryArr[i]);
						}
					}
					string sQuery = string.Join("", sQueryArr);
					string bc = sQuery + " -> " + fQuery;
					broadcasts.Add(bc);
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("Broadcasts:");
			if (broadcasts.Count == 0)
			{
				Console.WriteLine("None");
			}
			else
			{
				foreach (string bc in broadcasts)
				{
					Console.WriteLine(bc);
				}
			}

			Console.WriteLine("Messages:");
			if (privates.Count == 0)
			{
				Console.WriteLine("None");
			}
			else
			{
				foreach (string pm in privates)
				{
					Console.WriteLine(pm);
				}
			}
		}
	}
}
