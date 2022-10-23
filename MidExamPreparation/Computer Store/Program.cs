using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double sumNoTaxes = 0, sumWthTaxes = 0, taxes = 0 ;
            while ((input=Console.ReadLine())!= "special"&&input!= "regular")
            {
                double itemPrice = double.Parse(input);
                if (itemPrice < 0)//
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                sumNoTaxes += itemPrice;
                taxes += itemPrice * 0.2;
               
            }
            sumWthTaxes += sumNoTaxes + taxes;
            if (sumNoTaxes == 0 || sumWthTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                
                if (input == "special")
                    sumWthTaxes -= sumWthTaxes * 0.1;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine("Price without taxes: {0:0.00}$",sumNoTaxes);
                Console.WriteLine("Taxes: {0:0.00}$", taxes);
                Console.WriteLine("-----------");
                Console.WriteLine("Total price: {0:0.00}$",sumWthTaxes);
            }
        }
    }
}
