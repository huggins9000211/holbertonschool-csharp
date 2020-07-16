using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] myArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i == size - 1)
            {
                Console.Write(i);
                myArray[i] = i;
            }
            else
            {
                Console.Write("{0} ", i);
                myArray[i] = i;
            }
            
        }
        Console.WriteLine();
        return myArray;
    }
}
