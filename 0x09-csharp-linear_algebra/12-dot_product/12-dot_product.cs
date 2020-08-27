﻿using System;

/// <summary>
/// 
/// </summary>
class VectorMath
{
    // static void Main(string[] args)
    // {
    //     double[] test = new double[] {3, 9};
    //     double[] test2 = new double[] {7, -3, -9};
    //     Console.WriteLine(Magnitude(test));
    //     Console.WriteLine(Magnitude(test2));
    // }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector.Length == 2)
        {
            return (vector1[0] * vector2[0] + vector1[1] * vector2[1]);
        }
        else if (vector.Length == 3)
        {
            return (vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2]);
        }
        return(-1);
    }
}
