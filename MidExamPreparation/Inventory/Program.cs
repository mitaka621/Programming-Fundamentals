using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input=Console.ReadLine())!="Craft!")
            {
                string[] commands=input.Split(" - ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action=commands[0];
                string item = commands[1];

                switch (action)
                {
                    case "Collect":
                        bool itemExsists = false;
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            if (inventory[i]==item)
                               itemExsists=true;                         
                        }
                        if (!itemExsists)
                        inventory.Add(item);
                        break;
                    case "Drop":
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            if (inventory[i] == item)
                                inventory.RemoveAt(i);
                        }
                        break;
                    case "Combine Items":
                        string[] subItemArr = item.Split(":").ToArray();
                        string item1 = subItemArr[0], item2 = subItemArr[1];
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            if (inventory[i] == item1)
                                inventory.Insert(i+1, item2);
                        }
                        break;
                    case "Renew":
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            if (inventory[i] == item)
                            {
                                inventory.RemoveAt(i);
                                inventory.Add(item);
                            }
                              
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",inventory));
        }
    }
}
