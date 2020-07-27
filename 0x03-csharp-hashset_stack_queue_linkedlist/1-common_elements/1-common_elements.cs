using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newL = new List<int>();
        list1.Sort();
        foreach (int item in list1)
        {
            if (list2.Contains(item))
            {
                newL.Add(item);
            }
        }
        return newL;
    }
}
