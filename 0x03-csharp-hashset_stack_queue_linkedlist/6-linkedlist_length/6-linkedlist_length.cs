using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int i = 0;
        while (true)
        {
            try
            {
                myLList.RemoveFirst();
                i ++;
            }
            catch (InvalidOperationException)
            {
                return i;
            }
        }
    }
}
