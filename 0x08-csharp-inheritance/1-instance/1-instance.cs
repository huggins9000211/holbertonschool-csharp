using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        return false;
    }
}
