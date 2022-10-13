using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Middle_Characters
{
    internal class Program
    {
        public static void middleChar(string word)
        {
            if (word.Length%2==0)
            {
                Console.WriteLine(word[word.Length / 2-1]+ ""+word[word.Length / 2]); 
            }
            else
                Console.WriteLine(word[word.Length / 2]);
        }
        static void Main(string[] args)
        {
            middleChar(Console.ReadLine());

        }
    }
}
