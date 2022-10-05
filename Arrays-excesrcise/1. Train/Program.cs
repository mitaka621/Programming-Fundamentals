using System;

namespace Exercise___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] wagon = new int[n];
            int sum = 0;
            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                sum += wagon[i];

            }
            foreach (var item in wagon)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
