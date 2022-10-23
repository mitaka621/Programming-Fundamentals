using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int peopleWaing = int.Parse(Console.ReadLine());

            int[] train = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasEmptySlots = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i] == 4)
                {
                    continue;
                }
                else
                {
                    if (train[i] + peopleWaing <= 4)
                    {
                        train[i] += peopleWaing;
                        peopleWaing = 0;
                    }
                    else
                    {

                        peopleWaing -= 4 - train[i];
                            train[i] = 4;
                    }
                }
                if (train[i]!=4)
                {
                    hasEmptySlots = true;
                }
            }
            if (hasEmptySlots&& peopleWaing==0)
            {
                Console.WriteLine("The lift has empty spots! \n{0}", string.Join(" ", train));
            }
            else
            if (hasEmptySlots==false&&peopleWaing!=0)
            {
                Console.WriteLine("There isn't enough space! {0} people in a queue! \n{1}", peopleWaing, string.Join(" ", train));
            }
            else
                Console.WriteLine(string.Join(" ", train));

        }
    }
}
