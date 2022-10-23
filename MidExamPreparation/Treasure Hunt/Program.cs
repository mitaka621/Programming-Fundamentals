using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lootStolen = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];

                switch (command)
                {
                    case "Loot":

                        for (int i = 1; i < commands.Length; i++)
                        {
                            bool excists = false;
                            for (int j = 0; j < loot.Count; j++)
                            {
                                if (loot[j] == commands[i])
                                {
                                    excists = true;
                                }
                            }
                            if (!excists)
                            {
                                loot.Insert(0, commands[i]);
                            }

                        }
                        break;
                    case "Drop"://                       
                        if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < loot.Count)
                        {
                            loot.Add(loot[int.Parse(commands[1])]);
                            loot.RemoveAt(int.Parse(commands[1]));
                        }

                        break;
                    case "Steal":
                        int index = int.Parse(commands[1]);
                        for (int i = loot.Count - 1; i >= 0; i--)
                        {
                            if (index > 0)
                            {
                                lootStolen.Add(loot[loot.Count - 1]);
                                loot.RemoveAt(loot.Count - 1);
                                index--;
                            }
                        }
                        break;

                }

            }

            if (lootStolen.Count > 0)
            { 
            lootStolen.Reverse();
            Console.WriteLine(String.Join(", ", lootStolen));
            }
            if (loot.Count > 0)
            {
               
                int lenghtLoot = 0;
               
                for (int i = 0; i < loot.Count; i++)
                {
                    lenghtLoot += loot[i].Length;
                }
                Console.WriteLine("Average treasure gain: {0:0.00} pirate credits.", lenghtLoot / (decimal)loot.Count) ;
            }
            else
                Console.WriteLine("Failed treasure hunt.");
        }
    }
}
