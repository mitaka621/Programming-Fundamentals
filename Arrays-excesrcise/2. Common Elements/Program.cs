using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] a=Console.ReadLine().Split(' ');

            string[] b = Console.ReadLine().Split(' ');

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                        Console.Write(b[i]+" ");
                }
            }
            Console.WriteLine();
        }
        
    }
}
