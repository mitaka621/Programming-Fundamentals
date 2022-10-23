using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());
            string input;
            int countWins = 0;
            while ((input=Console.ReadLine())!= "End of battle"&&energy>=0)
            {

                int distance = int.Parse(input);
                if (energy - distance < 0)
                {
                    //energy = energy - distance;
                    Console.WriteLine("Not enough energy! Game ends with {0} won battles and {1} energy",countWins,energy);
                    return;
                }
                else
                {
                    energy-=distance;
                    countWins++;
                    if (countWins%3==0)
                    {
                        energy += countWins;
                    }
                }
            }
            if (energy<0)
            {
                Console.WriteLine("Not enough energy! Game ends with {0} won battles and {1} energy", countWins, energy);
            }
            else
            Console.WriteLine("Won battles: {0}. Energy left: {1}",countWins,energy);
        }
    }
}
