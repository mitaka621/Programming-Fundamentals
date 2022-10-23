using System;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int stud = int.Parse(Console.ReadLine());
            int hourCount = 0;
            while (stud>0)
            {
                hourCount++;
                if (hourCount%4==0)
                {
                    continue;
                }
                if (stud - employee1 >= 0)
                {
                    stud -= employee1;
                }
                else
                {
                    stud = 0;                    
                }

                if (stud - employee2 >= 0)
                {
                    stud -= employee2;
                }
                else
                {
                    stud = 0;
                }

                if (stud - employee3 >= 0)
                {
                    stud -= employee3;
                }
                else
                {
                    stud = 0;
                }
            }
            Console.WriteLine("Time needed: {0}h.",hourCount);
        }
    }
}
