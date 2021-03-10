using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Iron_Girder
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Record> records = new Dictionary<string, Record>();
			string input = Console.ReadLine();

			while(input!= "Slide rule")
			{
				if (!input.Contains("ambush"))
				{
					string[] inputArr1 = input.Split(":");
					string town = inputArr1[0];
					string[] inputArr2 = inputArr1[1].Split("->");
					int time = int.Parse(inputArr2[0]);
					long passengers = long.Parse(inputArr2[1]);

					if (!records.ContainsKey(town))
					{
						Record record = new Record();
						record.recordTown = town;
						record.recordTime = time;
						record.recordPassengers = passengers;
						records[town] = record;
					}
					else
					{
						if (time < records[town].recordTime && records[town].recordTime > 0)
						{
							records[town].recordTime = time;
						}
						else if (records[town].recordTime == 0)
						{
							records[town].recordTime = time;
						}
						records[town].recordPassengers += passengers;
					}
				}
				else
				{
					string[] inputArr1 = input.Split(":");
					string townToZero = inputArr1[0];
					string[] inputArr2 = inputArr1[1].Split("->");
					long passengersToRemove = long.Parse(inputArr2[1]);

					if (records.ContainsKey(townToZero))
					{
						records[townToZero].recordTime = 0;
						records[townToZero].recordPassengers -= passengersToRemove;
					}
				}

				input = Console.ReadLine();
			}

			foreach (var record in records.OrderBy(x => x.Value.recordTime).ThenBy(x => x.Value.recordTown))
			{
				if (record.Value.recordTime > 0 && record.Value.recordPassengers > 0)
				{
					Console.WriteLine($"{record.Value.recordTown} -> Time: {record.Value.recordTime} -> Passengers: {record.Value.recordPassengers}");
				}
			}
		}
	}

	class Record
	{
		public string recordTown { get; set; }
		public int recordTime { get; set; }
		public long recordPassengers { get; set; }
	}
}
