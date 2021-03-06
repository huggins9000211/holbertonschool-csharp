﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> copy = new Dictionary<string, int>(myDict);
        foreach(KeyValuePair<string, int> item in myDict)
        {
            copy[item.Key] = item.Value * 2;
        }
        return copy;
    }
}
