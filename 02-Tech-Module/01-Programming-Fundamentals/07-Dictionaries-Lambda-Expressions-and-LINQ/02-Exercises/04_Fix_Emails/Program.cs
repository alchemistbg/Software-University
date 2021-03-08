using System;
using System.Collections.Generic;

namespace _04_Fix_Emails
{
	class Program
	{
		public static void Main(String[] args)
		{
			String entry = Console.ReadLine();

			List<String> dataStore = new List<string>();

			while (!entry.Equals("stop"))
			{
				dataStore.Add(entry);

				entry = Console.ReadLine();
			}
			dataFixer(dataStore);
		}

		public static void dataFixer(List<String> data)
		{
			Dictionary<String, String> emailBook = new Dictionary<string, string>();

			List<String> nameList = new List<string>(); ;
			List<String> emailList = new List<string>();

			for (int i = 0; i < data.Count; i++)
			{
				if (i % 2 == 0)
				{
					nameList.Add(data[i]);
				}
				else
				{
					emailList.Add(data[i]);
				}
			}

			for (int i = 0; i < nameList.Count; i++)
			{
				if (!emailList[i].EndsWith(".us") && !emailList[i].EndsWith(".uk"))
				{
					emailBook.Add(nameList[i], emailList[i]);
				}
			}
			printer(emailBook);
		}

		public static void printer(Dictionary<String, String> d)
		{
			foreach (var item in d)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
