using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int x = 0;
        List<int> newL = new List<int>();
        foreach (int item in myList)
        {
            if (!newL.Contains(item))
            {
                newL.Add(item);
            }
        }
        foreach (int item in newL)
        {
            x += item;
        }
        return x;
    }
}
