using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string output=string.Empty;
            
            for (int i = 0; i < a.Length; i++)
            {
                bool topInt = false;
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        topInt = true;
                    }
                    else
                    {
                        topInt = false;
                        break;
                    }
                }
                if (topInt)
                {
                    output += a[i] + " ";
                }
            }
            output += a[a.Length - 1];

            Console.WriteLine(output);
        }
    }
}
