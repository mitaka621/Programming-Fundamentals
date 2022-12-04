using System;
using System.Text;

namespace Final_exam_prep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string enc = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!= "Decode")
            {
                string[] cmdArg = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArg[0])
                {
                    case "Move":
                        int num = int.Parse(cmdArg[1]);
                        enc += enc.Substring(0,num);
                        enc = enc.Remove(0,num);
                        break;
                    case "Insert":
                        int index = int.Parse(cmdArg[1]);
                        string value = cmdArg[2];
                        enc = enc.Insert(index, value);
                        break;
                    case "ChangeAll":
                        enc = enc.Replace(cmdArg[1], cmdArg[2]);
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine("The decrypted message is: "+enc);
        }
    }
}
