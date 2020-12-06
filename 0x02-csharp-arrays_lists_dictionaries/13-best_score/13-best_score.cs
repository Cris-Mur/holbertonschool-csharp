using System;
using System.Collections.Generic;

class Dictionary {
    public static string BestScore(Dictionary<string, int> myList) {
        String name = "None";

        if (myList.Count > 0) {
            int best = 0;
            foreach (KeyValuePair<string, int> row in myList)
                if (best <= row.Value) {
                    best = row.Value;
                    name = row.Key;
                }
        }

        return name;
    }
}