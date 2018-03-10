using System;

namespace AdaptiveRouting
{
    class Program
    {
        private static readonly int[,] InputMap =
        {
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            {-1, 0,-1, 0, 0, 0,-1, 0, 0,-1},
            {-1, 0, 0, 0,-1, 0,-1,-1, 0,-1},
            {-1,-1,-1, 0,-1, 0, 0, 0, 0,-1},
            {-1, 0, 0, 0, 0, 0,-1,-1, 0,-1},
            {-1, 0,-1,-1,-1, 0,-1, 0, 0,-1},
            {-1, 0, 0,-1,-1, 0,-1,-1, 0,-1},
            {-1,-1, 0,-1, 0, 0, 0,-1, 0,-1},
            {-1, 0, 0, 0, 0,-1, 0, 0, 0,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}

        };
        static void Main(string[] args)
        {
            PathFinder finder = new PathFinder();
            var map = finder.GetMapDistance(InputMap, new Node(1, 1));
            PrintMap(map);
            Console.ReadKey();
        }

        static void PrintMap(int[,] map) {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                    Console.Write(map[i, j] == -1 ? "@@" : map[i, j] < 10 ? $" {map[i, j]}" : $"{map[i, j]}");
                Console.WriteLine();
            }
                       
        }

    }
}
