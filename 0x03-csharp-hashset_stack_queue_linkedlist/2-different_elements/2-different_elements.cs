using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements(List<int> list1, List<int> list2) {
        List<int> Nlist = new List<int>();
        foreach (var value1 in list1)
            foreach (var value2 in list2) {
                if (!list2.Contains(value1) && !Nlist.Contains(value1)) {
                    Nlist.Add(value1);
                } else if (!list1.Contains(value2) && !Nlist.Contains(value2)) {
                    Nlist.Add(value2);
                }
            }
        Nlist.Sort();
        return Nlist;
    }
}