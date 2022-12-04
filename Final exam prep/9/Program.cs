using System;
using System.Collections.Generic;
using System.Linq;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Car>cars=new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car(input[0], int.Parse(input[1]), int.Parse(input[2])));
            }
            string input2;
            while ((input2=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input2.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[1];
                switch (cmdArgs[0])
                {
                    case "Drive":

                        int distance = int.Parse(cmdArgs[2]);
                        int fuel = int.Parse(cmdArgs[3]);
                        if (cars[cars.FindIndex(x => x.Name == name)].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            Console.WriteLine("{0} driven for {1} kilometers. {2} liters of fuel consumed.",name,distance,fuel);
                            cars[cars.FindIndex(x => x.Name == name)].Fuel -= fuel;
                            cars[cars.FindIndex(x => x.Name == name)].Milage += distance;
                        }

                        if (cars[cars.FindIndex(x => x.Name == name)].Milage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {name}!");
                            cars.RemoveAt(cars.FindIndex(x => x.Name == name));
                        }
                        break;
                    case "Refuel":
                        int fuel2 = int.Parse(cmdArgs[2]);

                        if (cars[cars.FindIndex(x => x.Name == name)].Fuel + fuel2 > 75)
                        {
                            Console.WriteLine("{0} refueled with {1} liters", name, 75 - cars[cars.FindIndex(x => x.Name == name)].Fuel);
                            cars[cars.FindIndex(x => x.Name == name)].Fuel = 75;

                        }
                        else
                        {
                            Console.WriteLine("{0} refueled with {1} liters", name, fuel2);
                            cars[cars.FindIndex(x => x.Name == name)].Fuel += fuel2;
                        }
                        break;
                    case "Revert":
                        int km = int.Parse(cmdArgs[2]);
                        if (cars[cars.FindIndex(x => x.Name == name)].Milage - km < 10000)
                        {
                            cars[cars.FindIndex(x => x.Name == name)].Milage =10000;
                        }
                        else
                        {
                            Console.WriteLine("{0} mileage decreased by {1} kilometers",name,km);
                            cars[cars.FindIndex(x => x.Name == name)].Milage -= km;
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class Car
    {
        public Car(string name, int milage, int fuel)
        {
            Name = name;
            Milage = milage;
            Fuel = fuel;
        }

        public string Name { get; set; }
        public int Milage { get; set; }
        public int Fuel { get; set; }
        public override string ToString()
        {
            return String.Format("{0} -> Mileage: {1} kms, Fuel in the tank: {2} lt.", Name, Milage, Fuel);
        }
    }
}
