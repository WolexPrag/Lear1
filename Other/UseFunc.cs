using System;
using System.Collections.Generic;

namespace Learn1.Other
{
    public static class UseFunc
    {
        public static void WriteList(List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine($"Name: {text}");
            }
        }
        public static void Stoper()
        {
            string answer = "";
            for (int i = 0; answer.Equals("yes") == false; i++)
            {
                Console.Write("Continew: ");
                answer = Console.ReadLine();
            }

        }
        public static void Print(string text)
        {
            Console.Write(text);
        }
        public static void PrintLn(string text)
        {
            Console.WriteLine(text);
        }
    }
}
