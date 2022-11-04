using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataBase = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();
                string username = arg[1];
                
                switch (arg[0])
                {
                    case "register":
                        string licensePlate = arg[2];
                        if (dataBase.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            dataBase.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":
                        if (!dataBase.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            dataBase.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var item in dataBase)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
