using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            string input;
            int couunt = 1;
            string temp=string.Empty;
            while ((input=Console.ReadLine())!="stop")
            {
                if (couunt % 2 == 0)
                {
                    inv[temp] += int.Parse(input);
                }
                else
                {
                    if (!inv.ContainsKey(input))
                    {
                        inv.Add(input, 0);
                    }
                    temp = input;
                    
                }
                couunt++;
            }

            foreach (var item in inv)
            {
                Console.WriteLine(item.Key+" -> "+item.Value);
            }
        }
    }
}
