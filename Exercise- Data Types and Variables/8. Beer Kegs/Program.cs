using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte n = byte.Parse(Console.ReadLine());

            double biggest = long.MinValue;

            double volume = 0;

            string biggestModel = null;

            for (int i = 0; i < n; i++)
            {
                string model=Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                uint hight = uint.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * hight;

                if (volume>biggest)
                {
                    biggest = volume;
                    biggestModel = model;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
