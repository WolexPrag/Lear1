using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MPL
{
    public class Parser
    {
        private static Token EOF = new Token(TokenType.EOF, "");
        private List<Token> tokens;
        private int size;
        private int pos;
        public Parser(List<Token> tokens)
        {
            this.tokens = tokens;
            size = tokens.Count();
        }
        public List<Expression> parse()
        {
            List<Expression> result = new List<Expression>();
            while (!match(TokenType.EOF))
            {
                result.Add(expression());
            }
            return result;
        }
        private Expression expression()
        {
            return addtive();
        }
        private Expression addtive()
        {
            Expression result = multiplicative();
            while (true)
            {
                if (match(TokenType.PLUS))
                {
                    result = new BinaryExpression('+', result, multiplicative());
                    continue;
                }
                if (match(TokenType.MINUS))
                {
                    result = new BinaryExpression('-', result, multiplicative());
                    continue;
                }
                break;
            }
            return result;
        }
        private Expression multiplicative()
        {
            Expression result = unary();
            while (true)
            {
                if (match(TokenType.STAR))
                {
                    result = new BinaryExpression('*', result, unary());
                    continue;
                }
                if (match(TokenType.SLACH))
                {
                    result = new BinaryExpression('/',result, unary());
                    continue;
                }
                break;
            }
            
            return result;
        }
        private Expression unary()
        {
            if (match(TokenType.MINUS))
            {
                return new UnaryExpression('-',primary());
            }
            if (match(TokenType.PLUS))
            {
                return primary();
            }
            return primary();
        }
        private Expression primary()
        {
            Token current = get();
            if (match(TokenType.NUMBER))
            {
                return new NumberExpression(double.Parse(current.text));
            }
            if (match(TokenType.LPAREN))
            {
                Expression result = expression();
                match(TokenType.RPAREN);
                return result;
            }
            throw new Exception("Unknown expression");
        }
        private bool match(TokenType type)
        {
            Token current = get();
            if (type != current.type) return false;
            pos++;
            return true;
        }
        private Token get(int relativePosition = 0)
        {
            int position = pos + relativePosition;
            if (position >= size) return EOF;
            return tokens[position];
        }
    }
}
