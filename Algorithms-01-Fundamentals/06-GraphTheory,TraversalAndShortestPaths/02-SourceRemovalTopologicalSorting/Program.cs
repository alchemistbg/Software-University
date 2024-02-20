using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SourceRemovalTopologicalSorting
{
    class Program
    {
        static Dictionary<string, List<string>> graph;
        static HashSet<string> visited;
        static HashSet<string> cycles;
        static Stack<string> result;

        static void Main(string[] args)
        {
            graph = ReadGraph();
            visited = new HashSet<string>();
            cycles = new HashSet<string>();
            result = new Stack<string>();

            try
            {
                foreach (var node in graph.Keys)
                {
                    TopSortDFS(node);
                }
                Console.WriteLine($"Topological sorting: {string.Join(", ", result)}");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid topological sorting");
            }
        }

        static private void TopSortDFS(string node)
        {
            if (cycles.Contains(node))
            {
                throw new InvalidOperationException("Invalid topological sorting");
            }

            if (visited.Contains(node)) //this order lets us not delete from visitedForCycles
            {
                return;
            }
            cycles.Add(node);
            visited.Add(node); //add after the recursion so that it can get to the cycle check

            foreach (var child in graph[node])
            {
                TopSortDFS(child);
            }
            cycles.Remove(node);
            result.Push(node);
        }

        private static Dictionary<string, List<string>> ReadGraph()
        {
            Dictionary<string, List<string>> inputGraph = new Dictionary<string, List<string>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] lineParts = Console.ReadLine().Split(" ->");
                string key = lineParts[0];
                string children = lineParts[1].TrimStart();

                if (!string.IsNullOrEmpty(children))
                {
                    inputGraph.Add(key, new List<string>(children.Split(", ")));
                }
                else
                {
                    inputGraph.Add(key, new List<string>());
                }
            }

            return inputGraph;
        }
    }
}
