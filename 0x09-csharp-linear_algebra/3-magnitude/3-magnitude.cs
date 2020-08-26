using System;


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
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 1);
        }
        else if (vector.Length == 3)
        {
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 1);
        }
        return(-1);
    }
}
