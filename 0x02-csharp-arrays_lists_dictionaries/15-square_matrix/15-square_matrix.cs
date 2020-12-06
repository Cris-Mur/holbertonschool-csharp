﻿using System;

class Matrix {
    public static int[,] Square(int[,] myMatrix) {
        int [,] square = new int[myMatrix.GetLength(0),myMatrix.GetLength(1)];

        for (int y = 0; y < myMatrix.GetLength(0); y++)
            for (int x = 0; x < myMatrix.GetLength(1); x++)
                square[y,x] = myMatrix[y,x] * myMatrix[y,x];

        return square;
    }
}