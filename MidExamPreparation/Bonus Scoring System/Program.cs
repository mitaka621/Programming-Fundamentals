using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numStud = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            int numLecturs = int.Parse(Console.ReadLine());

            int bonus = int.Parse(Console.ReadLine());

            for (int i = 0; i < numStud; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }
            int max = 0;
            double maxScore = 0;
            if (arr.Count!=0)
            {
                max = arr.Max();
                maxScore = Math.Ceiling(max / (double)numLecturs * (5 + bonus));
            }
             
            
            Console.WriteLine("Max Bonus: {0}.",maxScore);
            Console.WriteLine("The student has attended {0} lectures.", max);

        }
    }
}
