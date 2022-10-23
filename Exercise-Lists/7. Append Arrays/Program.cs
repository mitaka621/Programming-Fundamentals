using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string output=String.Empty;
            for (int i = arrays.Length-1; i >=0; i--)
            {
                output+=arrays[i]+" ";
            }
            string[] a=output.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(String.Join(' ',a));
        }
    }
}
