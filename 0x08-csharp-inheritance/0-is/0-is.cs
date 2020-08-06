using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        Type t = obj.GetType();
        if (t == typeof(int))
        {
            return true;
        }
        return false;
    }
}
