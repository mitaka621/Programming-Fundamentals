using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomIndex = -1;

            while (numbers.IndexOf(bom[0]) != -1)
            {
                for (int i = 0; i < bom[1]; i++) //bom left
                {
                    bomIndex = numbers.IndexOf(bom[0]);
                    if (bomIndex > 0)
                    {
                        numbers.RemoveAt(bomIndex - 1);
                    }
                }

                for (int i = 0; i < bom[1]; i++) //bom right
                {
                    bomIndex = numbers.IndexOf(bom[0]);
                    if (bomIndex < numbers.Count - 1)
                    {
                        numbers.RemoveAt(bomIndex + 1);
                    }
                }
                numbers.RemoveAt(numbers.IndexOf(bom[0]));
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
