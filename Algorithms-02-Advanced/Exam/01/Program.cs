using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;
using System.Linq;

namespace _01
{
    public class Road
    {
        public int FirstShop { get; set; }
        public int SecondShop { get; set; }
        public int Time { get; set; }

        public Road(int firstShop, int secondShop, int time)
        {
            FirstShop = firstShop;
            SecondShop = secondShop;
            Time = time;
        }
    }

    class Program
    {
        public static Dictionary<int, List<Road>> shopsMap;
        public static HashSet<int> roadMap;
        static void Main(string[] args)
        {
            int shopsCount = int.Parse(Console.ReadLine());
            int roadsCount = int.Parse(Console.ReadLine());

            shopsMap = ReadGraph(roadsCount);
            roadMap = new HashSet<int>();

            foreach (int shop in shopsMap.Keys)
            {
                if (!roadMap.Contains(shop))
                {
                    Prim(shop);
                }
            }
        }

        private static void Prim(int shop)
        {
            int totalShopTourTime = 0;

            roadMap.Add(shop);
            OrderedBag<Road> queue = new OrderedBag<Road>(shopsMap[shop], Comparer<Road>.Create((road1, road2) => road1.Time - road2.Time));

            while (queue.Count > 0)
            {
                Road currentRoad = queue.RemoveFirst();

                int outsideRoad = -1;

                if (roadMap.Contains(currentRoad.FirstShop) && !roadMap.Contains(currentRoad.SecondShop))
                {
                    outsideRoad = currentRoad.SecondShop;
                }
                if (!roadMap.Contains(currentRoad.FirstShop) && roadMap.Contains(currentRoad.SecondShop))
                {
                    outsideRoad = currentRoad.FirstShop;
                }

                if (outsideRoad == -1)
                {
                    continue;
                }

                //Console.WriteLine($"{currentRoad.FirstTown} -> {currentRoad.SecondTown} = {currentRoad.RoadCost}");
                totalShopTourTime += currentRoad.Time;

                roadMap.Add(outsideRoad);
                queue.AddMany(shopsMap[outsideRoad]);
            }
            Console.WriteLine(totalShopTourTime);
        }

        private static Dictionary<int, List<Road>> ReadGraph(int roadsCount)
        {
            Dictionary<int, List<Road>> result = new Dictionary<int, List<Road>>();

            for (int i = 0; i < roadsCount; i++)
            {
                int[] roadData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstShop = roadData[0];
                int secondShop = roadData[1];
                int time = roadData[2];

                Road road = new Road(firstShop, secondShop, time);

                if (!result.Keys.Contains(firstShop))
                {
                    result.Add(firstShop, new List<Road>());
                }

                if (!result.Keys.Contains(secondShop))
                {
                    result.Add(secondShop, new List<Road>());
                }

                result[firstShop].Add(road);
                result[secondShop].Add(road);

            }

            return result;
        }
    }
}
