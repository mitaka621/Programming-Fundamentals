using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();

            string input;
            while ((input=Console.ReadLine())!="Travel")
            {
                string[] cmdargs = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                switch (cmdargs[0])
                {
                    case "Add Stop":
                        int index=int.Parse(cmdargs[1]);
                        if (index>=0&&index<=a.Length)
                        {
                            a = a.Insert(index, cmdargs[2]);
                            Console.WriteLine(a);
                        }
                        break;
                    case "Remove Stop":
                        int start=int.Parse(cmdargs[1]);
                        int end=int.Parse(cmdargs[2]);
                        if (start>=0&&start<a.Length&&end>=0&&end<a.Length&&start<end)
                        {
                            a = a.Remove(start, end - start+1);
                            Console.WriteLine(a);
                        }
                        break;
                    case "Switch":
                        if (a.Contains(cmdargs[1]))
                        {
                           a= a.Replace(cmdargs[1], cmdargs[2]);
                            Console.WriteLine(a);
                        }
                       
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("Ready for world tour! Planned stops: "+a);
        }
    }
}
