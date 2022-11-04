using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Objects_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] phrases = "Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can’t live without this product.".Split(", ").ToArray();
            string[] events="Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!".Split(", ").ToArray();
            string[] authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva".Split(", ").ToArray();
            string[] cities = "Burgas, Sofia, Plovdiv, Varna, Ruse".Split(", ").ToArray();
            Random r1= new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            Random r4 = new Random();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[r1.Next(0, phrases.Length - 1)]} {events[r2.Next(0, events.Length - 1)]} {authors[r3.Next(0, authors.Length - 1)]} – {cities[r4.Next(0, cities.Length - 1)]}.");

            }


        }
    }
}
