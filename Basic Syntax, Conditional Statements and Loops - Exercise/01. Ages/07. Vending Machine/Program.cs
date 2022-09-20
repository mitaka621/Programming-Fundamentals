using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            double coin;
            string item = null;
            double cena = 0;
            int i = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                else
                {
                    coin = double.Parse(input);

                    switch (coin)
                    {
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                            sum += coin;
                            break;
                        default:
                            Console.WriteLine("Cannot accept " + coin);
                            break;
                    }
                }
            }

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "End")
                    break;
                else
                {
                    switch (input)
                    {
                        case "Nuts":
                            item = "nuts";
                            cena = 2.0;
                            break;
                        case "Water":
                            item = "water";
                            cena = 0.7;
                            break;
                        case "Crisps":
                            item = "crisps";
                            cena = 1.5;
                            break;
                        case "Soda":
                            item = "soda";
                            cena = 0.8;
                            break;
                        case "Coke":
                            item = "coke";
                            cena = 1.0;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            i = 1;
                            break;
                    }

                    if (sum - cena < 0 && i == 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    if (sum - cena >= 0 && i == 0)
                    {
                        Console.WriteLine("Purchased {0}", item);
                        sum -= cena;
                    }
                    i = 0;
                }

            }

            Console.WriteLine("Change: {0:0.00}", sum);
        }
    }
}
