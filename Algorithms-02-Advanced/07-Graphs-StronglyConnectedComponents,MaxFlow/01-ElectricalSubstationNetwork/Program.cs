using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ElectricalSubstationNetwork
{
    class Program
    {
        public static List<int>[] originalGraph;
        public static List<int>[] reversedGraph;
        public static Stack<int> orderedNodes;

        static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());

            (originalGraph, reversedGraph) = ReadGraph(nodesCount, edgesCount);

            orderedNodes = TopologicalSorting();

            bool[] visitedReversed = new bool[nodesCount]; 
            while (orderedNodes.Count > 0)
            {
                int currentNode = orderedNodes.Pop();

                if (visitedReversed[currentNode])
                {
                    continue;
                }

                Stack<int> scc = new Stack<int>();
                DFS(reversedGraph, currentNode, visitedReversed, scc);
                Console.WriteLine(string.Join(", ", scc));
            }
        }

        private static Stack<int> TopologicalSorting()
        {
            Stack<int> stack = new Stack<int>();
            bool[] visitedOriginal = new bool[originalGraph.Length];

            for (int node = 0; node < originalGraph.Length; node++)
            {
                if (!visitedOriginal[node])
                {
                    DFS(originalGraph, node, visitedOriginal, stack);
                }
            }

            return stack;
        }

        private static void DFS(List<int>[] workingGraph, int node, bool[] visited, Stack<int> stack)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (int child in workingGraph[node])
            {
                DFS(workingGraph, child, visited, stack);
            }

            stack.Push(node);
        }

        private static (List<int>[] original, List<int>[] reversed) ReadGraph(int nodesCount, int edgesCount)
        {
            List<int>[] original = new List<int>[nodesCount];
            List<int>[] reversed = new List<int>[nodesCount];

            for (int node = 0; node < nodesCount; node++)
            {
                original[node] = new List<int>();
                reversed[node] = new List<int>();
            }

            for (int i = 0; i < edgesCount; i++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                int node = data[0];
                for (int j = 1; j < data.Length; j++)
                {
                    int child = data[j];
                    original[node].Add(child);
                    reversed[child].Add(node);
                }
            }

            return (original, reversed);
        }
    }
}
