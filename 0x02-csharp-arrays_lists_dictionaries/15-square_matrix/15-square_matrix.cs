using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rowLength = myMatrix.GetLength(0);
        int colLength = myMatrix.GetLength(1);

        int[,] result = new int[rowLength, colLength];
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                result[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return result;
    }
}
