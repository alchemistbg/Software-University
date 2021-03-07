using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _02_Anonymous_Threat
{
	class Program
	{
		static List<string> mainList = new List<string>();
		static List<string> tempList = new List<string>();

		static void Main(string[] args)
		{
			mainList = Console.ReadLine().Split(' ').ToList();

			string command = Console.ReadLine();
			commandParser(command);

			while (command != "3:1")
			{
				command = Console.ReadLine();
				commandParser(command);
			}

			Console.WriteLine(string.Join(" ", mainList));
		}

		private static void commandParser(string command)
		{
			if (command.Contains("merge"))
			{
				string[] comArr = command.Split(' ');
				int startI = int.Parse(comArr[1]);
				if (startI < 0)
				{
					startI = 0;
				}
				int endI = int.Parse(comArr[2]);
				if (endI > mainList.Count - 1)
				{
					endI = mainList.Count - 1;
				}

				doMerge(startI, endI);
			}
			else if (command.Contains("divide"))
			{
				string[] comArr = command.Split(' ');
				int stringToDivide = int.Parse(comArr[1]);
				int partsNum = int.Parse(comArr[2]);

				doDivide(stringToDivide, partsNum);
			}
		}

		private static void doDivide(int stringToDivide, int partsNum)
		{
			List<string> splittedString = new List<string>();
			int partLength = mainList[stringToDivide].Length / partsNum;

			for (int i = 0; i < mainList.Count; i++)
			{
				if (i != stringToDivide)
				{
					tempList.Add(mainList[i]);
				}
				else
				{
					for (int j = 0; j < partsNum; j++)
					{
						if (j < partsNum - 1)
						{
							tempList.Add(mainList[stringToDivide].Substring(j * partLength, partLength));
						}
						else
						{
							tempList.Add(mainList[stringToDivide].Substring(j * partLength, mainList[stringToDivide].Length - j * partLength));
						}
					}
				}
			}

			mainList = CloneList<string>(tempList);
			tempList = new List<string>();
		}

		private static void doMerge(int startI, int endI)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < mainList.Count; i++)
			{
				if (i >= startI && i <= endI)
				{
					sb.Append(mainList[i]);
					if (i == endI)
					{
						tempList.Add(sb.ToString());
					}
				}
				else
				{
					tempList.Add(mainList[i]);
				}
			}

			mainList = CloneList<string>(tempList);
			tempList = new List<string>();

		}

		public static List<T> CloneList<T>(List<T> oldList)
		{
			BinaryFormatter formatter = new BinaryFormatter();
			MemoryStream stream = new MemoryStream();
			formatter.Serialize(stream, oldList);
			stream.Position = 0;
			return (List<T>)formatter.Deserialize(stream);
		}
	}
}
