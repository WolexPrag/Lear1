using System.Collections.Generic;
using System;


namespace Lear1
{

    class Program
    {
        public static void Print(object text)
        {
            Console.WriteLine(text);
        }
        public static string Input(string text = "")
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        public static decimal InputDecimal(string text = "")
        {
            Console.Write(text);
            return decimal.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
        }
    }
}
