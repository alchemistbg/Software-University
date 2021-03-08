using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Logs_Aggregator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> logRecords = new List<string>();
			int logRecordsNumber = int.Parse(Console.ReadLine());

			string logString = Console.ReadLine();
			logRecords.Add(logString);

			for (int i = 1; i < logRecordsNumber; i++)
			{
				logString = Console.ReadLine();
				logRecords.Add(logString);
			}
			dataParser(logRecords);
		}

		public static void dataParser(List<string> logRecords)
		{
			SortedDictionary<string, SortedDictionary<string, int>> log =
									new SortedDictionary<string, SortedDictionary<string, int>>();
			string userName = "";
			string userIP = "";
			int sessionDuration = 0;

			for (int i = 0; i < logRecords.Count; i++)
			{
				string[] singleLog = logRecords[i].Split(" ");
				userName = singleLog[1];
				userIP = singleLog[0];
				sessionDuration = int.Parse(singleLog[2]);

				if (!log.ContainsKey(userName))
				{
					log.Add(userName, new SortedDictionary<string, int>()
						{
							{userIP, sessionDuration}
						}
					);
				}
				else
				{
					if (!log[userName].ContainsKey(userIP))
					{
						log[userName].Add(userIP, sessionDuration);
					}
					else
					{
						int duration = log[userName].GetValueOrDefault(userIP);
						duration += sessionDuration;
						log[userName].Remove(userIP);
						log[userName].Add(userIP, duration);
					}
				}
			}

			foreach (var item in log)
			{
				int userDuration = 0;
				foreach (var item1 in item.Value)
				{
					userDuration += item1.Value;
				}
				Console.WriteLine($"{item.Key}: {userDuration} [{string.Join(", ", item.Value.Keys)}]");
			}
		}
	}
}
