using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Kruskal_sAlgorithm
{
    public class Edge
    {
        public int FirstNode { get; set; }
        public int SecondNode { get; set; }
        public int NodeWeight { get; set; }
    }

    class Program
    {
        private static List<Edge> edges;
        static void Main(string[] args)
        {
            int edgesCount = int.Parse(Console.ReadLine());

            edges = ReadEdges(edgesCount);

            List<Edge> sortedEdges = edges
                .OrderBy(edge => edge.NodeWeight)
                .ToList();

            HashSet<int> nodes = edges
                .Select(edge => edge.FirstNode)
                .Union(edges.Select(edge => edge.SecondNode))
                .ToHashSet();

            int[] parents = new int[nodes.Max() + 1];
            for (int i = 0; i < parents.Length; i++)
            {
                parents[i] = -1;
            }

            foreach (int node in nodes)
            {
                parents[node] = node;
            }

            foreach (Edge edge in sortedEdges)
            {
                int firstNodeRoot = GetRoot(edge.FirstNode, parents);
                int secondNodeRoot = GetRoot(edge.SecondNode, parents);

                if (firstNodeRoot == secondNodeRoot)
                {
                    continue;
                }
                Console.WriteLine($"{edge.FirstNode} - {edge.SecondNode}");
                parents[firstNodeRoot] = secondNodeRoot;
            }
        }

        private static int GetRoot(int nodeToCheck, int[] parents)
        {
            int node = nodeToCheck;
            while (node != parents[node])
            {
                node = parents[node];
            }
            return node;
        }

        private static List<Edge> ReadEdges(int edgesCount)
        {
            List<Edge> result = new List<Edge>();

            for (int i = 0; i < edgesCount; i++)
            {
                int[] edgeData = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstNode = edgeData[0];
                int secondNode = edgeData[1];
                int nodeWeight = edgeData[2];

                Edge edge = new Edge
                {
                    FirstNode = firstNode,
                    SecondNode = secondNode,
                    NodeWeight = nodeWeight
                };

                result.Add(edge);
            }

            return result;
        }
    }
}
