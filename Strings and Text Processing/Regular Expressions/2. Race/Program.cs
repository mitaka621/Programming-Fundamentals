using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patter = @"(?<name>[A-Za-z]+)|(?<distance>\d)";
            string input;
            string name = string.Empty;
            int km = 0;


            string[] input2 = Console.ReadLine().Split();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in input2)
            {
                dict.Add(item, 0);
            }

            while ((input=Console.ReadLine())!= "end of race")
            {
                Regex reg = new Regex(patter);
                if (reg.IsMatch(input))
                {

                    MatchCollection matchCollection = reg.Matches(input);
                    name = string.Empty;
                    km = 0;
                    foreach (Match item in matchCollection)
                    {
                        if (item.Groups["distance"].Value != string.Empty)
                            km += int.Parse(item.Groups["distance"].Value);
                        else
                            name += item.Groups["name"].Value;
                    }
                    if (dict.ContainsKey(name))
                    {
                        dict[name] += km;
                    }
                }
                //Console.WriteLine(name+" "+km);
            }
            int count = 0;
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dict)
            {
                if (dict.Count >= count&&count<3)
                {
                    if(count==0)
                    Console.WriteLine(count + 1 + "st place: " + item.Key);
                    else if(count == 1)
                        Console.WriteLine(count + 1 + "nd place: " + item.Key);
                    else
                        Console.WriteLine(count + 1 + "rd place: " + item.Key);
                    count++;
                   
                }
                else
                {
                    break;
                }
            }
           
           
        }
    }
}
