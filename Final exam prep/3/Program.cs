using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                pieces.Add(new Piece(input[0], input[1], input[2]));
            }

            string input2;
            while ((input2=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input2.Split("|", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Add":
                    if (pieces.Any(x => x.Name == cmdArgs[1]))
                        {
                            Console.WriteLine($"{cmdArgs[1]} is already in the collection!");
                        }
                        else
                        {
                            pieces.Add(new Piece(cmdArgs[1], cmdArgs[2], cmdArgs[3]));
                            Console.WriteLine($"{cmdArgs[1]} by {cmdArgs[2]} in {cmdArgs[3]} added to the collection!");
                        }
                            

                        break;
                    case "Remove":
                        if (pieces.Any(x => x.Name == cmdArgs[1]))
                        {
                            pieces = pieces.Where(x => x.Name != cmdArgs[1]).ToList();
                            Console.WriteLine($"Successfully removed {cmdArgs[1]}!");
                        }
                        else
                            Console.WriteLine($"Invalid operation! {cmdArgs[1]} does not exist in the collection.");
                        break;
                    case "ChangeKey":
                        if (pieces.Any(x => x.Name == cmdArgs[1]))
                        {
                            pieces[pieces.FindIndex(x => x.Name == cmdArgs[1])].Key = cmdArgs[2];
                            Console.WriteLine($"Changed the key of {cmdArgs[1]} to {cmdArgs[2]}!");
                        }
                        else
                            Console.WriteLine($"Invalid operation! {cmdArgs[1]} does not exist in the collection.");

                        break;

                    default:
                        break;
                }

            }
            foreach (var item in pieces)
            {
                Console.WriteLine($"{item.Name} -> Composer: {item.Composer}, Key: {item.Key}");
            }
        }
    }
    public class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; }
        public string Composer { get;  }
        public string Key { get; set; }
    }
}
