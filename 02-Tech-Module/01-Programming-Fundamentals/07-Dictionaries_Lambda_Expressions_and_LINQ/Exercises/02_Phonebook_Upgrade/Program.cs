using System;
using System.Collections.Generic;

namespace _02_Phonebook_Upgrade
{
	class Program
	{
		static SortedDictionary<String, String> phoneBook = new SortedDictionary<string, string>();
		static void Main(string[] args)
		{

			String command = Console.ReadLine();

			while (command != "END")
			{
				if (command.StartsWith("A"))
				{
					addRecord(command);
				}
				else if (command.StartsWith("S"))
				{
					searchRecord(command);
				}
				else if (command.StartsWith("List"))
				{
					listAll();
				}
				command = Console.ReadLine();
			}
		}

		static void addRecord(String s)
		{
			string name = s.Split(" ")[1];
			string phone = s.Split(" ")[2];
			if (phoneBook.ContainsKey(name))
			{
				phoneBook[name] = phone;
			}
			else
			{
				phoneBook.Add(name, phone);
			}

		}

		static void searchRecord(String s)
		{
			String query = s.Split(" ")[1];
			if (phoneBook.ContainsKey(query))
			{
				Console.WriteLine($"{query} -> {phoneBook[query]}");
			}
			else
			{
				Console.WriteLine($"Contact {query} does not exist.");
			}
		}

		static void listAll()
		{
			foreach (KeyValuePair<String, String> phoneRecord in phoneBook)
			{
				Console.WriteLine($"{phoneRecord.Key} -> {phoneRecord.Value}");
			}
		}
	}
}
