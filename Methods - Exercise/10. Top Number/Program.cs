using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Top_Number
{
    internal class Program
    {
        static bool Condition1(string a)
        {
            bool condition = true;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += char.GetNumericValue(a[i]);
            }
            if (sum % 8 != 0)
            {
                condition = false;
            }
            return condition;
        }

        static bool Condition2(string a)
        {
            bool condition = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.GetNumericValue(a[i]) % 2 != 0)
                {
                    condition = true;
                }
            }
            return condition;
        }

        public static void PrintTopNumber(int a)
        {
            string num;
            for (int i = 0; i <= a; i++)
            {
                num = i.ToString();
                if (Condition1(num) && Condition2(num))
                {
                    Console.WriteLine(num);
                }
            }
            
        }
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintTopNumber(end);
        }
    }
}
