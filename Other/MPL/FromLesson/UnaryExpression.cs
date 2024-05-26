using System;

namespace Learn1.Other.MPL.FromLesson
{
    public class UnaryExpression : Expression
    {
        private Expression expr1;
        private char operation;
        public UnaryExpression(char operation, Expression expr1)
        {
            this.operation = operation;
            this.expr1 = expr1;
        }
        double Expression.eval()
        {
            switch (operation)
            {
                case '+':
                    return expr1.eval();
                case '-':
                    return -expr1.eval();
                default:
                    throw new Exception("Unknown Parameter");
            }
        }
        public override string ToString()
        {
            return $"{operation} {expr1}";
        }
    }
}
