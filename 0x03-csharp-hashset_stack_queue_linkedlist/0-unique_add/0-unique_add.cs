using System;
using System.Collections.Generic;

class List {
    public static int Sum(List<int> myList) {
        HashSet<int> list = new HashSet<int>(myList);
        int ans = 0;
        foreach (var value in list)
            ans += value; 
        return ans;
    }
}