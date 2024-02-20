using System;
using System.Collections.Generic;

namespace _04_Salaries
{
    class Program
    {
        private static List<int>[] graph;

        static void Main(string[] args)
        {
            int inputCounter = int.Parse(Console.ReadLine());

            graph = ReadGraph(inputCounter);

            int totalSalary = 0;
            for (int node = 0; node < graph.Length; node++)
            {
                int salary = CalcSalary(node);
                totalSalary += salary;
            }

            Console.WriteLine(totalSalary);
        }

        private static int CalcSalary(int node)
        {
            List<int> children = graph[node];
            if (children.Count == 0)
            {
                return 1;
            }

            int salary = 0;
            foreach (int child in children)
            {
                salary += CalcSalary(child);
            }
            return salary;
        }

        private static List<int>[] ReadGraph(int inputCounter)
        {
            List<int>[] result = new List<int>[inputCounter];

            for (int i = 0; i < inputCounter; i++)
            {
                List<int> children = new List<int>();

                string line = Console.ReadLine();
                
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'Y')
                    {
                        children.Add(j);
                    }
                }

                result[i] = children;
            }

            return result;
        }
    }
}
