using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Mu_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int healthLast = 100,newHelth, coin = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] commands = rooms[i].Split().ToArray();
                int value = int.Parse(commands[1]);
                switch (commands[0])
                {
                    case "potion":
                        newHelth = healthLast + value;
                        if (newHelth > 100)
                        {
                            Console.WriteLine("You healed for {0} hp.", value - (newHelth -100));
                            healthLast = 100;
                        }
                        else
                        {
                            Console.WriteLine("You healed for {0} hp.",newHelth- healthLast);
                            healthLast = newHelth;
                        }
                        Console.WriteLine("Current health: {0} hp.",healthLast);
                        break;
                    case "chest":
                        Console.WriteLine("You found {0} bitcoins.",value);
                        coin += value;
                        break;
                    default:
                        healthLast -= value;
                        if (healthLast > 0)
                        {
                            Console.WriteLine("You slayed {0}.", commands[0]);
                        }
                        else
                        {
                            Console.WriteLine("You died! Killed by {0}.", commands[0]);
                            Console.WriteLine("Best room: {0}",i+1);
                            return;
                        }
                        break;
                }
                
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine("Bitcoins: {0}",coin);
            Console.WriteLine("Health: {0}",healthLast);
        }
    }
}
