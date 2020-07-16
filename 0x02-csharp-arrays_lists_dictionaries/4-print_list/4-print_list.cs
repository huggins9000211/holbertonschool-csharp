using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] myArr = new int[size];
        for (int i = 0; i < size; i++)
        {
            myArr[i] = i;
        }
        Console.WriteLine(string.Join(" ", array));
        return myArr;
    }
}
