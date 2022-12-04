using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ".ToCharArray()).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 3 && input[i].Length<=16)
                {
                    bool g = true;
                    foreach (char item in input[i])
                    {
                        if (!(char.IsLetterOrDigit(item) || input[i].Contains("-") || input[i].Contains("_")))
                        {
                            g = false;
                            break;
                        }
                    }
                    if (g)
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
