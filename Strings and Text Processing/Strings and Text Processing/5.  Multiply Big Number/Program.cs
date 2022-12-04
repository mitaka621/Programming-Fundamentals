using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();

            int num2 = int.Parse(Console.ReadLine());
            int ostatuk = 0;
            List<int> answer = new List<int>();
            for (int i = num.Length-1; i >=0; i--)
            {
                int multiply = int.Parse(num[i]+string.Empty) * num2 + ostatuk;

              

                if (multiply > 9&&i!=0)
                {
                    ostatuk = multiply / 10 % 10;
                    answer.Add(multiply % 10);

                }
                else
                {
                    ostatuk = 0;
                    answer.Add(multiply);

                }
               
            }
            answer.Reverse();

            if (num2==0)
            {
                Console.WriteLine(0);
            }
            else
            Console.WriteLine(string.Join(string.Empty, answer));
        }
    }
}
