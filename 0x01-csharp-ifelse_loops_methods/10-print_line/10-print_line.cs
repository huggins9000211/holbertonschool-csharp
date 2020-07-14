using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            int i = 0;
            while (i < length)
            {
                Console.Write("_");
                i++;
            }
        }
        Console.Write("\n");
    }
}
