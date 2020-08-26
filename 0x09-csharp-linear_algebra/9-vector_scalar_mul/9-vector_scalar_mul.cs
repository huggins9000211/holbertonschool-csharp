using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] resut = new double[] {vector[0] * scalar, vector[1] * scalar};
            return (resut);
        }
        else if (vector.Length == 3)
        {
            double[] resut = new double[] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
            return (resut);
        }
        return(new double[] {-1});
    }
}
