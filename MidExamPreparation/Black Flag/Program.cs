using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int daylyPlunder = int.Parse(Console.ReadLine());
            double daylyPlunderSum = 0;
            double expectedPlunder = double.Parse(Console.ReadLine());

            for (int i = 1; i <= days; i++)
            {
                daylyPlunderSum += daylyPlunder;
                if (i%3==0)
                {
                    daylyPlunderSum += daylyPlunder / 2;
                }
                if (i%5==0)
                {
                    daylyPlunderSum -= daylyPlunderSum * 0.3;
                }
            }

            if (daylyPlunderSum>= expectedPlunder)
            {
                Console.WriteLine("Ahoy! {0:0.00} plunder gained.",daylyPlunderSum);
            }
            else
                Console.WriteLine("Collected only {0:0.00}% of the plunder.",100*daylyPlunderSum/ expectedPlunder);
        }
    }
}
