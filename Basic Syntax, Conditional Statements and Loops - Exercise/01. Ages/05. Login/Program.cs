using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();
            string newname = null;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                newname += username[i];
            }
            int b = 0;
            while (true)
            {

                string input = Console.ReadLine();
                if (input == newname)
                {
                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }
                else
                {
                    b++;
                    if (b >= 4)
                    {
                        Console.WriteLine("User {0} blocked!", username);
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }


            }







        }
    }
}