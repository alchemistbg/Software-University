using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Box
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Height { get; set; }

        public Box(int width, int depth, int height)
        {
            Width = width;
            Depth = depth;
            Height = height;
        }

        public override string ToString()
        {
            return $"{this.Width} {this.Depth} {this.Height}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int boxesCount = int.Parse(Console.ReadLine());
            Box[] boxes = ReadBoxes(boxesCount);

            int[] lengths = new int[boxes.Length];
            int[] prevs = new int[boxes.Length];

            int bestStackLength = 0;
            int bestStackIndex = 0;

            for (int b = 0; b < boxes.Length; b++)
            {
                prevs[b] = -1;

                Box currentBox = boxes[b];
                int currentBestSeq = 1;

                for (int i = b - 1; i >= 0; i--)
                {
                    Box prevBox = boxes[i];

                    if (prevBox.Width < currentBox.Width && prevBox.Depth < currentBox.Depth && prevBox.Height < currentBox.Height && lengths[i] + 1 > currentBestSeq)
                    {
                        currentBestSeq = lengths[i] + 1;
                        prevs[b] = i;
                    }
                }

                if (currentBestSeq > bestStackLength)
                {
                    bestStackLength = currentBestSeq;
                    bestStackIndex = b;
                }

                lengths[b] = currentBestSeq;
            }
            ;
            
            Stack<Box> stack = new Stack<Box>();
            while (bestStackIndex != -1)
            {
                stack.Push(boxes[bestStackIndex]);
                bestStackIndex = prevs[bestStackIndex];
            }

            foreach (Box box in stack)
            {
                Console.WriteLine(box);
            }
        }

        private static Box[] ReadBoxes(int boxesCount)
        {
            Box[] result = new Box[boxesCount];
            for (int i = 0; i < boxesCount; i++)
            {
                int[] boxData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int width = boxData[0];
                int depth = boxData[1];
                int height = boxData[2];
                Box box = new Box(width, depth, height);

                result[i] = box;
            }

            return result;
        }
    }
}
