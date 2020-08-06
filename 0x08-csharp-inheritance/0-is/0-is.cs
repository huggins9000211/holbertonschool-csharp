using System;

/// <summary>
/// 
/// </summary>
class Obj
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
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
