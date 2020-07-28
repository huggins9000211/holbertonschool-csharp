using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
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
