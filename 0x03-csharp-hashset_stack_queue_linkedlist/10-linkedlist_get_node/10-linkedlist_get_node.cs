using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int[] iArray = new int[myLList.Count];
        myLList.CopyTo(iArray, 0);
        try
        {
            return iArray[n];
        }
        catch (System.Exception)
        {
            return 0;
        }
    }
}
