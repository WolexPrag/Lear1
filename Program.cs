using System;
using System.IO;
using System.Collections.Generic;
using Learn1.Other.Coderofk;
namespace Learn1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int IinputNum;
            int Iinput;
            string inputNum;
            string input;
            while (true)
            {
                try
                {

                
                    Console.Write("Enter num1: ");
                    input = Console.ReadLine(); 
                    if (input.Equals("End"))
                    {
                        break;
                    }
                    Console.WriteLine();
                    Console.Write("Enter num2: ");
                    inputNum = Console.ReadLine();
                    Iinput = Convert.ToInt32(input);
                    IinputNum = Convert.ToInt32(inputNum);
                    Console.WriteLine();
                    Console.WriteLine($"Result = {Solve(Iinput,IinputNum)}");
                    Console.WriteLine("====================");
                }
                catch (Exception)
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("========Error=======");
                    Console.WriteLine("====================");
                }
            }

        }
        public static int Solve(int num1,int num2)
        {
            return num1 >> num2;
        }
    }
   
}
