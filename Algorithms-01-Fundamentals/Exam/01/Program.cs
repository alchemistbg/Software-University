using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    public class Tunnel
    {
        public int Size { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] map = ReadMap(rows, cols);
            bool[,] visited = new bool[rows, cols];

            List<Tunnel> tunnelsList = new List<Tunnel>();

            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    if (visited[r, c])
                    {
                        continue;
                    }

                    if (map[r, c] == 't')
                    {
                        //continue;
                        int tunnelSize = GetTunnelSize(map, r, c, visited);

                        Tunnel tunnel = new Tunnel { Row = r, Col = c, Size = tunnelSize };
                        tunnelsList.Add(tunnel);
                    }

                }
            }

            //List<Tunnel> sortedTunnel = tunnelsList.OrderByDescending(a => a.Size)
            //    .ThenBy(a => a.Row)
            //    .ThenBy(a => a.Col)
            //    .ToList();

            //Console.WriteLine($"Total tunnels found: {sortedTunnel.Count}");
            //for (int i = 0; i < sortedTunnel.Count; i++)
            //{
            //    Console.WriteLine($"Area #{i + 1} at ({sortedTunnel[i].Row}, {sortedTunnel[i].Col}), size: {sortedTunnel[i].Size}");
            //}

            Console.WriteLine(tunnelsList.Count);
        }

        private static int GetTunnelSize(char[,] map, int row, int col, bool[,] visited)
        {
            if (IsOutside(map, row, col))
            {
                return 0;
            }

            if (visited[row, col])
            {
                return 0;
            }

            visited[row, col] = true;

            if (map[row, col] == 'd')
            {
                return 0;
            }

            return 1 +
                GetTunnelSize(map, row + 1, col, visited) +
                GetTunnelSize(map, row - 1, col, visited) +
                GetTunnelSize(map, row, col + 1, visited) +
                GetTunnelSize(map, row, col - 1, visited) +
                GetTunnelSize(map, row + 1, col + 1, visited) +
                GetTunnelSize(map, row - 1, col - 1, visited) +
                GetTunnelSize(map, row + 1, col - 1, visited) +
                GetTunnelSize(map, row - 1, col + 1, visited);
        }

        private static bool IsOutside(char[,] matrix, int row, int col)
        {
            return row < 0 ||
                   row >= matrix.GetLength(0) ||
                   col < 0 ||
                   col >= matrix.GetLength(1);
        }

        private static char[,] ReadMap(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < line.Length; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            return matrix;
        }
    }
}
