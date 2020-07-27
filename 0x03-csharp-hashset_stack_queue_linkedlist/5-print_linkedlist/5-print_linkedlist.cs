using System;
using System.Linq;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newL = new LinkedList<int>();
        foreach (int value in Enumerable.Range(0, size))
        {
            Console.WriteLine(value);
            newL.AddLast(value);
        }
        return newL;
    }
}
