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

class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    public new int Area()
    {
        return Width * Height;
    }

    public override String ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

class Square : Rectangle
{
    private int size;

    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
                size = value;
                Height = value;
                Width = value;
        }
    }

    public override String ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
