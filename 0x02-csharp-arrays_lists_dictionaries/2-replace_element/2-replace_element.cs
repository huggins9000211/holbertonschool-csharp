using System;

    class Array
    {
        public static int[] ReplaceElement(int[] array, int index, int n)
        {
            try
            {
                array.SetValue(n, index);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
                return(array);
            }
            return (array);
        }
    }
