using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            int i = 0;
            while (i < length)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\\n");
                i++;
            }
        }
        Console.Write("\n");
    }
}
