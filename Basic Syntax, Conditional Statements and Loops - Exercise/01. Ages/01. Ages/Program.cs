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

            if (a <= 2)
            {
                Console.WriteLine("baby");
            }
            else
                if (a <= 13)
            {
                Console.WriteLine("child");
            }
            else
                if (a <= 19)
            {
                Console.WriteLine("teenager");
            }
            else
                if (a <= 65)
            {
                Console.WriteLine("adult");
            }
            else
                Console.WriteLine("elder");
        }
    }
}