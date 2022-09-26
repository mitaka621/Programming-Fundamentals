using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//poke power
            int M = int.Parse(Console.ReadLine());//distance target
            int Y = int.Parse(Console.ReadLine());//exhaustion factor
            int originValueN = N;
            int countPoke = 0;

            while (N >= M)
            {
                N -= M;
                countPoke++;
                if (N == originValueN / 2.0 && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(countPoke);
        }
    }
}