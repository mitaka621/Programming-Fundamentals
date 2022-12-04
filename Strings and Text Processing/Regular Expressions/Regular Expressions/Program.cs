using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double sum = 0;
                string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+(\.\d{1,2})?)$";
                string input;
                while ((input=Console.ReadLine())!= "Purchase")
                {
                    Match match = Regex.Match(input, pattern);
                    if (match.Success)
                    {
                    string furnitureName = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    furniture.Add(furnitureName);
                    sum+=price*(int)quantity;
                }
                }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total money spend: {0:0.00}",sum);
            
        }
    }
}
