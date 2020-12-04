using System;
using System.Collections.Generic;

class Dictionary {
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict) {
        Dictionary<string, int> mult = new Dictionary<string, int>();
        foreach (var dict in myDict) {
            mult[dict.Key] = dict.Value * 2;
        }
        return mult;
    }
}
