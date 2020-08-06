using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// 
/// </summary>
class Obj
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();
        PropertyInfo[] pList = t.GetProperties();
        MethodInfo[] mList = t.GetMethods();
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (MethodInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}
