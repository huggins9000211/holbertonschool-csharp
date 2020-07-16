using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        Dictionary<string, string>.KeyCollection keyColl = myDict.Keys;

        // The elements of the KeyCollection are strongly typed
        // with the type that was specified for dictionary keys.
        int i = 0;
        foreach( string s in keyColl )
        {
            i++;
        }
        return i;
    }
}
