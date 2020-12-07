using System;
using System.Collections.Generic;

class LList {
    public static int GetNode(LinkedList<int> myLList, int n) {
        if (myLList.Count >= n) {
            int idx = 0;
            foreach (var coso in myLList) {
                if (idx == n)
                    return coso;
                idx++;
            }
        }
        return 0;
    }
}