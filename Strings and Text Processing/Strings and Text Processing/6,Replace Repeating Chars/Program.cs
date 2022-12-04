
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            List<char> list = new List<char>();
            list.Add(a[0]);
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == a[i + 1] && list.Last() != a[i])
                {
                    list.Add(a[i]);
                }
                else if (list.Last() != a[i])
                {
                    list.Add(a[i]);
                }
                
            }
            if (list.Last() != a[a.Length-1])
            {
                list.Add(a[a.Length - 1]);
            }
            foreach (var item in list)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine();
        }
    }
}
