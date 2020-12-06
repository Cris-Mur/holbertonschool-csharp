using System;
using System.Collections.Generic;

class LList {
    public static int Length(LinkedList<int> myLList) {
        int ret = 0;
        foreach (var count in myLList)
            ret++;
        return ret;
    }
}