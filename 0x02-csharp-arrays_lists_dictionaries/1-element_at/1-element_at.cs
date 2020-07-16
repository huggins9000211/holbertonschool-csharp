using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int x;
        try
        {
            x = (int)array.GetValue(index);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");
            return(-1);
        }
        return (x);
    }
}
