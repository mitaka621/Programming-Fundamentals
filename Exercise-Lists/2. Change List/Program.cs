using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] input2 = input.Split(' ').ToArray();
                if (input2[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == input2[1])
                            list.RemoveAt(i);
                    }
                }
                else
                    list.Insert(int.Parse(input2[2]), input2[1]);
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
