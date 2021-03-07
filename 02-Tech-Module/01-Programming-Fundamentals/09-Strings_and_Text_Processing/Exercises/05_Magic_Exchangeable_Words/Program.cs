using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Magic_Exchangeable_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<char, char> map = new Dictionary<char, char>();
			string[] inputArr = Console.ReadLine().Split(' ').OrderByDescending(x => x.Length).ToArray();
			string word1 = inputArr[0];
			string word2 = inputArr[1];

			bool isMagic = true;

			for (int i = 0; i < word1.Length; i++)
			{
				if (i < word2.Length)
				{
					if (!map.ContainsKey(word1[i]))
					{
						map[word1[i]] = word2[i];
					}
					else
					{
						if (map[word1[i]] != word2[i])
						{
							isMagic = false;
						}
					}
				}
				else
				{
					if (!map.ContainsKey(word1[i]))
					{
						isMagic = false;
					}
				}
			}

			Console.WriteLine(isMagic.ToString().ToLower());
		}
	}
}
