using Learn1.Other;
using Learn1.Other.Randomizers;
using Learn1.Other.IIntelect;
using System;
using System.Collections.Generic;
using System.Text;
/*using Learn1.Other.MPL.FromLesson;*/
namespace Learn1
{
    internal class Program
    {

        public static int Parse(string expression)
        {
            List<string> data = new List<string>(expression.Length);
            List<int> posOnePrioritet = new List<int>();
            List<int> posTwoPrioritet = new List<int>();
            List<int> posOperatorsSorted = new List<int>(); 
            StringBuilder stringBuilder = new StringBuilder();
            int result = 0;
            
            for (int i = 0; i < expression.Length; i++)
            {
                {

                    if (char.IsDigit(expression[i]) == true )
                    {
                        stringBuilder.Append(expression[i]);

                        if ((i == expression.Length - 1) == false) {
                            if (char.IsDigit(expression[i + 1]) == false)
                            {
                                data.Add(stringBuilder.ToString());
                                stringBuilder.Clear();
                                continue;
                            }
                        }
                    }
                    else if (expression[i] == '+')
                    {
                        stringBuilder.Append('+');
                        data.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                        posTwoPrioritet.Add(data.Count - 1);
                        continue;
                    }
                    else if (expression[i] == '-')
                    {
                        stringBuilder.Append('-');
                        data.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                        posTwoPrioritet.Add(data.Count - 1);
                        continue;
                    }
                    else if (expression[i] == '*')
                    {
                        stringBuilder.Append('*');
                        data.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                        posOnePrioritet.Add(data.Count - 1);
                        continue;
                    }
                    else if (expression[i] == '/')
                    {
                        stringBuilder.Append('/');
                        data.Add(stringBuilder.ToString());
                        stringBuilder.Clear(); 
                        posOnePrioritet.Add(data.Count - 1);
                        continue;
                    }
                    else if(expression[i] == ' ')
                    {
                        stringBuilder.Clear();
                        continue;
                    }
                    if (i == expression.Length - 1)
                    {
                        data.Add(stringBuilder.ToString());
                        stringBuilder.Clear();
                        continue;
                    }

                }
            }
            posOperatorsSorted.AddRange(posOnePrioritet);
            posOperatorsSorted.AddRange(posTwoPrioritet);
            result = int.Parse(data[0]);
            for (int i = 0; i < posOperatorsSorted.Count; i++)
            {
                if (data[posOperatorsSorted[i]].Equals("+"))
                {
                    result = result + int.Parse(data[(posOperatorsSorted[i] + 1)]);
                    continue;
                }
                else if (data[posOperatorsSorted[i]].Equals("-"))
                {
                    result = result - int.Parse(data[(posOperatorsSorted[i] + 1)]);
                    continue;
                }
                else if (data[posOperatorsSorted[i]].Equals("*"))
                {
                    result += int.Parse(data[(posOperatorsSorted[i] - 1)]) * int.Parse(data[(posOperatorsSorted[i] + 1)]);
                    continue;
                }
                else if (data[posOperatorsSorted[i]].Equals("/"))
                {
                    result += int.Parse(data[(posOperatorsSorted[i] - 1)]) / int.Parse(data[(posOperatorsSorted[i] + 1)]);
                    continue;
                }
            }
            return result;
        }
        public static void Main()
        {
            while (true)
            {
                string expression = Console.ReadLine();
                Console.WriteLine($"{expression} = {Parse(expression)}");
                
            }
            
        }
    }
}
