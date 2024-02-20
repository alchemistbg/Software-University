using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_DistanceBetweenVertices
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static Dictionary<int, List<int>> queries;
        static HashSet<int> visited;
        static HashSet<int> parents;

        public static void Main(string[] args)
        {
            int vertices = int.Parse(Console.ReadLine());
            int pairs = int.Parse(Console.ReadLine());

            graph = ReadGraph(vertices);
            PrintGraph();
        }

        private static Dictionary<int, List<int>> ReadGraph(int vertices)
        {
            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            for (int i = 0; i < vertices; i++)
            {
                string[] lineParts = Console.ReadLine().Split(":");
                int node = int.Parse(lineParts[0]);

                List<int> children = new List<int>();

                if (lineParts.Length > 1)
                {
                    children = lineParts[1].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                }

                result[node] = children;
            }

            return result;
        }

        private static void PrintGraph()
        {
            foreach (int key in graph.Keys)
            {
                Console.WriteLine($"{key} -> {string.Join("; ", graph[key])}");
            }
        }
    }
}