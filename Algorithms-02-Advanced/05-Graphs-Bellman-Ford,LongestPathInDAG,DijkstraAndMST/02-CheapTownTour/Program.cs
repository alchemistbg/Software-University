using System;
using System.Linq;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _02_CheapTownTour
{
    class Road
    {
        public int FirstTown { get; set; }
        public int SecondTown { get; set; }
        public int RoadCost { get; set; }

        public Road(int firstTown, int secondTown, int cost)
        {
            this.FirstTown = firstTown;
            this.SecondTown = secondTown;
            this.RoadCost = cost;
        }

        public override string ToString()
        {
            return $"{FirstTown} -> {SecondTown} = {RoadCost}";
        }
    }

    class Program
    {
        static Dictionary<int, List<Road>> country;
        static HashSet<int> roadMap;

        static void Main(string[] args)
        {
            int townsCount = int.Parse(Console.ReadLine());
            int roadsCount = int.Parse(Console.ReadLine());
            country = ReadCountryData(roadsCount);
            roadMap = new HashSet<int>();

            foreach (int town in country.Keys)
            {
                if (!roadMap.Contains(town))
                {
                    Prim(town);
                }
            }
        }

        private static void Prim(int town)
        {
            int totalRoadCost = 0;
            roadMap.Add(town);
            OrderedBag<Road> queue = new OrderedBag<Road>(country[town], Comparer<Road>.Create((road1, road2) => road1.RoadCost - road2.RoadCost));
            
            while (queue.Count > 0)
            {
                Road currentRoad = queue.RemoveFirst();

                int outsideRoad = -1;
                if (roadMap.Contains(currentRoad.FirstTown) && !roadMap.Contains(currentRoad.SecondTown))
                {
                    outsideRoad = currentRoad.SecondTown;
                }
                if (!roadMap.Contains(currentRoad.FirstTown) && roadMap.Contains(currentRoad.SecondTown))
                {
                    outsideRoad = currentRoad.FirstTown;
                }

                if (outsideRoad == -1)
                {
                    continue;
                }

                //Console.WriteLine($"{currentRoad.FirstTown} -> {currentRoad.SecondTown} = {currentRoad.RoadCost}");
                totalRoadCost += currentRoad.RoadCost;

                roadMap.Add(outsideRoad);
                queue.AddMany(country[outsideRoad]);
            }
            Console.WriteLine($"Total cost: {totalRoadCost}");
        }

        private static Dictionary<int, List<Road>> ReadCountryData(int roadsCount)
        {
            Dictionary<int, List<Road>> result = new Dictionary<int, List<Road>>();

            for (int i = 0; i < roadsCount; i++)
            {
                int[] roadData = Console.ReadLine().Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstTown = roadData[0];
                int secondTown = roadData[1];
                int roadCost = roadData[2];

                Road road = new Road(firstTown, secondTown, roadCost);

                if (!result.Keys.Contains(firstTown))
                {
                    result.Add(firstTown, new List<Road>());
                }

                if (!result.Keys.Contains(secondTown))
                {
                    result.Add(secondTown, new List<Road>());
                }

                result[firstTown].Add(road);
                result[secondTown].Add(road);
            }

            return result;
        }
    }
}
