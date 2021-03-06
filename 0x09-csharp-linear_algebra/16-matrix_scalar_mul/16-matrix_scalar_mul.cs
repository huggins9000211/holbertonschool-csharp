﻿using System;

class MatrixMath
{
    // public static void Main()
    // {
    //     double[,] matrix = { { -13, 10, 8 }, { 2, 0, 14 }, {-4, -5, 2} };
    //     double[,] matrix2 = { { 6, 16, 21 }, { 5, 2, 0 }, {1, 3, 7} };
    //     double[,] result = MultiplyScalar(matrix, 4);
    //     if (matrix.Length == 4 && matrix2.Length == 4)
    //     {

    //     }

    //     foreach (var item in result)
    //     {
    //         Console.WriteLine(item);
    //         // foreach (var item2 in item)
    //         // {
    //         // }
    //     }
    // }
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.Length == 4))
        {
            double[,] result = new double[,] { {matrix[0,0] *scalar, matrix[0,1] *scalar},
            {matrix[1,0] *scalar, matrix[1,1] *scalar}};
            return result;
        }
        else if (matrix.Length == 9)
        {
            double[,] result = new double[,] { {matrix[0,0] *scalar, matrix[0,1] *scalar, matrix[0,2] *scalar},
            {matrix[1,0] *scalar, matrix[1,1] *scalar, matrix[1,2] *scalar}, 
            {matrix[2,0] *scalar, matrix[2,1] *scalar, matrix[2,2] *scalar}};
            return result;
        }
        return new double[,] { {-1} };
    }
}
