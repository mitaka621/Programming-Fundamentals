using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int input= int.Parse(Console.ReadLine());
                sum += input;
                if (sum>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= input;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
