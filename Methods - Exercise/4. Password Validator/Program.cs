using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine().ToLower();
            bool valid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = false;
            } 
                for (int i = 0; i < password.Length; i++)
                {
                    int asciiPassword = (int)password[i];
                    if (asciiPassword<48||(asciiPassword>57&&asciiPassword<97)||asciiPassword>122)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        valid=false;
                        break;
                    }
                }
                int count = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    int asciiPassword = (int)password[i];
                    if (asciiPassword>47&&asciiPassword<58)
                    {
                        count++;
                    }
                }
                if (count<2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    valid = false;
                }
                if (valid)
                Console.WriteLine("Password is valid");

            
        }
    }
}
