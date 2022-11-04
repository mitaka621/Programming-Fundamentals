using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string,List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arg = input.Split(':');
                string courseName = arg[0], studName = arg[1];
                if (!dic.ContainsKey(courseName))
                {
                    dic.Add(courseName, new List<string>());
                }
                
                    dic[courseName].Add(studName);
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key+": "+item.Value.Count);
                Console.WriteLine("-- "+String.Join("\n-- ",item.Value)) ;
            }
        }
    }
}
