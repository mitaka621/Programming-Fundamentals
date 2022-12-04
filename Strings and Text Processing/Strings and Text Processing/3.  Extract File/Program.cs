using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = Console.ReadLine();

            string fileName=path.Substring(path.LastIndexOf('\\')+1,path.LastIndexOf('.')- path.LastIndexOf('\\')-1);
            string extension = path.Substring(path.LastIndexOf('.')+1);
            Console.WriteLine("File name: " + fileName);
            Console.WriteLine("File extension: "+extension);
        }
    }
}
