using System;

class VectorMath
{
    static void Main(string[] args)
    {
        double[] test = new double[] {3, 9};
        double[] test2 = new double[] {7, -3};
        double[] resut = Add(test, test2);
        foreach(var item in resut)
            {
                Console.WriteLine(item);
            }
    }
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] resut = new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
            return (resut);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] resut = new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
            return (resut);
        }
        return(new double[] {-1});
    }
}
