using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            int check = a;
            int digit;
            int sum = 1;
            int sum2 = 0;
            while (a != 0)
            {
                digit = a % 10;
                a = a / 10;
                for (int i = 1; i <= digit; i++)
                {
                    sum *= i;
                }

                sum2 += sum;
                sum = 1;
            }

            if (sum2 == check)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");

        }
    }
}
