using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Memory_View
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder fullMemoryView = new StringBuilder();
			string input = Console.ReadLine();

			while (input != "Visual Studio crash")
			{
				fullMemoryView.Append(input + " ");

				input = Console.ReadLine();
			}

			string[] strArray = fullMemoryView.ToString().Split("32656 19759 32763 0 ");
			foreach (string message in strArray)
			{
				List<string> messageList = new List<string>();
				string[] sA = message.Split(" ");
				foreach (string item in sA)
				{
					if (item.Length > 1 && item.Length < 4)
					{
						messageList.Add(item);
					}
				}

				List<char> charList = new List<char>();
				for (int i = 0; i < messageList.Count; i++)
				{
					int ch = int.Parse(messageList[i]);
					char c = (char)ch;
					charList.Add(c);
				}
				Console.WriteLine(string.Join("", charList));
			}
		}
	}
}
