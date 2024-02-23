using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ArticulationPoints
{
    class Program
    {
        public static int nodesCount;
        public static List<int>[] graph;
        public static int[] parents, depths, lowpoints;
        public static bool[] visited;
        public static List<int> points;
        static void Main(string[] args)
        {
            ReadInput();
            DFS(0, 1);
            PrintResult();
        }
        private static void DFS(int node, int depth)
        {
            visited[node] = true;
            depths[node] = depth;
            lowpoints[node] = depth;

            var children = 0;
            var isArticulation = false;

            foreach (var child in graph[node])
            {
                if (!visited[child])
                {
                    parents[child] = node;
                    DFS(child, depth + 1);
                    children++;

                    if (lowpoints[child] >= depth)
                    {
                        isArticulation = true;
                    }

                    lowpoints[node] = Math.Min(lowpoints[node], lowpoints[child]);
                }
                else if (parents[node] != child)
                {
                    lowpoints[node] = Math.Min(lowpoints[node], depths[child]);
                }
            }

            if (parents[node] == -1 && children > 1 || parents[node] != -1 && isArticulation)
            {
                points.Add(node);
            }
        }
        private static void PrintResult()
        {
            Console.WriteLine($"Articulation points: {string.Join(", ", points)}");
        }
        private static void InitializeVariables()
        {
            depths = new int[nodesCount];
            lowpoints = new int[nodesCount];
            graph = new List<int>[nodesCount];
            parents = new int[nodesCount];
            Array.Fill(parents, -1);
            visited = new bool[nodesCount];
            points = new List<int>();
        }
        private static void ReadInput()
        {
            nodesCount = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            InitializeVariables();
            for (int i = 0; i < lines; i++)
            {
                var elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                graph[i] = elements.Skip(1).ToList();
            }
        }
    }
}
