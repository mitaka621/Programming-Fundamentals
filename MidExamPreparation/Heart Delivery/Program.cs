using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] k = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input;
            int currentIndex = 0, nextJump = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] inp = input.Split().ToArray();
                int lenght = int.Parse(inp[1]);
                if (lenght + currentIndex >= k.Length)
                {
                    currentIndex = 0;
                    lenght = 0;
                }
                nextJump = currentIndex + lenght;
                currentIndex = nextJump;
                if (k[nextJump] == 0)
                {
                    Console.WriteLine("Place {0} already had Valentine's day.", nextJump);
                }
                else
                {
                    k[nextJump] -= 2;
                    if (k[nextJump] == 0)
                    {
                        Console.WriteLine("Place {0} has Valentine's day.", nextJump);
                    }
                }
            }
            Console.WriteLine("Cupid's last position was {0}.", nextJump);
            if (k.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < k.Length; i++)
                {
                    if (k[i]!=0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Cupid has failed {0} places.",count);
            }
        }
    }
}
