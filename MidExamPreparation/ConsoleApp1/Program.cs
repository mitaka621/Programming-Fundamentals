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
            List<int> shootingRange = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = null;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split().ToArray();
                string option=input[0];
                int index=int.Parse(input[1]);
                int value=int.Parse(input[2]);
                
                switch (option)
                {
                    case "Shoot":
                        if (index < shootingRange.Count && index >= 0)
                        {
                            shootingRange[index] -= value;
                            if (shootingRange[index] <= 0)
                            {
                                shootingRange.RemoveAt(index);
                            }
                        }
                        
                        break;
                    case "Add":
                        if (index < shootingRange.Count && index >= 0)
                        {
                            shootingRange.Insert(index, value);
                        }
                        else
                            Console.WriteLine("Invalid placement!");
                        break;
                    case "Strike":
                        if (index + value < shootingRange.Count &&index - value >= 0)
                        {                          
                            shootingRange.RemoveRange(index-value,value*2+1);
                        }
                        else
                            Console.WriteLine("Strike missed!");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join("|", shootingRange));
        }
    }
}
