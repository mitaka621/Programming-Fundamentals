using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] arr = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] input2=input.Split().ToArray();
                string command=input2[0];
                int index1 = -1;
                int index2 = -1;
                if (input2.Length>1)
                {
                    index1 = int.Parse(input2[1]);
                    index2 = int.Parse(input2[2]);
                }
                

                switch (command)
                {
                    case "swap":
                        BigInteger temp = 0;
                        temp = arr[index1];
                        arr[index1] = arr[index2];
                        arr[index2] = temp;
                        break;
                    case "multiply":
                        arr[index1] = arr[index2] * arr[index1];
                        break;
                    case "decrease":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i]--;
                        }
                        break;
                    default:
                        break;
                }

              
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
