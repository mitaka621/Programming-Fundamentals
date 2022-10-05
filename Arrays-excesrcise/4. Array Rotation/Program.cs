using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n=int.Parse(Console.ReadLine());

            int[] arr = new int[input.Length];
            for (int i = 0; i < n; i++)
            {
                arr[arr.Length-1] = input[0];
                for (int j = input.Length-1; j >0 ; j--)
                {
                    arr[j-1]=input[j];
                }

                for (int k = 0; k < input.Length; k++)
                {
                    input[k] = arr[k];
                }
            }

            foreach (var item in input)
            {
                Console.Write(item+" ");
            }
        }
    }
}
