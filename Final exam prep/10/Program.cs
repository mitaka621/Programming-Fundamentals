using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pass = Console.ReadLine();

            string input;
            while ((input=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = input.Split();
                switch (cmdArgs[0])
                {
                    case "TakeOdd":
                        string newPass=String.Empty;
                        for (int i = 1; i < pass.Length; i+=2)
                        {
                            newPass += pass[i];
                        }
                        
                        Console.WriteLine(newPass);
                        pass = newPass;
                        break;
                    case "Cut":
                        int index = int.Parse(cmdArgs[1]);
                        int length=int.Parse(cmdArgs[2]);
                        pass=pass.Remove(index, length);
                        Console.WriteLine(pass);
                        break;
                    case "Substitute":
                        string substring=cmdArgs[1];
                        string substitute=cmdArgs[2];
                        if (pass.IndexOf(substring) !=-1)
                        {
                            pass = pass.Replace(substring, substitute);
                            Console.WriteLine(pass);
                        }
                        else
                            Console.WriteLine("Nothing to replace!");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Your password is: "+pass);
        }
    }
}
