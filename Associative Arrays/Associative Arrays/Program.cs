using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associative_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] str1 = Console.ReadLine().Split(' ').ToArray();
            string str2=string.Join("", str1);
            Dictionary<char, int> dic=new Dictionary<char, int>();
            for (int i = 0; i < str2.Length; i++)
            {
                if (!dic.ContainsKey(str2[i]))
                {
                    dic.Add(str2[i], 0);
                }
                dic[str2[i]]++;
            }
            foreach (var d  in dic)
            {
                Console.WriteLine(d.Key+ " -> "+d.Value);
            }
        }
    }
}
