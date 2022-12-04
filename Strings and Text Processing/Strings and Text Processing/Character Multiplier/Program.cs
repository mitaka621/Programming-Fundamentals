using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    internal class Program
    {
        public static int sumStrings(string a, string b)
        {
            int sum = 0;
            if (a.Length < b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (a.Length - 1 < i)
                    {
                        sum += (int)b[i];
                    }
                    else
                        sum += (int)a[i] * (int)b[i];  
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (b.Length - 1 < i)
                    {
                        sum += (int)a[i];
                    }
                    else
                        sum += (int)a[i] * (int)b[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {

            string[] a = Console.ReadLine().Split();


            Console.WriteLine(sumStrings(a[0], a[1]));
        }
    }
}
