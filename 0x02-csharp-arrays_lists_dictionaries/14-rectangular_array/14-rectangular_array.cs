using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] map = new int [5,5];
            map[2,2] = 1;
            for (int y = 0; y < 5; y++) {
                for (int x = 0; x < 5; x++) {
                    Console.Write(map[y,x]);
                    if (x != 4)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
