using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == 2 && matrix2.Length == 2)
        {
            double[,] result = new double[,] { {matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1]},
            {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1]}};
        }
        else if (matrix1.Length == 3 && matrix2.Length == 3)
        {
            double[,] result = new double[,] { {matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1], matrix1[0,2] + matrix2[0,2]},
            {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1], matrix1[1,2] + matrix2[1,2]}, 
            {matrix1[2,0] + matrix2[2,0], matrix1[2,1] + matrix2[2,1], matrix1[2,2] + matrix2[2,2]}};
        }
        return new double[,] { {0} };
    }
}
