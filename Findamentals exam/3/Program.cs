using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            List<Guest> guests= new List<Guest>();
            int count = 0;
            while ((input=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name=cmdArgs[1];
                string meal=cmdArgs[2];
                
                switch (cmdArgs[0])
                {
                    case "Like":
                        if (!guests.Any(x => x.Name == name))
                        {
                            guests.Add(new Guest(name, meal));
                        }
                        else if(!guests[guests.FindIndex(x => x.Name == name)].LikedMeals.Contains(meal))
                            guests[guests.FindIndex(x => x.Name == name)].LikedMeals.Add(meal);
                            break;
                    case "Dislike":
                        if (!guests.Any(x => x.Name == name))
                            Console.WriteLine(name + " is not at the party.");
                        else if (!guests[guests.FindIndex(x => x.Name == name)].LikedMeals.Contains(meal))
                            Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                        else
                        {
                            Console.WriteLine($"{name} doesn't like the {meal}.");
                            guests[guests.FindIndex(x => x.Name == name)].LikedMeals.Remove(meal);
                            count++;
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item.Name+": "+String.Join(", ",item.LikedMeals));
                
            }
            Console.WriteLine("Unliked meals: "+count);
        }
        
    }
    public class Guest
   {
        public Guest(string name, string meal)
        {
            Name = name;
            LikedMeals = new List<string>();
            LikedMeals.Add(meal);
        }

        public string Name { get; set; }
        public List<string> LikedMeals { get; set; } 
    }
    
}
