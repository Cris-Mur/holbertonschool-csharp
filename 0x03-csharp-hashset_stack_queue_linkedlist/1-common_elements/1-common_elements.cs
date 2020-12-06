using System;
using System.Collections.Generic;

class List{
    public static List<int> CommonElements(List<int> list1, List<int> list2) {
        List<int> Nlist = new List<int>();
        foreach (var value in list1)
            if (list2.Contains(value)) {
                Nlist.Add(value);
            }
        return Nlist;
    }
}