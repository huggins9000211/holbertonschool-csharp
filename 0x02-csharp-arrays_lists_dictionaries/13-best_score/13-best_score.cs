using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int i = -1;
        string answer = "None";
        foreach(KeyValuePair<string, int> item in myList)
        {
            if (item.Value > i)
            {
                i = item.Value;
                answer = item.Key;
            }
        }
        return answer;
    }
}
