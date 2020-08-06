using System;
using System.Collections.Generic;
using System.Reflection;

class Shape 
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
