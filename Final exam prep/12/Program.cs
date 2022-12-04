using System;
using System.Collections.Generic;
using System.Linq;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Hero>heroes = new List<Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] input=Console.ReadLine().Split();
                heroes.Add(new Hero(input[0], int.Parse(input[1]), int.Parse(input[2])));

            }
            string input2;
            while ((input2=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input2.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name=cmdArgs[1];
                int value=int.Parse(cmdArgs[2]);
                switch (cmdArgs[0])
                {
                    case "CastSpell":
                        string spellName = cmdArgs[3];
                        
                        if (value<= heroes[heroes.FindIndex(x => x.Name == name)].MP)
                        {
                            heroes[heroes.FindIndex(x => x.Name == name)].MP-=value;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[heroes.FindIndex(x => x.Name == name)].MP} MP!");
                        }
                        else
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                        break;
                    case "TakeDamage":
                        string attacker = cmdArgs[3];
                        heroes[heroes.FindIndex(x => x.Name == name)].HP-=value;
                        if (heroes[heroes.FindIndex(x => x.Name == name)].HP > 0)
                        {
                            Console.WriteLine($"{name} was hit for {value} HP by {attacker} and now has {heroes[heroes.FindIndex(x => x.Name == name)].HP} HP left!");
                        }
                        else
                        {
                            heroes.RemoveAt(heroes.FindIndex(x => x.Name == name));
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":

                        if (heroes[heroes.FindIndex(x => x.Name == name)].MP + value > 200)
                        {
                            Console.WriteLine("{0} recharged for {1} MP!", name, value - (heroes[heroes.FindIndex(x => x.Name == name)].MP + value - 200));
                            heroes[heroes.FindIndex(x => x.Name == name)].MP =200;
                        }
                        else
                        {
                            Console.WriteLine("{0} recharged for {1} MP!", name, value);
                            heroes[heroes.FindIndex(x => x.Name == name)].MP += value;
                        }
                        break;
                    case "Heal":
                        if (heroes[heroes.FindIndex(x => x.Name == name)].HP + value > 100)
                        {
                            Console.WriteLine("{0} healed for {1} HP!", name, value - (heroes[heroes.FindIndex(x => x.Name == name)].HP + value - 100));
                            heroes[heroes.FindIndex(x => x.Name == name)].HP = 100;
                        }
                        else
                        {
                            Console.WriteLine("{0} healed for {1} HP!", name, value);
                            heroes[heroes.FindIndex(x => x.Name == name)].HP += value;
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in heroes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class Hero
    {
        public Hero(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public override string ToString()
        {
            return Name+"\n  HP: "+HP+"\n  MP: "+MP;
        }
    }
}
