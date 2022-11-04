using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split(" -> ");
                string company=arg[0];
                string id=arg[1];
                if (!dic.ContainsKey(company))
                {
                    dic.Add(company, new List<string>());
                }
                if (!dic[company].Any(x=>x.Contains(id)))
                {
                    dic[company].Add(id);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("-- "+String.Join("\n-- ",item.Value));
            }
        }
    }
}
