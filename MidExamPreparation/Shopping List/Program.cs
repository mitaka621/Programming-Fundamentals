using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input=Console.ReadLine())!= "Go Shopping!")
            {
                string[] instr = input.Split().ToArray();
                string command = instr[0],item1=instr[1], item2=String.Empty;
                if (instr.Length>2)
                {
                    item2 = instr[2];
                }

                switch (command)
                {
                    case "Urgent":
                        bool exists = false;
                        for (int i = 0; i < groceries.Count; i++)
                        {
                            if (groceries[i]==item1)
                            {
                                exists = true;
                            }
                        }
                        if (!exists)                       
                        groceries.Insert(0, item1);
                        break;
                    case "Unnecessary":
                        for (int i = 0; i < groceries.Count; i++)
                        {
                            if (groceries[i] == item1)
                            {
                                groceries.RemoveAt(i);                                
                            }
                        }
                        break;
                    case "Correct":
                        for (int i = 0; i < groceries.Count; i++)
                        {
                            if (groceries[i] == item1)
                            {
                                groceries[i] = item2;
                            }
                        }
                        break;
                    case "Rearrange":
                        for (int i = 0; i < groceries.Count; i++)
                        {
                            if (groceries[i] == item1)
                            {
                                groceries.RemoveAt(i);
                                groceries.Add(item1);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",groceries));
        }
    }
}
