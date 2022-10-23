using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            double avr = arr.Sum() / (double)arr.Length;
            bool top = false;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>avr&&count<5)
                {
                    Console.Write(arr[i]+" ");
                    top = true;
                    count++;
                }
            }
            if (top==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
