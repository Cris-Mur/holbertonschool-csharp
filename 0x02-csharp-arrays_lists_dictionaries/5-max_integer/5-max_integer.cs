using System;
using System.Collections.Generic;

class List {
    public static int MaxInteger(List<int> myList) {
        if (myList.Count > 0) {
            myList.Sort();
            var arr = myList.ToArray();
            return (arr[arr.Length - 1]);
        } else {
            Console.WriteLine("List is empty");
            return -1;
        }
    }
}