using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Add_and_Subtract
{
    internal class Program
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b, int c)
        {
            return sum(a, b) - c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
