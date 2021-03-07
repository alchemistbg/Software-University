using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Roli_The_Coder
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, Event> eventList = new Dictionary<int, Event>();
			string input = Console.ReadLine();

			while (input != "Time for Code")
			{
				if (input.Contains('#'))
				{
					string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					int eventID = int.Parse(inputArr[0]);
					string eventName = inputArr[1].Substring(1);
					List<string> eventParticipants = new List<string>();

					for (int i = 2; i < inputArr.Length; i++)
					{
						eventParticipants.Add(inputArr[i]);
					}

					if (!eventList.ContainsKey(eventID))
					{
						Event e = new Event();
						e.Name = eventName;
						e.Participants = eventParticipants;
						eventList[eventID] = e;
					}
					else
					{
						if (eventList[eventID].Name == eventName)
						{
							eventList[eventID].Participants.AddRange(eventParticipants);
						}
					}

					eventList[eventID].Participants = eventList[eventID].Participants.Distinct().ToList();
				}

				input = Console.ReadLine();
			}

			foreach (var eventItem in eventList.OrderByDescending(x => x.Value.Participants.Count()).ThenBy(x => x.Value.Name))
			{
				Console.WriteLine($"{eventItem.Value.Name} - {eventItem.Value.Participants.Count}");
				foreach (string participant in eventItem.Value.Participants.OrderBy(x => x))
				{
					Console.WriteLine(participant);
				}
			}

		}
	}

	class Event
	{
		public string Name { get; set; }
		public List<string> Participants { get; set; }
	}
}
