using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Integers
{
    internal class Program
    {
        public static string BackwardString(string a)
        {
            string b = String.Empty;
            for (int i = a.Length-1; i >=0; i--)
            {
                b+=a[i];
            }
            return b;
        }
        static void Main(string[] args)
        {
            string input;
            bool ispalindrome = true;
            while ((input = Console.ReadLine())!="END")
            {
                string backwards=BackwardString(input);
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != backwards[i])
                    {
                        ispalindrome = false;
                    }
                }
                Console.WriteLine(ispalindrome);
                ispalindrome = true;
            }

           
        }
    }
}
