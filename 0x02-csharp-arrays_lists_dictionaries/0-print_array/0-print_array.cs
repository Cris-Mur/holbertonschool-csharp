using System;

class Array {
    public static int[] CreatePrint(int size) {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        int[] array = new int[size];
        for (int n = 0; n < size; n++)
        {
            array[n] = n;
            if (n < (size - 1))
            {
                Console.Write("{0} ", n);
            }
            else
                Console.WriteLine(n);
        }
        return (array);
    }
}