using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isEqual = false;
            for (int i = 0; i < num.Length; i++)
            {
                int sumLeft = 0, sumRight = 0;
                for (int j = i+1; j < num.Length; j++)
                {
                    sumRight+=num[j];
                }

                for (int k = 0; k < i; k++)
                {
                    sumLeft += num[k];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }
            if (isEqual==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
