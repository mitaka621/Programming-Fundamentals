using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
             int maxCap = int.Parse(Console.ReadLine());
            string input;
            while ((input=Console.ReadLine())!="end")
            {
               string[] input2 = input.Split(' ').ToArray();
                if (input2.Length == 2)
                {
                    wagons.Add(int.Parse(input2[1]));
                }
                else
                {
                    int pass = int.Parse(input2[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] +pass<=maxCap)
                        {
                            wagons[i] += pass;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
