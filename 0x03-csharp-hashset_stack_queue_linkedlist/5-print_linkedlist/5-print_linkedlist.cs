using System;
using System.Collections.Generic;

class LList {
    public static LinkedList<int> CreatePrint(int size) {
        LinkedList<int> cosa = new LinkedList<int>();
        if ((size > 0)) {
            for (int sz = 0; sz < size; sz++) {
                cosa.AddLast(sz);
                Console.WriteLine(cosa.Last.Value);
            }
        }
        return cosa;
    }
}