using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int storage = 0, count = 0;
            while (yield >= 100)
            {
                storage += yield;
                if (storage >= 26)
                {
                    storage -= 26;
                }
                yield -= 10;
                count++;
            }

            if (storage >= 26)
            {
                storage -= 26;
            }
            Console.WriteLine(count--);
            Console.WriteLine(storage);
        }
    }
}
