﻿using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i < 123; i++)
            {
                if (i != 101 && i != 113)
                {
                    Console.Write((char)i);
                }
            }
        }
    }
}
