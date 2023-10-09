using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MPL
{
    public class BinaryExpression : Expression 
    {
        private Expression expr1, expr2;
        private char operation;
        public BinaryExpression(char operation, Expression expr1,Expression expr2)
        {
            this.operation = operation;
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        double Expression.eval()
        {
            switch (operation)
            {
                case '+':
                    return expr1.eval() + expr2.eval();
                case '-':
                    return expr1.eval() - expr2.eval();
                case '*':
                    return expr1.eval() * expr2.eval();
                case '/':
                    return expr1.eval() / expr2.eval();
                default:
                    throw new Exception("Unknown Parameter");
            }   
        }
        public override string ToString()
        {
            return $"{expr1} {operation} {expr2}";
        }
    }
}
