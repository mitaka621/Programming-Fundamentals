using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write((char)(97+i));
                        Console.Write((char)(97+j));
                        Console.Write((char)(97 + k));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
