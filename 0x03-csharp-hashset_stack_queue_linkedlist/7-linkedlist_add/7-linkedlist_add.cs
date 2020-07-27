using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> x = myLList.AddFirst(n);
        return x;
    }
}
