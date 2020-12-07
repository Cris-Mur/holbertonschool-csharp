using System;
using System.Collections.Generic;

class LList {
    public static void Delete(LinkedList<int> myLList, int index) {
        LinkedListNode<int> node = myLList.First;
        for (int idx = 0; idx < index; idx++)
            node = node.Next;
        myLList.Remove(node);
    }
}