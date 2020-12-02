using System;

class Array {
    public static int[] ReplaceElement(int[] array, int index, int n) {
        try {
            array[index] = n;
        }
        catch (System.IndexOutOfRangeException) {
            Console.WriteLine("Index out of range");

        }
        return (array);
    }
}