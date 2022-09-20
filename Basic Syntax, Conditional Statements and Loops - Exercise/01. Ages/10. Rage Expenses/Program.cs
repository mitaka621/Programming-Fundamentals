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

            int lostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());

            double mousePrice = double.Parse(Console.ReadLine());

            double keyboardPrice = double.Parse(Console.ReadLine());

            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0, mouseCount = 0, keyboardCount = 0, displayCount = 0;


            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                }

            }

            for (int i = 1; i <= keyboardCount; i++)
            {
                if (i % 2 == 0)
                {
                    displayCount++;
                }
            }

            Console.WriteLine("Rage expenses: {0:0.00} lv.", headsetCount * headsetPrice + mouseCount * mousePrice +
                keyboardCount * keyboardPrice + displayCount * displayPrice);

        }
    }
}