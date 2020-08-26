using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] resut = new double[] {vector1[0] * scalar, vector1[1] * scalar};
            return (resut);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] resut = new double[] {vector1[0] * scalar, vector1[1] * scalar, vector1[2] * scalar};
            return (resut);
        }
        return(new double[] {-1});
    }
}
