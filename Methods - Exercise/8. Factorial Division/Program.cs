using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Factorial_Division
{
    internal class Program
    {
        public static long factoriel(long a)
        {
            long num = 1;
            for (int i = 1; i <= a; i++)
            {
                num *= i;
            }
            return num;
        }
        static void Main(string[] args)
        {
            long a=factoriel(long.Parse(Console.ReadLine()));
            long b = factoriel(long.Parse(Console.ReadLine()));

            Console.WriteLine("{0:0.00}", a/(double)b);
        }
    }
}
