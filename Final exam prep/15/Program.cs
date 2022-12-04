using System;
using System.Collections.Generic;
using System.Linq;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List < City > a= new List<City>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cmdArgs = input.Split("||");
                if (a.Any(x => x.Name == cmdArgs[0]))
                {
                    a[a.FindIndex(x => x.Name == cmdArgs[0])].Population += int.Parse(cmdArgs[1]);
                    a[a.FindIndex(x => x.Name == cmdArgs[0])].Gold += int.Parse(cmdArgs[2]);
                }
                else
                a.Add(new City(cmdArgs[0], int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2])));
            }

            string actions;
            while ((actions=Console.ReadLine())!="End")
            {
                string[] cmds = actions.Split("=>");
                string town=cmds[1];
                switch (cmds[0])
                {
                    case "Plunder":
                        a[a.FindIndex(x => x.Name == town)].Gold -= int.Parse(cmds[3]);
                        a[a.FindIndex(x => x.Name == town)].Population -= int.Parse(cmds[2]);
                        Console.WriteLine($"{town} plundered! {int.Parse(cmds[3])} gold stolen, {int.Parse(cmds[2])} citizens killed.");
                        if (a[a.FindIndex(x => x.Name == town)].Gold<=0|| a[a.FindIndex(x => x.Name == town)].Population<=0)
                        {
                            Console.WriteLine(town+" has been wiped off the map!");
                            a.RemoveAt(a.FindIndex(x => x.Name == town));
                        }
                        break;
                    case "Prosper":
                        int gold=int.Parse(cmds[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            a[a.FindIndex(x => x.Name == town)].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {a[a.FindIndex(x => x.Name == town)].Gold} gold.");
                        }
                        break;
                    default:
                        break;
                }
            }
            if (a.Count > 0)
            {
                Console.WriteLine("Ahoy, Captain! There are {0} wealthy settlements to go to:", a.Count);
                foreach (var item in a)
                {
                    Console.WriteLine("{0} -> Population: {1} citizens, Gold: {2} kg", item.Name, item.Population, item.Gold);
                }
            }
            else
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");

        }
    }
    public class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
