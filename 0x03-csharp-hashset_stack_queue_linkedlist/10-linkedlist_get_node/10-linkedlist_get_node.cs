using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int[] iArray = new int[myLList.Count];
        myLList.CopyTo(iArray, 0);
        return iArray[n];
    }
}
