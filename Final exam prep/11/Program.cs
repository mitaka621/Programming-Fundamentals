using System;
using System.Text.RegularExpressions;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@\#{1,})(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])(@\#{1,})";
            string digit = @"\d";
            Regex barcode=new Regex(pattern);
            Regex digits = new Regex(digit);

            int n = int.Parse(Console.ReadLine());            
            for (int i = 0; i < n; i++)
            {
                string input=Console.ReadLine();
                
                if (barcode.IsMatch(input))
                {
                    Match match=barcode.Match(input);
                    string bar=match.Groups["barcode"].Value;
                    if (digits.IsMatch(bar))
                    {
                        MatchCollection dig = digits.Matches(bar);
                        Console.WriteLine("Product group: "+String.Join("",dig));
                    }else

                    Console.WriteLine("Product group: 00");
                }
                else
                    Console.WriteLine("Invalid barcode");
            }


        }
    }
}
