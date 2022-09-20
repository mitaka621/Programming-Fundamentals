using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double wallet = double.Parse(Console.ReadLine());

            int countStudents = int.Parse(Console.ReadLine());

            double saberPrice = double.Parse(Console.ReadLine());

            double robesPrice = double.Parse(Console.ReadLine());

            double beltPrice = double.Parse(Console.ReadLine());

            double sum = countStudents * robesPrice + ((countStudents - countStudents / 6) * beltPrice)
                + Math.Ceiling(countStudents + countStudents * 0.1) * saberPrice;

            if (sum <= wallet)
            {
                Console.WriteLine("The money is enough - it would cost {0:0.00}lv.", sum);
            }
            else
                Console.WriteLine("John will need {0:0.00}lv more.", sum - wallet);
        }
    }
}