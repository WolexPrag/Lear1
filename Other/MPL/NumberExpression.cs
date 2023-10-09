using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Other.MPL
{
    public class NumberExpression : Expression
    {
        private double value; 
        public NumberExpression(double value)
        {
            this.value = value;
        }
        double Expression.eval()
        {
            return value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
