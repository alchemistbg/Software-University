using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SoftUni_Karaoke
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> awardsList = new Dictionary<string, List<string>>();
			List<string> participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
			List<string> songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

			string input = Console.ReadLine();
			while (input != "dawn")
			{
				string[] inputArr = input.Split(',').Select(x => x.Trim()).ToArray();
				string participant = inputArr[0];
				string song = inputArr[1];
				string award = inputArr[2];

				if (participants.Contains(participant) && songs.Contains(song))
				{
					if (!awardsList.ContainsKey(participant))
					{
						List<string> a = new List<string>();
						a.Add(award);
						awardsList[participant] = a;
					}
					else
					{
						if (!awardsList[participant].Contains(award))
						{
							awardsList[participant].Add(award);
						}
					}
				}

				input = Console.ReadLine();
			}

			if (awardsList.Count == 0)
			{
				Console.WriteLine("No awards");
			}
			else
			{
				foreach (var participant in awardsList.OrderByDescending(x => x.Value.Count()))
				{
					Console.WriteLine($"{participant.Key}: {participant.Value.Count()} awards");
					foreach (var award in participant.Value.OrderBy(x => x))
					{
						Console.WriteLine($"--{award}");
					}
				}
			}
		}
	}
}
