﻿using System;
using System.Collections.Generic;
using System.Reflection;

class Shape 
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    public string Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0")
            else
                width = value;
        }
    }

    public string Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0")
            else
                height = value;
        }
    }
}
