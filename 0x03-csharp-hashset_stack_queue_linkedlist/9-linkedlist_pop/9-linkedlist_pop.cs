﻿using System;
using System.Collections.Generic;

class LList {
    public static int Pop(LinkedList<int> myLList) {
        if (myLList.Count > 0) {
            int pop = myLList.First.Value;
            myLList.RemoveFirst();
            return pop;
        }
        return 0;
    }
}