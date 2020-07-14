using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 99)
            {
                Console.Write("{0}, ", i.ToString("D2"));
                i++;
            }
            Console.Write("99\n");
        }
    }
}
