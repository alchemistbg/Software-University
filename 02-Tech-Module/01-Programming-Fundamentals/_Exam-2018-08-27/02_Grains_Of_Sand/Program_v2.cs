//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _02_Grains_Of_Sand
//{
//	class Program_v2
//	{
//		static void Main(string[] args)
//		{
//			List<long> grains = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

//			string command = Console.ReadLine();
//			while (command != "Mort")
//			{
//				string[] commArr = command.Split(" ");
//				switch (commArr[0])
//				{
//					case "Add":
//						long valueToAdd = long.Parse(commArr[1]);
//						grains.Add(valueToAdd);
//						break;
//					case "Remove":
//						long valueToRemove = long.Parse(commArr[1]);
//						if (grains.Contains(valueToRemove))
//						{
//							grains.Remove(valueToRemove);
//						}
//						else
//						{
//							if (valueToRemove >= 0 && valueToRemove < grains.Count)
//							{
//								grains.RemoveAt((int)valueToRemove);
//							}
//						}
//						break;
//					case "Replace":
//						long valueToReplace = long.Parse(commArr[1]);
//						long replacementValue = long.Parse(commArr[2]);
//						if (grains.Contains(valueToReplace))
//						{
//							int valueToReplaceIndex = grains.IndexOf(valueToReplace);
//							grains[valueToReplaceIndex] = replacementValue;
//						}
//						break;
//					case "Increase":
//						long value = long.Parse(commArr[1]);
//						long valueToIncrease = grains[grains.Count - 1];
//						for (int i = 0; i < grains.Count; i++)
//						{
//							if (!(grains[i] < value))
//							{
//								valueToIncrease = grains[i];
//								break;
//							}
//						}
//						for (int i = 0; i < grains.Count; i++)
//						{
//							grains[i] = grains[i] + valueToIncrease;
//						}
//						break;
//					case "Collapse":
//						long valueToCollapse = long.Parse(commArr[1]);
//						for (int i = grains.Count-1; i >= 0; i--)
//						{
//							if (grains[i] < valueToCollapse)
//							{
//								grains.RemoveAt(i);
//							}
//						}
//						break;
//					default:
//						break;
//				}

//				command = Console.ReadLine();
//			}

//			Console.WriteLine(string.Join(" ", grains));
//		}
//	}
//}
