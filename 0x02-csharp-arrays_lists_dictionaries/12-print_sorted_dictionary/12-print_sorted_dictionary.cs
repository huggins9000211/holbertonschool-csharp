using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> kList = new List<string>(myDict.Keys);
        kList.Sort();

        foreach (var key in kList)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
