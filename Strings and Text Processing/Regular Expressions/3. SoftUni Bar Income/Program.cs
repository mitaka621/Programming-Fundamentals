using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            string patern = @"^\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<quantity>\d+)[^\|\$\%\.]*\|[^\|\$\%\.\d]*(?<price>\d+(\.\d+)?)\$$";
            double income = 0;
            while ((input=Console.ReadLine())!= "end of shift")
            {
                Regex reg = new Regex(patern);
                Match match = reg.Match(input);
                if (match.Success)
                {
                    double pr = double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {pr:F2}");
                    income += pr;
                    
                }
            }

            Console.WriteLine("Total income: {0:0.00}", income);
        }
    }
}
