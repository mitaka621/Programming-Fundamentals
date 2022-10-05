using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a=new int[n];
            int[]b=new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    a[i] = input[0];
                    b[i] = input[1];
                }
                else
                {
                    a[i] = input[1];
                    b[i] = input[0];
                }

            }

            foreach (var item in a)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in b)
            {
                Console.Write(item+" ");
                
            }
            Console.WriteLine();
        }
    }
}
