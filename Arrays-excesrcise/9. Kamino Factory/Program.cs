using System;
using System.Linq;

namespace _9.Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = int.Parse(Console.ReadLine());
            int dnaCounter = 0;
            int sumDNA = 0;
            string bestDNA = null;
            int bestDnaCounter = 0;
            int bestSum = 0;
            int oneCounterBiggest = -1;
            int smallestIndexSequenceOfOnes = 0;
            bool isBestDNA = false;
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                else
                {
                    int[] DNA = input.Split('!',(char)StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int oneCounter = 0;
                    
                    int indexSequenceOfOnes = -1;
                
                    sumDNA = DNA.Sum();
 
                    dnaCounter++;
                    for (int i = 0; i < lengthDNA; i++)
                    {
                        if (DNA[i] == 1)
                        {
                            oneCounter++;

                            if (indexSequenceOfOnes == -1)
                                indexSequenceOfOnes = i;
                        }
                        else
                        {
                            oneCounter = 0;
                            indexSequenceOfOnes = -1;
                        }

                        if (oneCounterBiggest < oneCounter)
                        {
                            isBestDNA=true;
                        }
                        else
                            if (oneCounterBiggest == oneCounter)
                            {
                                if (smallestIndexSequenceOfOnes>indexSequenceOfOnes)
                                {
                                    isBestDNA = true;
                                }
                                else
                                    if(smallestIndexSequenceOfOnes==indexSequenceOfOnes&&bestSum<sumDNA)
                                    {
                                        isBestDNA = true;                                        
                                    }
                            }
                        if (isBestDNA)
                        {
                            oneCounterBiggest = oneCounter;
                            bestDNA = String.Join(" ", DNA);
                            bestDnaCounter = dnaCounter;
                            bestSum = sumDNA;
                            smallestIndexSequenceOfOnes = indexSequenceOfOnes;

                            isBestDNA = false;
                        }
                    }
                    
                }

            }

            Console.WriteLine("Best DNA sample {0} with sum: {1}.",bestDnaCounter,bestSum);
            Console.WriteLine(bestDNA);
           
        }
    }
}
