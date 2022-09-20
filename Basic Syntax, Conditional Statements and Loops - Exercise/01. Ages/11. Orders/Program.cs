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

            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {

                double CapsulePrice = double.Parse(Console.ReadLine());

                double days = double.Parse(Console.ReadLine());

                double CapsulesCount = double.Parse(Console.ReadLine());

                Console.WriteLine("The price for the coffee is: ${0:0.00}", (days * CapsulesCount * CapsulePrice));
                sum += days * CapsulesCount * CapsulePrice;
            }
            Console.WriteLine("Total: ${0:0.00}", sum);
        }
    }
}
