using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ConnectedComponents
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static HashSet<int> visited;

        static void Main(string[] args)
        {
            graph = new Dictionary<int, List<int>>();
            visited = new HashSet<int>();

            int edgesCount = int.Parse(Console.ReadLine());

            for (int current = 0; current < edgesCount; current++)
            {
                List<int> currentNeighbours = new List<int>();

                string input = Console.ReadLine();

                if (input.Length > 0)
                {
                    currentNeighbours = input.Split().Select(int.Parse).ToList();

                }
                graph.Add(current, currentNeighbours);
            }

            //foreach (var kvp in graph)
            //{
            //    Console.WriteLine($"{kvp.Key}-> {string.Join("; ", kvp.Value)}");
            //}
            FindConnectedComponent();
        }

        static void FindConnectedComponent()
        {
            foreach (int node in graph.Keys)
            {
                if (!visited.Contains(node))
                {
                    Console.Write("Connected component:");
                    DFS(node);
                    Console.WriteLine();
                }
            }
        }

        static void DFS(int node)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            foreach (int child in graph[node])
            {
                DFS(child);
            }
            Console.Write($" {node}");
        }
    }
}
