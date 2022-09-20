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

            int count = int.Parse(Console.ReadLine());


            string group = Console.ReadLine();

            string day = Console.ReadLine();
            double cena = 0;
            double discount = 0;
            switch (group)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            cena = 8.45;
                            break;
                        case "Saturday":
                            cena = 9.8;
                            break;
                        case "Sunday":
                            cena = 10.46;
                            break;
                        default:
                            break;
                    }

                    if (count >= 30)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            cena = 10.9;
                            break;
                        case "Saturday":
                            cena = 15.6;
                            break;
                        case "Sunday":
                            cena = 16;
                            break;
                        default:
                            break;
                    }

                    if (count >= 100)
                    {
                        count -= 10;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            cena = 15;
                            break;
                        case "Saturday":
                            cena = 20;
                            break;
                        case "Sunday":
                            cena = 22.5;
                            break;
                        default:
                            break;
                    }
                    if (count >= 10 && count <= 20)
                    {
                        discount = 0.05;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total price: {0:0.00}", (count * cena) - (count * cena) * discount);
        }
    }
}