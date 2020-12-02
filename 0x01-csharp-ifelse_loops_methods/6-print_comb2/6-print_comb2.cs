using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 10; n++)
                for (int i = n + 1; i < 10; i++) {
                    if (n != i) {
                        Console.Write("{0:d}", n);
                        if (n == 8) {
                            Console.WriteLine("{0}", i);
                        } else {
                            Console.Write("{0:d}", i);
                        }
                    }
        }
    }
}
