using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SourceRemovalTopologicalSorting_LectorSolution
{
    class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static Dictionary<string, int> dependencies;

        public static void Main(string[] args)
        {
            graph = ReadGraph();

            dependencies = ExtractDependencies();

            List<string> sorted = TopologicalSorting();
            if (sorted == null)
            {
                Console.WriteLine("Invalid topological sorting");
            }
            else
            {
                Console.WriteLine($"Topological sorting: {string.Join(", ", sorted)}");
            }
        }

        private static List<string> TopologicalSorting()
        {
            List<string> sortedNodes = new List<string>();

            while (dependencies.Count > 0)
            {
                KeyValuePair<string, int> nodeToRemove = dependencies
                                    .FirstOrDefault(n => n.Value == 0);

                if (string.IsNullOrEmpty(nodeToRemove.Key))
                {
                    break;
                }

                string node = nodeToRemove.Key;
                List<string> children = graph[node];

                sortedNodes.Add(node);
                dependencies.Remove(nodeToRemove.Key);

                foreach (string child in children)
                {
                    dependencies[child] -= 1;
                }
            }

            if (dependencies.Count > 0)
            {
                return null;
            }

            return sortedNodes;
        }

        private static Dictionary<string, int> ExtractDependencies()
        {
            Dictionary<string, int> extractedDependencies = new Dictionary<string, int>();

            foreach (var kvp in graph)
            {
                string key = kvp.Key;
                List<string> children = kvp.Value;

                if (!extractedDependencies.ContainsKey(key))
                {
                    extractedDependencies.Add(key, 0);
                }

                foreach (string child in children)
                {
                    if (!extractedDependencies.ContainsKey(child))
                    {
                        extractedDependencies.Add(child, 1);
                    }
                    else
                    {
                        extractedDependencies[child] += 1;
                    }
                }
            }

            return extractedDependencies;
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
