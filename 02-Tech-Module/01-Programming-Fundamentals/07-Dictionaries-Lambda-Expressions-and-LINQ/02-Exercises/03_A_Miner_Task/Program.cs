using System;
using System.Collections.Generic;

namespace _03_A_Miner_Task
{
	class Program
	{
		static Dictionary<String, int> minerDiary = new Dictionary<string, int>();

		static void Main(string[] args)
		{
			List<String> helperList = new List<string>();
			String command = Console.ReadLine();

			while (!command.Equals("stop"))
			{
				helperList.Add(command);
				command = Console.ReadLine();
			}
			proccessResource(helperList);
		}

		static void proccessResource(List<String> list)
		{
			List<string> keyList = new List<string>();
			List<int> valueList = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (i % 2 == 0)
				{
					keyList.Add(list[i]);
				}
				else
				{
					int n = int.Parse(list[i]);
					valueList.Add(n);
				}
			}

			for (int i = 0; i < keyList.Count; i++)
			{
				if (!minerDiary.ContainsKey(keyList[i]))
				{
					minerDiary.Add(keyList[i], valueList[i]);
				}
				else
				{
					minerDiary[keyList[i]] = minerDiary[keyList[i]] + valueList[i];
				}
			}
			endAndPrint();
		}

		static void endAndPrint()
		{
			foreach (var item in minerDiary)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
