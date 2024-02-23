using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_MaxFlowAlgorithm_Edmonds_Karp
{
    class Program
    {
        public static int nodesCount, source, destination, maxFlow;
        public static int[][] graph;
        public static int[] parents;

        static void Main(string[] args)
        {
            ReadInput();
            FindMaxFlow();
            PrintResults();
        }

        private static void FindMaxFlow()
        {
            maxFlow = 0;
            while (BFS(graph, parents))
            {
                var minFlow = int.MaxValue;
                var to = destination;
                var from = parents[to];

                while (to != -1 && from != -1)
                {
                    minFlow = Math.Min(minFlow, graph[from][to]);

                    to = parents[to];
                    from = parents[to];
                }

                maxFlow += minFlow;
                to = destination;
                from = parents[to];
                while (to != -1 && from != -1)
                {
                    graph[from][to] -= minFlow;
                    to = parents[to];
                    from = parents[to];
                }
            }
        }

        private static bool BFS(int[][] graph, int[] parents)
        {
            var visited = new bool[graph.Length];
            var queue = new Queue<int>();

            visited[source] = true;
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                for (int child = 0; child < graph[node].Length; child++)
                {
                    if (!visited[child] && graph[node][child] > 0)
                    {
                        queue.Enqueue(child);
                        visited[child] = true;
                        parents[child] = node;
                    }
                }
            }

            return visited[destination];
        }

        private static void PrintResults()
        {
            Console.WriteLine($"Max flow = " + maxFlow);
        }

        private static void ReadInput()
        {
            nodesCount = int.Parse(Console.ReadLine());
            graph = new int[nodesCount][];
            parents = new int[nodesCount];
            for (int i = 0; i < nodesCount; i++)
            {
                var elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                graph[i] = elements;
            }

            source = int.Parse(Console.ReadLine());
            destination = int.Parse(Console.ReadLine());
            Array.Fill(parents, -1);
        }
    }
}
