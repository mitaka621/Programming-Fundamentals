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

            string num = "Not divisible";
            if (a % 2 == 0)
            {
                num = "2";
            }

            if (a % 3 == 0)
            {
                num = "3";
            }

            if (a % 6 == 0)
            {
                num = "6";
            }

            if (a % 7 == 0)
            {
                num = "7";
            }

            if (a % 10 == 0)
            {
                num = "10";
            }

            if (num == "Not divisible")
            {
                Console.WriteLine(num);
            }
            else
                Console.WriteLine("The number is divisible by {0}", num);
        }
    }
}
