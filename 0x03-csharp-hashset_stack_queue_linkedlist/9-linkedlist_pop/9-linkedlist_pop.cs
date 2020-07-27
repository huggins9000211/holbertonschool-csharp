using System;
using System.Collections.Generic;
class LList
{
    public static int Pop(LinkedList<int> myLList)
    {

        LinkedListNode<int> x = myLList.First;
        try
        {
            myLList.RemoveFirst();
        }
        catch (InvalidOperationException)
        {
            return 0;
        }
        return x.Value;
    }
}
