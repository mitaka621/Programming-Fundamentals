using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    if (sum == num[i] + num[j])
                    {
                        Console.WriteLine(num[i]+" "+ num[j]);
                    }
                }
            }
        }
    }
}
