using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            int x = 0;
            try
            {
                //Console.Write("*****");
                x = list1[i]/list2[i];
                //Console.WriteLine(x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                return result;
            }
            finally
            {
                result.Add(x);
            }
        }
        return result;
    }
}
