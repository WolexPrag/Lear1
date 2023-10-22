using Learn1.Other;
using Learn1.Other.Randomizers;
using Learn1.Other.IIntelect;
using System;
using System.Collections.Generic;
using System.Text;
using Learn1.Other.MPL.FromLesson;
namespace Learn1
{
    internal class Program
    {

        public static int Parse(string expression)
        {
            int result = 0;
            return result;
        }
        public static void Main()
        {
            Parser parser = new Parser(new Lexer(Console.ReadLine()).tokenize());
            List<Expression> expression = parser.parse();
            for (int i = 0; i < expression.Count; i++)
            {
                Console.Write($"{expression[i]} = {expression[i].eval()}");
            }
        }
    }
}
