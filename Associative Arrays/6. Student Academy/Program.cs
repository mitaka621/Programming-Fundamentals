using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List<double>> dnevnik = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());
                if (!dnevnik.ContainsKey(name))
                {
                    dnevnik.Add(name, new List<double>());
                }
                dnevnik[name].Add(grade);
            }

            foreach (var item in dnevnik)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
