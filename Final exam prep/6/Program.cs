using System;
using System.Collections.Generic;
using System.Linq;
namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
            List<Plants> plants = new List<Plants>();
            for (int i = 0; i <n; i++)
			{

                string[] input = Console.ReadLine().Split("<->",StringSplitOptions.RemoveEmptyEntries);
                if (!plants.Any(x => x.Name == input[0]))
                {
                    plants.Add(new Plants(input[0], int.Parse(input[1])));
                }
                else
                    plants[plants.FindIndex(x=>x.Name== input[0])].Rarity=int.Parse(input[1]);

            }
            string input2;
            while ((input2=Console.ReadLine())!= "Exhibition")
            {
                string[] cmdArgs=input2.Split(": ",StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Rate":
                        string[] cmd = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        if (!plants.Any(x => x.Name == cmd[0]))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plants[plants.FindIndex(x => x.Name == cmd[0])].RarityList.Add(int.Parse(cmd[1]));
                        }
                        break;
                    case "Update":
                        string[] cmd2 = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        if (!plants.Any(x => x.Name == cmd2[0]))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plants[plants.FindIndex(x => x.Name == cmd2[0])].Rarity = int.Parse(cmd2[1]);
                        }
                        break;
                    case "Reset":
                        if (!plants.Any(x => x.Name == cmdArgs[1]))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plants[plants.FindIndex(x => x.Name == cmdArgs[1])].RarityList.Clear();
                        }
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                double b;
                if (item.RarityList.Count != 0)
                    b = item.RarityList.Average();
                else b = 0;
                Console.WriteLine("- {0}; Rarity: {1}; Rating: {2:0.00}",item.Name,item.Rarity,b);
            }

        }
        public class Plants
        {
            public Plants(string name, int rarity)
            {
                RarityList = new List<int>();
                Name = name;
                Rarity = rarity;
            }

            public string Name { get; }
            public int Rarity { get; set; }
            public List<int> RarityList { get; set; }
            
        }
    }
}
