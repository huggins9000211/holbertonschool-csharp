using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = 1;
            while (i < 8)
            {
                while (x < 10)
                {
                    if (x > i)
                    {
                        Console.Write("{0}{1}, ", i, x);
                    }
                    x++;
                }
                x = 0;
                i++;
            }
            Console.Write("89\n");
        }
    }
}
