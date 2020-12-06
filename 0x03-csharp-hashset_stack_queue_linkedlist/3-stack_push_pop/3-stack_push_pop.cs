using System;
using System.Collections.Generic;

class MyStack {
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search) {
        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());
        bool answ = aStack.Contains(search);
        Console.WriteLine("Stack contains {0}: {1}", search, answ);
        if (answ) {
            while (aStack.Pop() != search) {
                continue;
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}