using System;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Collections.Generic;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\:\:|\*\*)(?<name>[A-Z][a-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            string pattern2 = @"\d";
            Regex digits= new Regex(pattern2);
            MatchCollection matches2 = digits.Matches(input);
            BigInteger threshold=1,temp=0;
            foreach (Match item in matches2)
            {
                threshold *= int.Parse(item.Value);
            }

         
            Dictionary<string,string> emo=new Dictionary<string,string>();
            foreach (Match item in matches)
            {
                emo.Add(item.Value, item.Groups["name"].Value);
                
            }
            Console.WriteLine("Cool threshold: "+threshold);
            Console.WriteLine(emo.Count+" emojis found in the text. The cool ones are:");
            
            foreach (var item in emo)
            {
                for (int i = 0; i < item.Value.Length; i++)
                {
                    temp += (int)item.Value[i];
                }
                if (temp>threshold)
                {
                    Console.WriteLine(item.Key);
                }
                temp = 0;
            }

        }
    }
}
