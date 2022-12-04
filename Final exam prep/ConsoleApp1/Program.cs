using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<item>[A-Za-z ]+)(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d{1,5})(\1)";
            Regex reg=new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection match = reg.Matches(input);
            string item=String.Empty, date=string.Empty, cal=String.Empty;
            List<FoodItem> foodList = new List<FoodItem>();
            foreach (Match a in match)
            { 
                    item = a.Groups[5].Value;
                    date = a.Groups[6].Value;
                    cal = a.Groups[7].Value;

                    foodList.Add(new FoodItem(item, date, int.Parse(cal)));
                 
            }
            int sum = foodList.Sum(x => x.Calories);
            Console.WriteLine("You have food to last you for: {0} days!",Math.Floor(sum/(double)2000));
            foreach (var a in foodList)
            {
                Console.WriteLine($"Item: {a.Item}, Best before: {a.Date}, Nutrition: {a.Calories}");
            }
        }

        class FoodItem
        {
            public FoodItem(string item, string date, int calories)
            {
                Item = item;
                Date = date;
                Calories = calories;
            }
            public string Item { get;  }
            public string Date { get;  }
            public int Calories { get;  }
        }
    }
}
