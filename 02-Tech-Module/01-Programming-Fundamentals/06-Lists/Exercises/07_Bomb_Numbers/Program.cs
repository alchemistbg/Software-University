using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string strList = Console.ReadLine();
			List<int> numList = strList.Split(' ').Select(int.Parse).ToList();

			string bombInfo = Console.ReadLine();
			int bomb = int.Parse(bombInfo.Split(' ').ToArray()[0]);
			int detonation = int.Parse(bombInfo.Split(' ').ToArray()[1]);

			while (numList.Contains(bomb))
			{
				int bombIndex = numList.IndexOf(bomb);
				int leftIndex;
				int rightIndex;
				int length = 0;

				leftIndex = bombIndex - detonation;
				rightIndex = bombIndex + detonation;
				length = rightIndex - leftIndex + 1;

				if (leftIndex < 0)
				{
					leftIndex = 0;
				}

				if (leftIndex + length > numList.Count)
				{
					length = numList.Count - leftIndex;
				}
				numList.RemoveRange(leftIndex, length);
			}
			Console.WriteLine(numList.Sum());
		}
	}
}
