using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vowels_Count
{
    internal class Program
    {
        public static int vowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':  count++; break;
                    case 'e': count++; break;
                    case 'i': count++; break;
                    case 'o':count++; break;
                    case 'u':count++; break;
                    default:
                        break;
                }
                
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(vowelsCount(Console.ReadLine().ToLower()));
        }
    }
}
