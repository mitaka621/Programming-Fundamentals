using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input;
            int count = 0;
            while ((input=Console.ReadLine())!="End")
            {
                int value = int.Parse(input), temp = 0;
                if(value >= 0 && value < seq.Length)
                if (seq[value] != -1)
                {
                    temp = seq[value];
                    seq[value]=-1;
                    count++;
                    for (int i = 0; i < seq.Length; i++)
                    {
                        if (seq[i] != -1)
                        { 
                            if (temp < seq[i])
                            {
                                seq[i] -= temp;
                            }
                            else
                                seq[i] += temp;
                        }
                    }
                }
                
            }
            Console.WriteLine("Shot targets: {0} -> {1}",count,String.Join(" ",seq));
        }
    }
}
