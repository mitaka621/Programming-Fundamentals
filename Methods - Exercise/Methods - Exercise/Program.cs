using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercise
{
    internal class Program
    {
        public static int smallestNum(int[] a)
        {
            return a.Min();
        }
        static void Main(string[] args)
        {

            int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(smallestNum(a));
        }
    }
}
