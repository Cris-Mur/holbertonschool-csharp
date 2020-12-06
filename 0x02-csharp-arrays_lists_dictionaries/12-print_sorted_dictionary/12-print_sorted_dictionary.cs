using System;
using System.Collections.Generic;

class Dictionary {
    public static void PrintSorted(Dictionary<string, string> myDict) {
        List<String> keys = new List<string>();

        foreach (var line in myDict) {
            keys.Add(line.Key);
        }
        keys.Sort();
        foreach (var word in keys) {
            Console.WriteLine("{0}: {1}", word, myDict[word]);
        }
    }
}
