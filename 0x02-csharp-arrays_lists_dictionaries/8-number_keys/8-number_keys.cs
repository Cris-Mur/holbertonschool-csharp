using System;
using System.Collections.Generic;

class Dictionary {
    public static int NumberOfKeys(Dictionary<string, string> myDict) {
        int num = 0;
        if (myDict != null) {
            foreach (KeyValuePair<string, string> ks in myDict)
                num++;
        }
        return (num);
    }
}