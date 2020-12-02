using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        var list = new List<int>();

        for (int z = 0; z < size; z++) {
            list.Add(z);
            if (z < size - 1)
                Console.Write(z + " ");
            else
                Console.WriteLine(z);
        }

        return (list);
    }
}