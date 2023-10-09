using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MPL.Lexer 
{
    public class Lexer
    {
        private static string OPERATOR_CHARS = "+-*/()";
        private static TokenType[] OPERATOR_TOKENS =
        {
            TokenType.PLUS, TokenType.MINUS,
            TokenType.STAR, TokenType.SLACH,
            TokenType.LPAREN,TokenType.RPAREN,
        };
        private string input;
        private List<Token> tokens;
        private int pos;
        private int length;
        public Lexer(string input)
        {
            this.input = input;
            length = input.Length;
            tokens = new List<Token>();
        }
        public List<Token> tokenize()
        {
            while (pos < length)
            {
                char current = peek();
                if (char.IsDigit(current)) tokenizeNumber();
                else if (OPERATOR_CHARS.IndexOf(current) != -1)
                {
                    tokenizeOperator();
                }
                else
                {
                    next();
                }
            }
            return tokens;
        }
        private void tokenizeNumber()
        {
            StringBuilder buffer = new StringBuilder();
            char current = peek(0);
            while (char.IsDigit(current))
            {
                buffer.Append(current);
                current = next();
            }
            addToken(TokenType.NUMBER,buffer.ToString());
        }
        private void tokenizeOperator()
        {
            int position = OPERATOR_CHARS.IndexOf(peek());
            addToken(OPERATOR_TOKENS[position]);
            next();
        }
        private char next()
        {
            pos++;
            return peek();
        }
        private char peek(int relativePosition = 0)
        {
            int position = pos + relativePosition;
            if (position >= length) return '\0';
            return input[position];
        }
        private void addToken(TokenType type)
        {
            addToken(type, "");
        }
        private void addToken(TokenType type, string text)
        {
           tokens.Add(new Token(type, text));
        }
    }

}
