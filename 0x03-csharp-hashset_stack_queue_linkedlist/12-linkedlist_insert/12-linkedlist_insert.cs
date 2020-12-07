using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n) {
        LinkedListNode<int> head = myLList.First;
        while (head != null) {
            if (head.Value > n)
                return myLList.AddBefore(head, n);
            head = head.Next;
        }
        return myLList.AddLast(n);
    }
}