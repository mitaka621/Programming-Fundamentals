using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)people/capacity));
        }
    }
}
