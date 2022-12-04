using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string key = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = input.Split(">>>");
                switch (cmdArgs[0])
                {
                    case "Contains":
                        if (key.Contains(cmdArgs[1]))
                        {
                            Console.WriteLine($"{key} contains {cmdArgs[1]}");
                        }
                        else
                            Console.WriteLine("Substring not found!");
                        break;
                    case "Flip":
                        string temp;
                        int start = int.Parse(cmdArgs[2]);
                        int end = int.Parse(cmdArgs[3]);
                        if (cmdArgs[1] == "Upper")
                        {
                            temp = key.Substring(start, end - start);
                            key = key.Remove(start, end - start);
                            temp = temp.ToUpper();
                            key = key.Insert(start, temp);

                        }
                        else
                        {
                            temp = key.Substring(start, end - start);
                            key = key.Remove(start, end - start);
                            temp = temp.ToLower();
                            key = key.Insert(start, temp);
                        }
                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int endIndex = int.Parse(cmdArgs[2]);
                        key=key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Your activation key is: "+key);
        }
    }
}
