using System;

class MatrixMath
{
    public static void Main()
    {
        double[,] matrix = { { 14, -3, 0 }, { -11, -5, 3 }, {2, -9, 13} };
        double[,] matrix2 = { { 6, 16, 21 }, { 5, 2, 0 }, {1, 3, 7} };
        double[,] result = Add(matrix, matrix2);
        if (matrix.Length == 4 && matrix2.Length == 4)
        {

        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
            // foreach (var item2 in item)
            // {
            // }
        }
    }
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.Length == 4) && (matrix2.Length == 4))
        {
            double[,] result = new double[,] { {matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1]},
            {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1]}};
            return result;
        }
        else if (matrix1.Length == 9 && matrix2.Length == 9)
        {
            double[,] result = new double[,] { {matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1], matrix1[0,2] + matrix2[0,2]},
            {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1], matrix1[1,2] + matrix2[1,2]}, 
            {matrix1[2,0] + matrix2[2,0], matrix1[2,1] + matrix2[2,1], matrix1[2,2] + matrix2[2,2]}};
            return result;
        }
        return new double[,] { {-1} };
    }
}
