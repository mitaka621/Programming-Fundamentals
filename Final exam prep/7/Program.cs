using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string m = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmdargs=input.Split(":|:");
                switch (cmdargs[0])

                {
                    case "InsertSpace":
                        int index=int.Parse(cmdargs[1]);
                        m=m.Insert(index, " ");
                        break;
                    case "Reverse":
                        string substr=cmdargs[1];
                        if (m.IndexOf(substr) == -1)
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        else
                        {
                            char[] temp = m.Substring(m.IndexOf(substr), substr.Length).ToCharArray();
                            Array.Reverse(temp);
                            m = m.Remove(m.IndexOf(substr), substr.Length);
                            m += string.Join("",temp);

                        }
                            break;
                    case "ChangeAll":
                        string substr1=cmdargs[1];
                        string replacment=cmdargs[2];
                        
                        m=m.Replace(substr1, replacment);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(m);
            }
            Console.WriteLine("You have a new text message: "+m);
        }
    }
}
