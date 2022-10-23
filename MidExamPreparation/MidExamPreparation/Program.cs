using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal quantFood = decimal.Parse(Console.ReadLine());

            decimal quantHay = decimal.Parse(Console.ReadLine());

            decimal quentCover = decimal.Parse(Console.ReadLine());

            decimal pigWeight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                quantFood -= 0.3m;
                if (i % 2 == 0)
                {
                    quantHay -= 0.05m * quantFood;
                }
                if (i%3==0)
                {
                    quentCover -= pigWeight / 3;
                }
                if ((quantFood) <= 0 || (quentCover) <= 0 || (quantHay) <= 0)
                {
                  Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantFood:F2}, Hay: {quantHay:F2}, Cover: {quentCover:F2}.");
        }
    }
}
