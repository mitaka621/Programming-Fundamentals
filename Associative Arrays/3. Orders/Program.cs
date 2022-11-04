using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> inv = new Dictionary<string, double[]>();
            string input;
            while ((input=Console.ReadLine())!="buy")
            {
                string[] arg = input.Split(' ').ToArray();
                string itemName = arg[0];
                double itemPrice = double.Parse(arg[1]);
                int itemCount = int.Parse(arg[2]);

                if (!inv.ContainsKey(itemName))
                {
                    inv.Add(itemName, new double[2]);
                    inv[itemName][0] = itemPrice;
                    inv[itemName][1] = itemCount;
                }
                else
                {
                    inv[itemName][0] = itemPrice;
                    inv[itemName][1] += itemCount;
                }
            }

            foreach (var item in inv)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:F2}");
            }
        }
    }
}
