using System;
using System.Numerics;

class VectorMath
{
    // static void Main(string[] args)
    // {
    //     double[] test = new double[] {3, 9};
    //     double[] test2 = new double[] {7, -3, -9};
    //     Console.WriteLine(Magnitude(test));
    //     Console.WriteLine(Magnitude(test2));
    // }

    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            Vector2 result = new Vector2((float)vector[0], (float)vector[1]);
            return Math.Round(result.Length(), 2);
        }
        else if (vector.Length == 3)
        {
            Vector3 result = new Vector3((float)vector[0], (float)vector[1], (float)vector[2]);
            return Math.Round(result.Length(), 2);
        }
        return(-1);
    }
}
