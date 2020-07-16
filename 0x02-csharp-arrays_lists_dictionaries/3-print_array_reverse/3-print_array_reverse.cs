using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
               int tmp = array[i];
               array[i] = array[array.Length - i - 1];
               array[array.Length - i - 1] = tmp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
