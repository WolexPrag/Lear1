using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.Coderofk
{
    public static class TestCodering
    {
        public static Codering UseCodering()
        {
            Console.Write("Enter text:");
            Codering coder = new Codering(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < coder.getChars().Count; i++)
            {
                Console.Write($"([{i}]'{coder.getChars()[i]}')");
                if (i + 1 < coder.getChars().Count)
                {
                    Console.Write(',');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            Console.WriteLine(coder.getIndexingText());

            Console.WriteLine(coder.getText());
            return coder;
        }
    }
    public class Codering
    {
        protected List<char> symbols;
        protected int currentPos;
        protected string text;
        public Codering(List<char> symbols, string text, int currentPos = 0)
        {
            this.symbols = symbols;
            this.text = text;
            this.currentPos = currentPos;
        }
        public Codering(string text)
        {
            Decode(text);
            currentPos = 0;
        }
        public string getText()
        {
            return Encode();
        }
        public List<char> getChars()
        {
            return symbols;
        }
        public string getIndexingText()
        {
            return text;
        }
        protected void Decode(string text)
        {
            List<char> lchar = new List<char>();
            string codestr = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (lchar.Contains(text[i]) == false)
                {
                    lchar.Add(text[i]);
                }
                codestr = codestr + ' ' + lchar.IndexOf(text[i]);
            }
            symbols = lchar;
            this.text = codestr;
        }
        protected string Encode()
        {
            string res = "";
            while (text.Length > currentPos)
            {
                res = res + getSymbol();
                currentPos += 1;
            }
            return res;
        }
        protected char Peek(int addPos = 0)
        {
            if (currentPos + addPos >= text.Length) return '\0';
            return text[currentPos + addPos];
        }
        protected char getSymbol()
        {
            string index = "";
            for (int i = currentPos; i < text.Length; i++)
            {
                currentPos = i;
                if (index.Equals("") && Peek().Equals(' '))
                {
                    continue;
                }
                else if (Peek().Equals(' ') || Peek().Equals('\0'))
                {
                    break;
                }
                index = index + Peek();
            }


            return symbols[Convert.ToInt32(index)];
        }
    }
}
