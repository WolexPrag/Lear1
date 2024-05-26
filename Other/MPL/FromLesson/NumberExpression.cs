namespace Learn1.Other.MPL.FromLesson
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
