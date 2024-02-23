using System;
using System.Linq;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _01_MostReliablePath
{
    class Path
    {
        public int FirstTown { get; set; }
        public int SecondTown { get; set; }
        public int Reliability { get; set; }

        public Path(int firstTown, int secondTown, int reliability)
        {
            this.FirstTown = firstTown;
            this.SecondTown = secondTown;
            this.Reliability = reliability;
        }

        public override string ToString()
        {
            return $"{FirstTown} - {SecondTown} = {Reliability}";
        }
    }

    class Program
    {
        static SortedDictionary<int, List<Path>> graph;
        static void Main(string[] args)
        {

            int citiesCount = int.Parse(Console.ReadLine());
            int pathsCount = int.Parse(Console.ReadLine());

            graph = ReadGraph(pathsCount);

            int startTown = int.Parse(Console.ReadLine());
            int endTown = int.Parse(Console.ReadLine());

            double[] distances = new double[citiesCount + 1];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = double.NegativeInfinity;
            }
            distances[startTown] = 100.0;

            int[] prev = new int[citiesCount + 1];
            for (int i = 0; i < prev.Length; i++)
            {
                prev[i] = -1;
            }

            OrderedBag<int> queue = new OrderedBag<int>(
                Comparer<int>.Create((fT, sT) => distances[sT].CompareTo(distances[fT]))
                );
            queue.Add(startTown);

            while (queue.Count > 0)
            {
                int currentTown = queue.RemoveFirst();
                if (currentTown == endTown)
                {
                    break;
                }

                List<Path> paths = graph[currentTown];

                foreach (Path path in paths)
                {
                    int town = (path.FirstTown == currentTown ? path.SecondTown : path.FirstTown);

                    if (double.IsNegativeInfinity(distances[town]))
                    {
                        queue.Add(town);
                    }

                    double newDistance = distances[currentTown] * path.Reliability / 100.0;
                    if (newDistance > distances[town])
                    {
                        distances[town] = newDistance;
                        prev[town] = currentTown;

                        queue = new OrderedBag<int>(queue, Comparer<int>.Create((fT, sT) => distances[sT].CompareTo(distances[fT])));

                    }
                }
            }
            PrintResult(endTown, prev, distances);
        }

        private static void PrintResult(int endTown, int[] prev, double[] distances)
        {
            Console.WriteLine($"Most reliable path reliability: {distances[endTown].ToString("#0.00")}%");
            Stack<int> finalPath = new Stack<int>();
            int node = endTown;
            while (node != -1)
            {
                finalPath.Push(node);
                node = prev[node];
            }
            Console.WriteLine(string.Join(" -> ", finalPath));
        }

        private static SortedDictionary<int, List<Path>> ReadGraph(int citiesCount)
        {
            SortedDictionary<int, List<Path>> result = new SortedDictionary<int, List<Path>>();

            for (int i = 0; i < citiesCount; i++)
            {
                int[] pathData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstTown = pathData[0];
                int secondTown = pathData[1];
                int reliability = pathData[2];

                if (!result.Keys.Contains(firstTown))
                {
                    result.Add(firstTown, new List<Path>());
                }

                if (!result.Keys.Contains(secondTown))
                {
                    result.Add(secondTown, new List<Path>());
                }

                Path path = new Path(firstTown, secondTown, reliability);
                result[firstTown].Add(path);
                result[secondTown].Add(path);
            }

            return result;
        }
    }
}
