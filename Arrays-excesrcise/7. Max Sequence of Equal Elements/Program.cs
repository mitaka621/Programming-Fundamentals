using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int output = 0, outputLongest=0;
            int countBiggest = 0, count = 0;
            
            for (int i = num.Length-1; i >0; i--)
            {
                if (num[i] == num[i-1])
                {
                    output = num[i];
                    count++;
                    
                }
                else
                {

                    if (count>=countBiggest)
                    {
                        countBiggest = count;
                        outputLongest = output;
                    }
                    
                    count = 0;
                    
                }                
            }
            if (count >= countBiggest)
            {
                countBiggest = count;
                outputLongest = output;
            }
          
                for (int i = 0; i <= countBiggest; i++)
                {
                    Console.Write(outputLongest + " ");              
                }
           
            Console.WriteLine();
        }
    }
}
