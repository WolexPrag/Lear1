using Learn1.Other;
using Learn1.Other.Randomizers;
namespace Learn1
{
    internal class Program
    {
        public static void Main()
        {
            GeneratorName genName = new GeneratorName();
            int countNames = 1000;
            for (int i = 0; i < countNames; i++)
            {
                UseFunc.Print(genName.Generate() + "; ");
            }
            
        }
        

    }

}
