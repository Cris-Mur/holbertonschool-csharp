using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ch = 'a'; ch <= 'z'; ch++) {
                if (ch != 'q' && ch != 'e')
                    Console.Write(ch);
            }
        }
    }
}
