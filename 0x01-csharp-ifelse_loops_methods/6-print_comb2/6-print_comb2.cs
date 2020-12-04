using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 9; n++)
                for (int i = n + 1; i <= 9; i++) {
                    if (n != i && n < i) {
                        Console.Write("{0}{1}", n, i);
                        if (n != 8 || i != 9) {
                            Console.Write(", ");
                        }
                    }
                }
            Console.WriteLine();
        }
    }
}
