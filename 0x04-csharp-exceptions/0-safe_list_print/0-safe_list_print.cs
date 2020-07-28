using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        while (i < n)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch (System.Exception)
            {
                return i;
            }
            i++;
        }
        return i;
    }
}
