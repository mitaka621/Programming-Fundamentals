using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            int index = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();
            BigInteger sumLeft = 0, sumRight = 0; ;
            for (int i = index-1; i >=0; i--)
            {
                if (type=="cheap")
                {
                    if (items[i] < items[index])
                    {
                        sumLeft += items[i];
                    }
                }
                else
                    if (items[i] >= items[index])
                    {
                    sumLeft += items[i];
                    }
            }

            for (int i = index+1; i < items.Length; i++)
            {
                if (type == "cheap")
                {
                    if (items[i] < items[index])
                    {
                        sumRight += items[i];
                    }
                }
                else
                    if (items[i] >= items[index])
                {
                    sumRight += items[i];
                }
            }

            if (sumRight>sumLeft)
            {
                Console.WriteLine("Right - {0}",sumRight);
            }
            else
                Console.WriteLine("Left - {0}",sumLeft);
        }
    }
}
