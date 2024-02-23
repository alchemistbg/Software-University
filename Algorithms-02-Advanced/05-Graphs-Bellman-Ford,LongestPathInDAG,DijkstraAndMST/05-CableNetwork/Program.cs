using System;
using System.Linq;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _05_CableNetwork
{
    class Edge
    {
        public int FirstNode { get; set; }
        public int SecondNode { get; set; }
        public int NodeWeight { get; set; }

        public Edge(int firstNode, int secondNode, int nodeWeight)
        {
            FirstNode = firstNode;
            SecondNode = secondNode;
            NodeWeight = nodeWeight;
        }
    }

    class Program
    {
        private static List<Edge>[] graph;
        private static HashSet<int> spanningTree;
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            int nodesCount = int.Parse(Console.ReadLine());

            int edgesCount = int.Parse(Console.ReadLine());

            spanningTree = new HashSet<int>();
            graph = ReadGraph(nodesCount, edgesCount);

            int usedBudget = Prim(budget);
            Console.WriteLine($"Budget used: {usedBudget}");
        }

        private static int Prim(int budget)
        {
            int usedBudget = 0;
            OrderedBag<Edge> queue = new OrderedBag<Edge>(
                Comparer<Edge>.Create((fN, sN) => fN.NodeWeight - sN.NodeWeight)
                );

            foreach (int node in spanningTree)
            {
                queue.AddMany(graph[node]);
            }

            while (queue.Count > 0)
            {
                Edge currentEdge = queue.RemoveFirst();

                //TODO - move it in a method
                int nonTreeNode = -1;

                if (spanningTree.Contains(currentEdge.FirstNode) &&
                    !spanningTree.Contains(currentEdge.SecondNode))
                {
                    nonTreeNode = currentEdge.SecondNode;
                }

                if (!spanningTree.Contains(currentEdge.FirstNode) &&
                    spanningTree.Contains(currentEdge.SecondNode))
                {
                    nonTreeNode = currentEdge.FirstNode;
                }

                if (nonTreeNode == -1)
                {
                    continue;
                }

                //My approch
                //if ((usedBudget + currentEdge.NodeWeight) > budget)
                //{
                //    return usedBudget;
                //}
                //usedBudget += currentEdge.NodeWeight;

                //Lector's approach
                if (currentEdge.NodeWeight > budget)
                {
                    break;
                }
                usedBudget += currentEdge.NodeWeight;
                budget -= currentEdge.NodeWeight;

                spanningTree.Add(nonTreeNode);
                queue.AddMany(graph[nonTreeNode]);
            }

            return usedBudget;
        }

        private static List<Edge>[] ReadGraph(int nodesCount, int edgesCount)
        {
            List<Edge>[] result = new List<Edge>[nodesCount];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<Edge>();
            }

            for (int i = 0; i < edgesCount; i++)
            {
                string[] edgeData = Console.ReadLine().Split();

                int firstNode = int.Parse(edgeData[0]);
                int secondNode = int.Parse(edgeData[1]);
                int nodeWeight = int.Parse(edgeData[2]);

                if (edgeData.Length == 4)
                {
                    spanningTree.Add(firstNode);
                    spanningTree.Add(secondNode);
                }

                Edge edge = new Edge(firstNode, secondNode, nodeWeight);

                result[firstNode].Add(edge);
                result[secondNode].Add(edge);
            }

            return result;
        }
    }
}
