using System;
using System.Linq;
using System.Collections.Generic;

//The code is the same as the problem from the lab. Just the naming of the valiables is a little bit different
namespace _04_BigTrip
{
    class Road
    {
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public int Time { get; set; }

        public Road(int startPoint, int endPoint, int time)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Time = time;
        }
    }

    class Program
    {
        private static List<Road>[] graph;
        static void Main(string[] args)
        {
            int pointsCount = int.Parse(Console.ReadLine());
            int roadsCount = int.Parse(Console.ReadLine());

            graph = ReadGraph(roadsCount);

            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            double[] distances = new double[pointsCount + 1];
            int[] prev = new int[pointsCount + 1];

            for (int i = 0; i < pointsCount + 1; i++)
            {
                distances[i] = double.NegativeInfinity;
                prev[i] = -1;
            }

            distances[startPoint] = 0;

            Stack<int> sortedRoads = TopologicalSortic();

            while (sortedRoads.Count > 0)
            {
                int currentRoad = sortedRoads.Pop();

                foreach (Road road in graph[currentRoad])
                {
                    double newDistance = distances[currentRoad] + road.Time;
                    if (newDistance > distances[road.EndPoint])
                    {
                        distances[road.EndPoint] = newDistance;
                        prev[road.EndPoint] = road.StartPoint;
                    }
                }
            }

            Console.WriteLine(distances[endPoint]);

            Stack<int> path = new Stack<int>();
            int point = endPoint;
            while (point != -1)
            {
                path.Push(point);
                point = prev[point];
            }
            Console.WriteLine(string.Join(" ", path));
        }

        private static Stack<int> TopologicalSortic()
        {
            bool[] visited = new bool[graph.Length];

            Stack<int> sortedNodes = new Stack<int>();

            for (int point = 0; point < graph.Length; point++)
            {
                DFS(point, visited, sortedNodes);
            }

            return sortedNodes;
        }

        private static void DFS(int point, bool[] visited, Stack<int> sortedNodes)
        {
            if (visited[point])
            {
                return;
            }

            visited[point] = true;

            foreach (Road road in graph[point])
            {
                DFS(road.EndPoint, visited, sortedNodes);
            }

            sortedNodes.Push(point);
        }

        private static List<Road>[] ReadGraph(int roadsCount)
        {
            List<Road>[] result = new List<Road>[roadsCount + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<Road>();
            }

            for (int i = 0; i < roadsCount; i++)
            {
                int[] roadData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int startPoint = roadData[0];
                int endPoint = roadData[1];
                int time = roadData[2];

                Road road = new Road(startPoint, endPoint, time);

                result[startPoint].Add(road);
            }

            return result;
        }
    }
}
