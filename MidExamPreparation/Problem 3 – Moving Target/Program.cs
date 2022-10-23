using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> shootingRange = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            string command = null;
            while ((command=Console.ReadLine())!="End")
            {
                string[] input = command.Split(' ').ToArray();
                switch (input[0])
                {
                    case "Shoot":
                        if (int.Parse(input[1])<shootingRange.Count&& int.Parse(input[1])>=0)
                        {
                            shootingRange[int.Parse(input[1])] -= double.Parse(input[2]);
                        }
                        if (shootingRange[int.Parse(input[1])]<=0)
                        {
                            shootingRange.RemoveAt(int.Parse(input[1]));
                        }
                        break;
                    case "Add":
                        if (int.Parse(input[1]) < shootingRange.Count && int.Parse(input[1]) >= 0)
                        {
                            shootingRange.Insert(int.Parse(input[1]), double.Parse(input[2]));
                           
                        }
                        else
                            Console.WriteLine("Invalid placement!");
                        break;
                    case "Strike":
                        if (int.Parse(input[1])+ int.Parse(input[2]) < shootingRange.Count &&
                            int.Parse(input[1])- int.Parse(input[2]) >= 0)
                        {
                            int sum = int.Parse(input[2]) * 2 + 1;
                            shootingRange.RemoveRange(int.Parse(input[1]) - int.Parse(input[2]), sum);
                        }
                        else
                            Console.WriteLine("Strike missed!");
                        break ;
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join("|",shootingRange));
        }
    }
}
