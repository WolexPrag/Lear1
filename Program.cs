using System;
using System.Collections.Generic;
namespace Lear1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(ToCamelCase("The-warion-For"));
         
        }
        public static string ToCamelCase(string str)
        {
            bool needUp = false;
            string retstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char setr = str[i];
                if (needUp == true)
                {
                    setr = Char.ToUpper(setr);
                    needUp = false;
                }
                if (setr.Equals('-') || setr.Equals('_'))
                {
                    needUp = true;
                }
                else
                {
                    retstr = retstr + setr.ToString();
                }
            }

            return retstr;
        }

    }
}
