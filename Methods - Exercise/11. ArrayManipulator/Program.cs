using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _11.Array_Manipulator
{
    internal class Program
    {
        static int[] arr;

        public static void Exchange(BigInteger index, int[] array)
        {
            if (index> array.Length-1||index<0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            BigInteger[] outputArr=new BigInteger[array.Length];
            for (int i = 0; i <= index; i++)
            {
                outputArr[(int)(arr.Length-1-index+i)]= array[i];
            }
            int count = 0;
            for (BigInteger i = index+1; i < array.Length; i++)
            {
                outputArr[count]= array[(int)i];
                count++;
            }

            for (int i = 0; i < array.Length; i++)//update the starting array to the changed new array
            {
                arr[i] = (int)outputArr[i];
            }
        }

        public static void Max(string subCommand, int[] arr)
        {
            int indexMax=-1, maxNum = int.MinValue;
            if (subCommand == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] >= maxNum)
                    {
                        indexMax = i;
                        maxNum = arr[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] >= maxNum)
                    {
                        indexMax = i;
                        maxNum = arr[i];
                    }
                }
            }
            if (indexMax==-1)
            {
                Console.WriteLine("No matches");
            }
            else
            Console.WriteLine(indexMax);
        }

        public static void Min(string subCommand, int[] arr)
        {
            int indexMax = -1, minNum = int.MaxValue;
            if (subCommand == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] <= minNum)
                    {
                        indexMax = i;
                        minNum = arr[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] <= minNum)
                    {
                        indexMax = i;
                        minNum = arr[i];
                    }
                }
            }
            if (indexMax == -1)
            {
                Console.WriteLine("No matches");
            }
            else
                
            Console.WriteLine(indexMax);
        }


        public static void First(BigInteger countNum, string subComnad2, int[] arr)
        {
            if (countNum > arr.Length||countNum<0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int count = 1;

            List<string> output = new List<string>();
            output.Add("[");
            output.Add("]");
            if (subComnad2 == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && count <= countNum)
                    {
                        output.Insert(output.Count-1,arr[i].ToString());
                        output.Insert(output.Count - 1, ", ");
                        count++;
                    }
                }
                if (output.Count>2)
                {
                    output.RemoveAt(output.Count - 2);
                }
                
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && count <= countNum)
                    {
                        output.Insert(output.Count - 1, arr[i].ToString());
                        output.Insert(output.Count - 1, ", ");
                        count++;
                    }
                }
                if (output.Count > 2)
                {
                    output.RemoveAt(output.Count - 2);
                }
            }


            foreach (var item in output)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void Last(BigInteger countNum, string subComnad2, int[] arr)
        {
            if (countNum > arr.Length||countNum<0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<string> output = new List<string>();
            output.Add("[");
            output.Add("]");
            int count = 1;
            if (subComnad2 == "even")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0 && count <= countNum)
                    {
                        output.Insert(1, arr[i].ToString());
                        output.Insert(1, ", ");
                        count++;
                    }
                }

                if (output[1] == ", ")
                    output.RemoveAt(1);

                if (output[output.Count - 2] == ", ")
                    output.RemoveAt(output.Count - 2);
            }
            else
            {
                for (int i = arr.Length-1; i >=0; i--)
                {
                    if (arr[i] % 2 != 0 && count <= countNum)
                    {
                        output.Insert(1, arr[i].ToString());
                        output.Insert(1, ", ");
                        count++;
                    }
                }

                if (output[1] == ", ")
                    output.RemoveAt(1);

                if (output[output.Count - 2] == ", ")
                    output.RemoveAt(output.Count - 2);

            }
            foreach (var item in output)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command, subCommand1, subCommand2=null;
                if (inputArr.Length == 2)
                {
                    command = inputArr[0];
                    subCommand1 = inputArr[1];
                }
                else
                {
                    command = inputArr[0];
                    subCommand1 = inputArr[1];
                    subCommand2 = inputArr[2];
                }
                switch (command)
                {
                    case "exchange":
                        Exchange(BigInteger.Parse(subCommand1), arr);
                        break;
                    case "max":
                        Max(subCommand1, arr);
                        break;
                    case "min":
                        Min(subCommand1, arr);
                        break;
                    case "first":
                        First(BigInteger.Parse(subCommand1), subCommand2, arr);
                        break;
                    case "last":
                        Last(BigInteger.Parse(subCommand1), subCommand2, arr);
                        break;

                }

            }

            Console.Write("[" + String.Join(", ", arr) + "]");
        }
    }
}
