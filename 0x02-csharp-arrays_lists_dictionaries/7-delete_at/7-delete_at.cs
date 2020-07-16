using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DeleteAt(List<int> myList, int index)
        {
            try
            {
                myList.RemoveRange(index, 1);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Index is out of range");
                return myList;
            }
            return myList;
        }
    }
