using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Characters_in_Range
{
    internal class Program
    {
        public static void charachterInRange(char a, char b)
        {
            int askiA = (int)a;
            int askiB = (int)b;
            int temp = 0;
            if (askiB < askiA)
            {
                temp = askiA;
                askiA = askiB;
                askiB = temp;
            }

            for (int i = askiA + 1; i < askiB; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            charachterInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
    }
}
