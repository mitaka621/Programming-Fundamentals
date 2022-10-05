using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());

            long[] field = new long[n];

            long[] bugIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            for (int i = 0; i < bugIndexes.Length; i++)
            {
                if (bugIndexes[i] < n && bugIndexes[i]>=0)
                {
                    field[bugIndexes[i]] = 1;
                }
                
            }
            long ladybugIndex = 0, flyLenth=0;
            string direction = null;
            string input;
            while ((input = Console.ReadLine())!="end")
            {

                    string[] commands = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    if (commands.Length != 3)
                        continue;
                    ladybugIndex=long.Parse(commands[0]);
                    direction=commands[1];
                    flyLenth=long.Parse(commands[2]);

                    if (ladybugIndex>=n|| ladybugIndex <0)
                    {
                        continue;
                    }
                if (field[ladybugIndex] == 0)
                    continue;

                    if (direction == "right")
                    {
                        field[ladybugIndex] = 0;
                        if(ladybugIndex + flyLenth<=field.Length-1)
                        field[ladybugIndex + flyLenth] += 1;
                    }
                    else
                    {
                        field[ladybugIndex] = 0;
                        if (ladybugIndex - flyLenth >=0)
                            field[ladybugIndex - flyLenth] += 1;
                    }

                for (int i = 0; i < field.Length; i++)
                {
                    if (field[i] == 2)
                    {
                        field[i] -= 1;

                        if (direction == "right")
                        {

                            if (i + flyLenth <= field.Length - 1)
                                field[i + flyLenth] += 1;
                        }
                        else
                        {
                            if (i - flyLenth >= 0)
                            {
                                field[i - flyLenth] += 1;
                                i = -1;
                            }
                        }
                    }


                    
                }



                }

            foreach (var item in field)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
