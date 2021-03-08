using System;
using System.Collections.Generic;

namespace _06_User_Logs
{
	class Program
	{
		static SortedDictionary<String, Dictionary<String, int>> log =
								new SortedDictionary<string, Dictionary<String, int>>();
		static void Main(String[] args)
		{
			String logRecord = Console.ReadLine();

			while (!logRecord.Equals("end"))
			{
				logParser(logRecord);
				logRecord = Console.ReadLine();
			}
			printer();
		}

		private static void logParser(String logRecord)
		{
			String[] tokens = logRecord.Split(new char[] { '=', ' ' });
			String userName = tokens[5];
			String userIP = tokens[1];
			logsFiller(userName, userIP);
		}

		private static void logsFiller(String name, String IP)
		{

			if (!log.ContainsKey(name))
			{
				log.Add(name, new Dictionary<string, int>()
					{
						{IP, 1}
					}
				);
			}
			else
			{
				if (!log[name].ContainsKey(IP))
				{
					log[name].Add(IP, 1);
				}
				else
				{
					int i = log[name].GetValueOrDefault(IP) + 1;
					log[name].Remove(IP);
					log[name].Add(IP, i);
				}
			}
		}

		private static void printer()
		{
			foreach (var item in log)
			{
				Console.WriteLine($"{item.Key}: ");
				StringBuilder sb = new StringBuilder();
				foreach (var item1 in item.Value)
				{
					sb.Append(item1.Key);
					sb.Append(" => ");
					sb.Append(item1.Value);
					sb.Append(", ");
				}
				Console.WriteLine(sb.ToString(0, sb.Length - 2) + ".");
			}
		}
	}
}
