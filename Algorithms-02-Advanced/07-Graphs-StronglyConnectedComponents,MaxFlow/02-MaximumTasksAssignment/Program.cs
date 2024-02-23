using System;
using System.Collections.Generic;

namespace _02_MaximumTasksAssignment
{
    class Program
    {
        private static int[,] graph;
        private static int[] parents;
        static void Main(string[] args)
        {
            int workersCount = int.Parse(Console.ReadLine());
            int tasksCount = int.Parse(Console.ReadLine());

            int nodesCount = 2 + workersCount + tasksCount;

            int start = 0;
            int target = nodesCount - 1;

            graph = InitGraph(workersCount, tasksCount, nodesCount);
            parents = new int[graph.GetLength(0)];
            for (int parent = 0; parent < parents.Length; parent++)
            {
                parents[parent] = -1;
            }

            FillGraph(workersCount);

            PerformMaxFlow(workersCount, tasksCount, start, target);

            //PrintGraph();
        }

        private static void PerformMaxFlow(int workers, int tasks, int start, int target)
        {
            while (BFS(start, target))
            {
                int currentNode = target;

                while (currentNode != start)
                {
                    int parent = parents[currentNode];

                    graph[parent, currentNode] = 0;
                    graph[currentNode, parent] = 1;

                    currentNode = parent;
                }
            }

            for (int worker = 1; worker <= workers; worker++)
            {
                for (int task = workers + 1; task <= workers + tasks; task++)
                { 
                    if (graph[task, worker] > 0)
                    {
                        Console.WriteLine($"{(char)(64 + worker)}-{task - workers}");
                        break;
                    }
                }
            }
        }

        private static bool BFS(int start, int target)
        {
            bool[] visited = new bool[graph.GetLength(0)];

            Queue<int> queue = new Queue<int>();

            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();

                if (currentNode == target)
                {
                    return true;
                }

                for (int child = 0; child < graph.GetLength(1); child++)
                {
                    if (!visited[child] && graph[currentNode, child] > 0)
                    {
                        parents[child] = currentNode;
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }

            return false;
        }

        private static void FillGraph(int workersCount)
        {
            for (int i = 1; i <= workersCount; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'Y')
                    {
                        graph[i, workersCount + 1 + j] = 1;
                    }
                }
            }
        }

        private static int[,] InitGraph(int workersCount, int tasksCount, int nodesCount)
        {
            int[,] result = new int[nodesCount, nodesCount];

            for (int worker = 1; worker <= workersCount; worker++)
            {
                result[0, worker] = 1;
            }

            for (int task = workersCount + 1; task <= workersCount + tasksCount; task++)
            {
                result[task, nodesCount - 1] = 1;
            }

            return result;
        }

        public static void PrintGraph()
        {
            for (int r = 0; r < graph.GetLength(0); r++)
            {
                for (int c = 0; c < graph.GetLength(1); c++)
                {
                    Console.Write($"{graph[r, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
