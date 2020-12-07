using System;
using System.Collections.Generic;

class LList {
    public static int FindNode(LinkedList<int> myLList, int value) {
        int idx = 0;
        foreach (var answ in myLList) {
            if (answ == value) {
                return idx;
            } else
                idx++;
        }
    idx = -1;
        return idx;
    }
}