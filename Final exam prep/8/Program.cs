using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _8
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string pattern = @"(#|@)(?<word>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            if(matches.Count==0)
                Console.WriteLine("No word pairs found!");
            else
            Console.WriteLine(matches.Count + " word pairs found!");

            bool isMirror=false;
            List<string> output = new List<string>();
            
            foreach (Match item in matches)
            {
                string str = item.Groups["word"].Value;
                string str2= item.Groups["word2"].Value;
                int j = str2.Length-1;
                isMirror = false;
                if (str.Length==str2.Length)
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == str2[j])
                    {
                        isMirror = true;
                    }
                    else
                    {
                        isMirror = false;
                        break;
                     }
                    j--;
                }
                if (isMirror)
                {
                    output.Add(str + " <=> " + str2);
                }
            }
            if (output.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ",output));
            }
        }
    }
}
