using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            int numMoves = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                numMoves++;
                int[] indexes = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Sort(indexes);
                int index1 = indexes[0];
                int index2 = indexes[1];
                if (index1 == index2 || index1 < 0 || index1 > elements.Count - 1 || index2 < 0 || index2 > elements.Count - 1)
                {
                    elements.Insert(elements.Count / 2, "-" + numMoves + "a");
                    elements.Insert(elements.Count / 2, "-" + numMoves + "a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[index1] == elements[index2])
                {
                    Console.WriteLine("Congrats! You have found matching elements - {0}!", elements[index1]);
                    elements.RemoveAt(index1);
                    elements.RemoveAt(index2 - 1);
                }
                else
                    Console.WriteLine("Try again!");
                if (elements.Count == 0)
                {
                    Console.WriteLine("You have won in {0} turns!", numMoves);
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
