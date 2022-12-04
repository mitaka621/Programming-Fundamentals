using System;
using System.Text.RegularExpressions;

namespace Findamentals_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Complete")
            {
                string[] cmdArgs = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "Make":
                        int index = int.Parse(cmdArgs[2]);
                        string temp;
                        if (cmdArgs[1] == "Upper")
                        {
                           temp=password.Substring(index,1).ToUpper();
                            password=password.Remove(index,1);
                            password=password.Insert(index,temp);
                            Console.WriteLine(password);
                        }
                        if (cmdArgs[1] == "Lower")
                        {
                            temp = password.Substring(index, 1).ToLower();
                            password = password.Remove(index, 1);
                            password = password.Insert(index, temp);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Insert":
                        int index2 = int.Parse(cmdArgs[1]);
                        if (index2 >= 0 && index2 <= password.Length)
                        {
                            password = password.Insert(index2, cmdArgs[2]);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Replace":
                        if (password.Contains(cmdArgs[1]))
                        {
                            char[] ch = cmdArgs[1].ToCharArray();
                            int value = (int)ch[0] + int.Parse(cmdArgs[2]);
                            password = password.Replace(ch[0],(char)value);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Validation":
                        string words = @"\w";
                        string capitalLeter = @"[A-Z]";
                        string lowerLeter = @"[a-z]";
                        string digit = @"\d";
                        Regex isWords = new Regex(words);
                        Regex isCapital = new Regex(capitalLeter);
                        Regex isLowerLeter = new Regex(lowerLeter);
                        Regex isDigit = new Regex(digit);
                        if (password.Length < 8)
                            Console.WriteLine("Password must be at least 8 characters long!");
                         if (isWords.Matches(password).Count!=password.Length)
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                         if (!isCapital.Match(password).Success)
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                         if (!isLowerLeter.Match(password).Success)
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                         if (!isDigit.Match(password).Success)
                            Console.WriteLine("Password must consist at least one digit!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
