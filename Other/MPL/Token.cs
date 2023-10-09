using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MPL
{
    public class Token
    {
        private TokenType _type;public TokenType type {get { return _type; } set { _type = value; }}
        private string _text; public string text { get { return _text; } set { _text = value; } }
        public Token()
        {

        }
        public Token(TokenType type, string text)
        {
            this.type = type;
            this.text = text;
        }
    }
}
