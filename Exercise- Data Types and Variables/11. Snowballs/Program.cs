using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int bestSnow = 0, bestTime = 1, bestQuallity = 0;
            BigInteger SnowballValue = 0, bestValue = 0;
            for (int i = 0; i < N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuallity = int.Parse(Console.ReadLine());

                SnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuallity);

                if (SnowballValue >= bestValue)
                {
                    bestValue = SnowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuallity = snowballQuallity;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuallity})");

        }
    }
}
