using System;
using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string pattern = @"\!(?<value1>[A-Z][a-z]{2,})\!\:\[(?<value2>[A-Za-z]{8,})\]";
            Regex regex=new Regex(pattern);
            for (int i = 0; i < n; i++)
            {


                string str = Console.ReadLine();
                Match match = regex.Match(str);
                if (!regex.Match(str).Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    Console.Write(match.Groups["value1"].Value + ": ");
                    string value = match.Groups["value2"].Value;
                    char[] chars = value.ToCharArray();
                    for (int j = 0; j < value.Length; j++)
                    {
                        Console.Write((int)chars[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
