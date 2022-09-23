using System;

namespace Exercise__Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());

            int num4 = int.Parse(Console.ReadLine());

            long sum = (long)num1 + num2;
            long dev = sum / num3;
            long mult = dev * num4;
            Console.WriteLine(mult);
        }
    }
}
