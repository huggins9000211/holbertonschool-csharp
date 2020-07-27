using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int[] iArray = new int[myLList.Count];
        myLList.CopyTo(iArray, 0);
        int i = 0;
        foreach (int x in iArray)
        {
            i += x;
        }
        return i;
    }
}
