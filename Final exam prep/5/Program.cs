using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<name>[A-Z][A-Za-z]{2,})(\1)";
            Regex regex = new Regex(pattern);

            string a = Console.ReadLine();
            MatchCollection matches = regex.Matches(a);
            List<string> strings = new List<string>();
            foreach (Match item in matches)
            {
                strings.Add(item.Groups["name"].Value);
            }
            Console.WriteLine("Destinations: "+string.Join(", ",strings));

            Console.WriteLine("Travel Points: "+strings.Sum(x=>x.Length));

        }
    }
}
