using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            List < string > guestList= new List<string>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input.Length == 3)
                {
                    if (guestList.Contains(input[0]))
                    {
                        Console.WriteLine("{0} is already in the list!", input[0]);
                    }
                    else
                    {
                        guestList.Add(input[0]);
                    }
                }
                else
                {
                    if (guestList.Contains(input[0]))
                    {
                        guestList.Remove(input[0]);                       
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", input[0]);
                    }
                }
            }
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
