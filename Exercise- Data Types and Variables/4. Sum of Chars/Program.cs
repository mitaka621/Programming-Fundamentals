﻿using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char ch=char.Parse(Console.ReadLine());
                sum += (int)ch;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
