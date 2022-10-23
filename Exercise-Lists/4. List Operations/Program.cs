using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] strings = input.Split(' ').ToArray();
                switch (strings[0])
                {
                    case "Add":list.Add(int.Parse(strings[1])); break;
                    case "Insert":
                        if (int.Parse( strings[2])>=list.Count|| int.Parse(strings[2])<0)
                            Console.WriteLine("Invalid index");
                        else
                        list.Insert(int.Parse(strings[2]), int.Parse(strings[1])); break;
                    case "Remove":
                        if (int.Parse(strings[1]) >= list.Count || int.Parse(strings[1]) < 0)
                            Console.WriteLine("Invalid index");
                        else
                            list.RemoveAt(int.Parse(strings[1])); break;
                    case "Shift":
                        if (strings[1] == "left")
                        {
                            int temp = -1;
                            for (int i = 0; i < int.Parse(strings[2]); i++)
                            {
                                temp = list[0];
                                list.RemoveAt(0);
                                list.Add(temp);
                            }

                        }
                        else
                        {
                            int temp = -1;
                            for (int i = 0; i < int.Parse(strings[2]); i++)
                            {
                                temp = list[list.Count-1];
                                list.RemoveAt(list.Count-1);
                                list.Insert(0, temp);
                            }
                        }
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
