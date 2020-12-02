using System;

class Array {
    public static void Reverse(int[] array) {
        if (array != null) {
            for (int idx = array.Length - 1; idx >= 0; idx--) {
                Console.Write($"{array[idx]}");
                if (idx != 0) {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}