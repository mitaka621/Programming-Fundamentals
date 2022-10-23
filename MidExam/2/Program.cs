using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int CommNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < CommNum; i++)
            {

                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command=input[0];
                int value1=0,value2 = 0;
                if (input.Length>2&&command=="Prefer")
                {
                    value1 = int.Parse(input[1]);
                    value2=int.Parse(input[2]);
                }
                if (command == "Remove")
                {
                    value2 = int.Parse(input[2]);
                }
                switch (command)
                {
                    case "Include":
                        list.Add(input[1]);
                        break;
                    case "Remove":
                        if (value2 < list.Count&&value2>=0)
                        {
                            if (input[1] == "first")
                                for (int j = 0; j < value2; j++)
                                {
                                    list.RemoveAt(0);
                                }
                            else
                                for (int j = 0; j < value2; j++)
                                {
                                    list.RemoveAt(list.Count - 1);
                                }
                        }
                        break;
                    case "Prefer":
                        if (value1>=0&&value1<list.Count&&value2>=0&&value2<list.Count)
                        {
                            string temp=list[value1];
                            list[value1] = list[value2];
                            list[value2] = temp;
                        }
                        break;
                    case "Reverse":
                        list.Reverse();
                        break;
                    default:
                        break;
                }
                //Console.WriteLine(string.Join(" ", list));
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
