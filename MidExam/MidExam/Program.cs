using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reqEXP=double.Parse(Console.ReadLine());

            int countBattles = int.Parse(Console.ReadLine());
            double sumEXP = 0;
            int playedBattles = 0;
            for (int i = 1; i <= countBattles; i++)
            {
                double exp = double.Parse(Console.ReadLine());
                if (i%3==0)
                {
                    exp+=exp*0.15;
                }
                if (i%5==0)
                {
                    exp -= exp * 0.1;
                }
                if (i%15==0)
                {
                    exp += exp * 0.05;
                }
                sumEXP+=exp;
                playedBattles++;
                if (sumEXP>=reqEXP)
                {
                    break;
                }
            }
            if (sumEXP >= reqEXP)
            {
                Console.WriteLine("Player successfully collected his needed experience for {0} battles.", playedBattles);
            }
            else
                Console.WriteLine("Player was not able to collect the needed experience, {0:0.00} more needed.",reqEXP-sumEXP);
            
        }
    }
}
