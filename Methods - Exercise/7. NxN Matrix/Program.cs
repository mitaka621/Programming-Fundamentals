using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NxN_Matrix
{
    internal class Program
    {
        public static void Matric(int a)
        {
            int[,] matrix = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(matrix[i,j]+a+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            Matric(a);
        }
    }
}
