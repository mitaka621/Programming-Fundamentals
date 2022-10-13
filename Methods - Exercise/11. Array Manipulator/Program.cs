using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ',(char)StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
