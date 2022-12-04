using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write((char)((int)a[i]+3));
            }
            Console.WriteLine();
        }
    }
}
