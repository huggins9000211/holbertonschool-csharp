using System;


class Int
{
    public static void divide(int a, int b)
    {
        
        int x = 0;
        try
        {
            //Console.Write("*****");
            x = a/b;
            //Console.WriteLine(x);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            //Console.WriteLine(x);
            Console.WriteLine("{0} / {1} = {2}", a, b, x);
        }
        
    }
}
