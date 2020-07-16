using System;

class Program
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> myL = new List<bool>();
        foreach (int x in myList)
        {
            if (x % 2 == 0)
            {
                myL.Add(true);
            }
            else
            {
                myL.Add(false);
            }
        }
    }
}

