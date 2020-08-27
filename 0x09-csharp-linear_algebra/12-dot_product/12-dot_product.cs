using System;

/// <summary>
/// 
/// </summary>
class VectorMath
{
    static void Main(string[] args)
    {
        double[] test = new double[] {1, 3};
        double[] test2 = new double[] {-2, 5};
        Console.WriteLine(DotProduct(test, test2));
    }

    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double a = vector1[0] * vector2[0];
            double b = vector1[1] * vector2[1];
            return (a + b);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]));
        }
        return(-1);
    }
}
