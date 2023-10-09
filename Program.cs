using Learn1.Other;
using Learn1.Other.Randomizers;
using Learn1.Other.IIntelect;
using System;
using System.Collections.Generic;
using Learn1.Other.MPL;
using Learn1.Other.MPL.Lexer;
namespace Learn1
{
    internal class Program
    {

        public static void Main()
        {
            Print("Enter: ");
            string input = Console.ReadLine();
            List<Token> tokens = new Lexer(input).tokenize();

            foreach (Token token in tokens)
            {
                Print(token.type.ToString(), " ");
            }
            NextLn();
            List<Expression> expressions = new Parser(tokens).parse();
            foreach (Expression expr in expressions)
            {
                Print(expr + " = " + expr.eval());
            }
        }
        public static void Print(params Object[] alltext)
        {
            foreach (var text in alltext)
            {
                Console.Write(text);
            }
        }
        public static void PrintLn(params Object[] alltext)
        {
            foreach (var text in alltext)
            {
                Console.WriteLine (text);
            }
        }
        public static void NextLn()
        {
            Console.WriteLine();
        }
    }

}
