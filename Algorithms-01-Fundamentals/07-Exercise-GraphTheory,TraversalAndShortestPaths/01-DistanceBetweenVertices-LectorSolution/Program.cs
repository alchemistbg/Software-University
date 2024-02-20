using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_DistanceBetweenVertices_LectorSolution
{
    class Program
    {
        static Dictionary<int, List<int>> graph;

        static void Main(string[] args)
        {
            int vertices = int.Parse(Console.ReadLine());
            int pairs = int.Parse(Console.ReadLine());

            graph = ReadGraph(vertices);
            //PrintGraph();
            //visited = new HashSet<int>();

            for (int i = 0; i < pairs; i++)
            {
                int[] pair = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int startNode = pair[0];
                int endNode = pair[1];

                int pathLegnth = CalcShortestPathLength(startNode, endNode);
                Console.WriteLine($"{{{startNode}, {endNode}}} -> {pathLegnth}");
                //visited = new HashSet<int>();
            }
        }

        private static void PrintGraph()
        {
            foreach (int node in graph.Keys)
            {
                Console.WriteLine($"{node} -> [{string.Join("; ", graph[node])}]");
            }
        }

        private static int CalcShortestPathLength(int startNode, int endNode)
        {
            HashSet<int> visited = new HashSet<int> { startNode };
            Dictionary<int, int> steps = new Dictionary<int, int> { { startNode, 0} };
            int result = -1;

            //BFS
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();

                if (currentNode == endNode)
                {
                    result =  steps[currentNode];
                }

                foreach (int childNode in graph[currentNode])
                {
                    if (!visited.Contains(childNode))
                    {
                        queue.Enqueue(childNode);
                        visited.Add(childNode);
                        steps[childNode] = steps[currentNode] + 1;
                    }
                }
                //Console.WriteLine(currentNode);
            }

            return result;
        }

        private static Dictionary<int, List<int>> ReadGraph(int vertices)
        {
            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            for (int i = 0; i < vertices; i++)
            {
                string[] lineParts = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                int node = int.Parse(lineParts[0]);
                //result.Add(node, new List<int>());

                List<int> children = new List<int>();
                if (lineParts.Length > 1)
                {
                    children = lineParts[1]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                }
                result[node] = children;
            }

            return result;
        }
    }
}
