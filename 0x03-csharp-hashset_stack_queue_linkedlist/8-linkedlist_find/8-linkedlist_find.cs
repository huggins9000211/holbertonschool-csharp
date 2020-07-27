using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int[] iArray = new int[myLList.Count];
        myLList.CopyTo(iArray, 0);
        int x = Array.IndexOf(iArray, value);
        return x;
    }
}
