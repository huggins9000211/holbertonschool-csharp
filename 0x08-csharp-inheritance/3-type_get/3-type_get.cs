using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (PropertyInfo p in pList)
        {
            if (!p.Name.Contains("System."))
            {
                Console.WriteLine(p.Name);
            }
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (MethodInfo m in mList)
        {
            if (!m.Name.Contains("System."))
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
