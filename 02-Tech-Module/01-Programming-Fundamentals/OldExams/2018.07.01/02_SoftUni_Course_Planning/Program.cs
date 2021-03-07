using System;
using System.Collections.Generic;

namespace _02_SoftUni_Course_Planning
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> Schedule = Console.ReadLine().Split(", ").ToList();

			string input = Console.ReadLine();
			while (input != "course start")
			{
				string[] inputArr = input.Split(":");

				string command = inputArr[0];
				string lesson = inputArr[1];
				switch (command)
				{
					case "Add":
						if (!Schedule.Contains(lesson))
						{
							Schedule.Add(lesson);
						}
						break;
					case "Remove":
						if (Schedule.Contains(lesson))
						{
							Schedule.Remove(lesson);
							if (Schedule.Contains(lesson + "-Exercise"))
							{
								Schedule.Remove(lesson + "-Exercise");
							}
						}
						break;
					case "Insert":
						int index = int.Parse(inputArr[2]);
						if ((index > -1 && index < Schedule.Count) && !Schedule.Contains(lesson))
						{
							if (Schedule[index].Contains("-Exercise"))
							{
								Schedule.Insert(index + 1, lesson);
							}
							else
							{
								Schedule.Insert(index, lesson);
							}

						}
						break;
					case "Swap":
						string lessonToSwap = inputArr[2];
						if (Schedule.Contains(lesson) && Schedule.Contains(lessonToSwap))
						{
							int l1Index = Schedule.IndexOf(lesson);
							int l2Index = Schedule.IndexOf(lessonToSwap);

							string temp = Schedule[l1Index];
							Schedule[l1Index] = Schedule[l2Index];
							Schedule[l2Index] = temp;

							if (Schedule.Contains(lesson + "-Exercise"))
							{
								Schedule.Remove(lesson + "-Exercise");
								Schedule.Insert(Schedule.IndexOf(lesson) + 1, lesson + "-Exercise");
							}

							if (Schedule.Contains(lessonToSwap + "-Exercise"))
							{
								Schedule.Remove(lessonToSwap + "-Exercise");
								Schedule.Insert(Schedule.IndexOf(lessonToSwap) + 1, lessonToSwap + "-Exercise");
							}
						}
						break;
					case "Exercise":
						if (!Schedule.Contains(lesson))
						{
							Schedule.Add(lesson);
							Schedule.Add(lesson + "-Exercise");
						}
						else
						{
							if (!Schedule.Contains(lesson + "-Exercise"))
							{
								int lIndex = Schedule.IndexOf(lesson);
								Schedule.Insert(lIndex + 1, lesson + "-Exercise");
							}
						}
						break;
						//default:
						//	break;
				}

				input = Console.ReadLine();
			}

			for (int i = 0; i < Schedule.Count; i++)
			{
				Console.WriteLine($"{i + 1}.{Schedule[i]}");
			}
		}
	}
}
