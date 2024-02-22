using System;
using System.Linq;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _03_Prim_sAlgorithm
{
    class Edge
    {
        public int FirstNode { get; set; }
        public int SecondNode { get; set; }
        public int NodeWeight { get; set; }

        public Edge(int firstNode, int secondNode, int nodeWeight)
        {
            this.FirstNode = firstNode;
            this.SecondNode = secondNode;
            this.NodeWeight = nodeWeight;
        }
    }
    class Program
    {
        public static Dictionary<int, List<Edge>> graph;
        public static HashSet<int> forest;
        static void Main(string[] args)
        {
            int edgesCount = int.Parse(Console.ReadLine());
            graph = ReadGraph(edgesCount);
            forest = new HashSet<int>();

            foreach (int node in graph.Keys)
            {
                if (!forest.Contains(node))
                {
                    Prim(node);
                }
            }
        }

        private static void Prim(int node)
        {
            forest.Add(node);
            OrderedBag<Edge> queue = new OrderedBag<Edge>(graph[node], Comparer<Edge>.Create((edge1, edge2) => edge1.NodeWeight - edge2.NodeWeight));

            while (queue.Count > 0)
            {
                Edge currentEdge = queue.RemoveFirst();

                int nonTreeNode = -1;
                if (forest.Contains(currentEdge.FirstNode) && !forest.Contains(currentEdge.SecondNode))
                {
                    nonTreeNode = currentEdge.SecondNode;
                }else if (!forest.Contains(currentEdge.FirstNode) && forest.Contains(currentEdge.SecondNode))
                {
                    nonTreeNode = currentEdge.FirstNode;
                }

                if (nonTreeNode == -1)
                {
                    continue;
                }

                Console.WriteLine($"{currentEdge.FirstNode} - {currentEdge.SecondNode}");

                forest.Add(nonTreeNode);
                queue.AddMany(graph[nonTreeNode]);
            }
        }

        private static Dictionary<int, List<Edge>> ReadGraph(int edgesCount)
        {
            Dictionary<int, List<Edge>> result = new Dictionary<int, List<Edge>>();

            for (int i = 0; i < edgesCount; i++)
            {
                int[] edgeData = Console.ReadLine().Split(new [] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstNode = edgeData[0];
                int secondNode = edgeData[1];
                int nodeWeight = edgeData[2];
                if (!result.Keys.Contains(firstNode))
                {
                    result.Add(firstNode, new List<Edge>());
                }
                
                if (!result.Keys.Contains(secondNode))
                {
                    result.Add(secondNode, new List<Edge>());
                }

                Edge edge = new Edge(firstNode, secondNode, nodeWeight);

                result[firstNode].Add(edge);
                result[secondNode].Add(edge);
            }

            return result;
        }
    }
}
