using System;
using System.Collections.Generic;

class List {
    public static List<bool> DivisibleBy2(List<int> myList) {
        var res = new List<bool>();
        foreach (int dat in myList) {
            if ((dat % 2) == 0)
                res.Add(true); 
            else
                res.Add(false);
        }
        return res;
    }
}